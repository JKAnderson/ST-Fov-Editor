using System;
using System.IO;

namespace ST_Fov_Editor
{
    class Patcher
    {
        public static float? Scan(MainForm mainForm, string binPath, PatchInfo patchInfo)
        {
            string filePath = binPath + @"\" + patchInfo.Filename;
            if (File.Exists(filePath))
            {
                byte[] bytes = File.ReadAllBytes(filePath);
                if (bytes.Length != patchInfo.Size)
                {
                    mainForm.Log("Unexpected dll size; expected {0} bytes, got {1} bytes\r\nMake sure you have the correct version selected, and are not using modified dlls",
                        patchInfo.Size, bytes.Length);
                    return null;
                }
                float currentHFov = BitConverter.ToSingle(bytes, patchInfo.Offset);
                return currentHFov;
            }
            else
            {
                mainForm.Log("File not found: {0}", filePath);
                return null;
            }
        }

        public static bool Patch(MainForm mainForm, string binPath, PatchInfo patchInfo, float desiredValue)
        {
            string filePath = binPath + @"\" + patchInfo.Filename;
            string bakPath = filePath + ".bak";
            if (!File.Exists(bakPath))
            {
                try
                {
                    File.Copy(filePath, bakPath);
                }
                catch (UnauthorizedAccessException)
                {
                    mainForm.Log("Access denied; could not backup xrGame.dll");
                    return false;
                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Open)))
            {
                writer.Seek(patchInfo.Offset, SeekOrigin.Begin);
                writer.Write(desiredValue);
            }
            return true;
        }

        public static bool Restore(MainForm mainForm, string binPath, PatchInfo patchInfo)
        {
            string filePath = binPath + @"\" + patchInfo.Filename;
            string bakPath = filePath + ".bak";
            if (File.Exists(bakPath))
            {
                if (File.Exists(filePath))
                {
                    try
                    {
                        File.Delete(filePath);
                    }
                    catch (UnauthorizedAccessException)
                    {
                        mainForm.Log("Access denied; could not delete {0}", patchInfo.Filename);
                        return false;
                    }
                }
                try
                {
                    File.Move(bakPath, filePath);
                }
                catch (UnauthorizedAccessException)
                {
                    mainForm.Log("Access denied; could not restore {0}", patchInfo.Filename + ".bak");
                    return false;
                }
                return true;
            }
            else
            {
                mainForm.Log("There is no backup to restore");
                return false;
            }
        }
    }
}
