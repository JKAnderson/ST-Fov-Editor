using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ST_Fov_Editor
{
    public partial class MainForm : Form
    {
        private static readonly RegistryKey registry = Registry.CurrentUser.CreateSubKey(@"Software\ST Fov Editor");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (string name in VersionInfo.GetNames())
                comboBoxVersion.Items.Add(name);

            Size size = new Size((int)registry.GetValue("FormWidth", 0), (int)registry.GetValue("FormHeight", 0));
            Point location = new Point((int)registry.GetValue("FormX", 0), (int)registry.GetValue("FormY", 0));
            if (!size.IsEmpty)
            {
                this.Location = location;
                this.Size = size;
            }
            textBoxBin.Text = (string)registry.GetValue("BinFolder", String.Empty);
            comboBoxVersion.SelectedIndex = (int)registry.GetValue("GameVersion", 0);
            numericUpDownDesiredFov.Value = Decimal.Parse((string)registry.GetValue("DesiredFov", "83"));
            numericUpDownDesiredHudFov.Value = Decimal.Parse((string)registry.GetValue("DesiredHudFov", "0.45"));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            registry.SetValue("FormWidth", this.Size.Width);
            registry.SetValue("FormHeight", this.Size.Height);
            registry.SetValue("FormX", this.Location.X);
            registry.SetValue("FormY", this.Location.Y);
            registry.SetValue("BinFolder", textBoxBin.Text);
            registry.SetValue("GameVersion", comboBoxVersion.SelectedIndex);
            registry.SetValue("DesiredFov", numericUpDownDesiredFov.Value.ToString());
            registry.SetValue("DesiredHudFov", numericUpDownDesiredHudFov.Value.ToString());
        }

        public void Log(string format, params object[] args)
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

        private void textBoxBin_TextChanged(object sender, EventArgs e)
        {
            textBoxCurrentFov.Clear();
            buttonPatchFov.Enabled = false;
            textBoxCurrentHudFov.Clear();
            buttonPatchHudFov.Enabled = false;
        }

        private void comboBoxVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonScanFov.Enabled = comboBoxVersion.SelectedIndex > 0;
            buttonScanHudFov.Enabled = comboBoxVersion.SelectedIndex > 0;
            textBoxCurrentFov.Clear();
            buttonPatchFov.Enabled = false;
            textBoxCurrentHudFov.Clear();
            buttonPatchHudFov.Enabled = false;
        }

        #region Field of view buttons
        private void buttonScanFov_Click(object sender, EventArgs e)
        {
            PatchInfo fovPatch = VersionInfo.GetVersion(comboBoxVersion.SelectedIndex).FovPatch;
            float? result = Patcher.Scan(this, textBoxBin.Text, fovPatch);
            if (result != null)
            {
                textBoxCurrentFov.Text = result.ToString();
                buttonPatchFov.Enabled = true;
                Log("{0} scanned successfully", fovPatch.Filename);
            }
        }

        private void buttonPatchFov_Click(object sender, EventArgs e)
        {
            PatchInfo fovPatch = VersionInfo.GetVersion(comboBoxVersion.SelectedIndex).FovPatch;
            bool success = Patcher.Patch(this, textBoxBin.Text, fovPatch, (float)numericUpDownDesiredFov.Value);
            if (success)
            {
                textBoxCurrentFov.Text = numericUpDownDesiredFov.Value.ToString();
                Log("{0} patched successfully", fovPatch.Filename);
            }
        }

        private void buttonRestoreFov_Click(object sender, EventArgs e)
        {
            PatchInfo fovPatch = VersionInfo.GetVersion(comboBoxVersion.SelectedIndex).FovPatch;
            bool success = Patcher.Restore(this, textBoxBin.Text, fovPatch);
            if (success)
            {
                textBoxCurrentFov.Clear();
                buttonPatchFov.Enabled = false;
                Log("{0} backup restored successfully", fovPatch.Filename);
            }
        }

        private void buttonDefaultFov_Click(object sender, EventArgs e)
        {
            PatchInfo fovPatch = VersionInfo.GetVersion(comboBoxVersion.SelectedIndex).FovPatch;
            numericUpDownDesiredFov.Value = (decimal)fovPatch.Default;
        }
        #endregion

        #region HUD Fov buttons
        private void buttonScanHudFov_Click(object sender, EventArgs e)
        {
            PatchInfo hudFovPatch = VersionInfo.GetVersion(comboBoxVersion.SelectedIndex).HudFovPatch;
            float? result = Patcher.Scan(this, textBoxBin.Text, hudFovPatch);
            if (result != null)
            {
                textBoxCurrentHudFov.Text = result.ToString();
                buttonPatchHudFov.Enabled = true;
                Log("{0} scanned successfully", hudFovPatch.Filename);
            }
        }

        private void buttonPatchHudFov_Click(object sender, EventArgs e)
        {
            PatchInfo hudFovPatch = VersionInfo.GetVersion(comboBoxVersion.SelectedIndex).HudFovPatch;
            bool success = Patcher.Patch(this, textBoxBin.Text, hudFovPatch, (float)numericUpDownDesiredHudFov.Value);
            if (success)
            {
                textBoxCurrentHudFov.Text = numericUpDownDesiredHudFov.Value.ToString();
                Log("{0} patched successfully", hudFovPatch.Filename);
            }
        }

        private void buttonRestoreHudFov_Click(object sender, EventArgs e)
        {
            PatchInfo hudFovPatch = VersionInfo.GetVersion(comboBoxVersion.SelectedIndex).HudFovPatch;
            bool success = Patcher.Restore(this, textBoxBin.Text, hudFovPatch);
            if (success)
            {
                textBoxCurrentHudFov.Clear();
                buttonPatchHudFov.Enabled = false;
                Log("{0} backup restored successfully", hudFovPatch.Filename);
            }
        }

        private void buttonDefaultHudFov_Click(object sender, EventArgs e)
        {
            PatchInfo hudFovPatch = VersionInfo.GetVersion(comboBoxVersion.SelectedIndex).HudFovPatch;
            numericUpDownDesiredHudFov.Value = (decimal)hudFovPatch.Default;
        }
        #endregion
    }
}
