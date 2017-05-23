using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_Fov_Editor
{
    public partial class MainForm : Form
    {
        private const string DLL_NAME = @"\xrGame.dll";
        private const string BAK_NAME = @"\xrGame.fovbak";

        private readonly RegistryKey registry = Registry.CurrentUser.CreateSubKey(@"Software\ST Fov Editor");

        private struct VersionInfo
        {
            public int Size;
            public int Offset;

            public VersionInfo(int size, int offset)
            {
                Size = size;
                Offset = offset;
            }
        }
        private readonly Dictionary<int, VersionInfo> versionInfo = new Dictionary<int, VersionInfo>()
        {
            // SoC 1.0004
            [1] = new VersionInfo(0x005B2000, 0x004F13C4),
            // SoC 1.0005
            [2] = new VersionInfo(0x005B7000, 0x004F5504),
            // SoC 1.0006
            [3] = new VersionInfo(0x005F5000, 0x0053C598),
            // CS 1.5.10
            [4] = new VersionInfo(0x006B32C0, 0x005DC8F8),
            // CoP 1.6.02
            [5] = new VersionInfo(0x006EC2C0, 0x00635C44),
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Size size = new Size((int)registry.GetValue("FormWidth", 0), (int)registry.GetValue("FormHeight", 0));
            Point location = new Point((int)registry.GetValue("FormX", 400), (int)registry.GetValue("FormY", 400));
            if (!size.IsEmpty)
            {
                this.Location = location;
                this.Size = size;
            }
            textBoxBin.Text = (string)registry.GetValue("BinFolder", String.Empty);
            comboBoxVersion.SelectedIndex = (int)registry.GetValue("GameVersion", 0);
            numericUpDownDesiredHFov.Value = Decimal.Parse((string)registry.GetValue("DesiredHFov", "83"));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            registry.SetValue("FormWidth", this.Size.Width);
            registry.SetValue("FormHeight", this.Size.Height);
            registry.SetValue("FormX", this.Location.X);
            registry.SetValue("FormY", this.Location.Y);
            registry.SetValue("BinFolder", textBoxBin.Text);
            registry.SetValue("GameVersion", comboBoxVersion.SelectedIndex);
            registry.SetValue("DesiredHFov", numericUpDownDesiredHFov.Value.ToString());
        }

        private void Log(string format, params object[] args)
        {
            string message = String.Format(format, args);
            if (textBoxLog.TextLength > 0)
                textBoxLog.AppendText("\r\n");
            textBoxLog.AppendText(message);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialogBin.SelectedPath = textBoxBin.Text;
            folderBrowserDialogBin.ShowDialog();
            textBoxBin.Text = folderBrowserDialogBin.SelectedPath;
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            string dllPath = textBoxBin.Text + DLL_NAME;
            VersionInfo version = versionInfo[comboBoxVersion.SelectedIndex];
            if (File.Exists(dllPath))
            {
                byte[] xrGame = File.ReadAllBytes(dllPath);
                if (xrGame.Length != version.Size)
                {
                    Log("Unexpected dll size; expected {0} bytes, got {1} bytes\r\nMake sure you have the correct version selected, and are not using modified dlls",
                        version.Size, xrGame.Length);
                    return;
                }
                float currentHFov = BitConverter.ToSingle(xrGame, version.Offset);
                textBoxCurrentHFov.Text = currentHFov.ToString();
                buttonPatch.Enabled = true;
                Log("Fov scanned successfully");
            }
            else
            {
                Log("File not found: {0}", dllPath);
            }
        }

        private void buttonPatch_Click(object sender, EventArgs e)
        {
            string dllPath = textBoxBin.Text + DLL_NAME;
            string bakPath = textBoxBin.Text + BAK_NAME;
            int offset = versionInfo[comboBoxVersion.SelectedIndex].Offset;
            if (!File.Exists(bakPath))
            {
                try
                {
                    File.Copy(dllPath, bakPath);
                }
                catch (UnauthorizedAccessException)
                {
                    Log("Access denied; could not backup xrGame.dll");
                    return;
                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open(dllPath, FileMode.Open)))
            {
                writer.Seek(offset, SeekOrigin.Begin);
                writer.Write((float)numericUpDownDesiredHFov.Value);
            }
            textBoxCurrentHFov.Text = numericUpDownDesiredHFov.Value.ToString();
            Log("Fov patched successfully");
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            string dllPath = textBoxBin.Text + DLL_NAME;
            string bakPath = textBoxBin.Text + BAK_NAME;
            if (File.Exists(bakPath))
            {
                if (File.Exists(dllPath))
                {
                    try
                    {
                        File.Delete(dllPath);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Log("Access denied; could not delete xrGame.dll");
                        return;
                    }
                }
                try
                {
                    File.Move(bakPath, dllPath);
                }
                catch (UnauthorizedAccessException)
                {
                    Log("Access denied; could not restore backup");
                    return;
                }
                textBoxCurrentHFov.Clear();
                textBoxCurrentVFov.Clear();
                buttonPatch.Enabled = false;
                Log("Backup restored successfully");
            }
            else
            {
                Log("There is no backup to restore");
            }
        }

        private void textBoxBin_TextChanged(object sender, EventArgs e)
        {
            textBoxCurrentHFov.Clear();
            textBoxCurrentVFov.Clear();
            buttonPatch.Enabled = false;
        }

        private void comboBoxVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonScan.Enabled = comboBoxVersion.SelectedIndex != 0;
            textBoxCurrentHFov.Clear();
            textBoxCurrentVFov.Clear();
            buttonPatch.Enabled = false;
        }
    }
}
