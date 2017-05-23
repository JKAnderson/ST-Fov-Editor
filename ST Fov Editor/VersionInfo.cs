using System.Collections.Generic;

namespace ST_Fov_Editor
{
    public struct PatchInfo
    {
        public string Filename;
        public int Size;
        public int Offset;
        public float Default;

        public PatchInfo(string filename, int size, int offset, float defaultVal)
        {
            Filename = filename;
            Size = size;
            Offset = offset;
            Default = defaultVal;
        }
    }

    class VersionInfo
    {
        public PatchInfo FovPatch;
        public PatchInfo HudFovPatch;
        public string Name;

        private VersionInfo(string name, PatchInfo fovPatch, PatchInfo hudFovPatch)
        {
            Name = name;
            FovPatch = fovPatch;
            HudFovPatch = hudFovPatch;
        }

        private static List<VersionInfo> versionInfo = new List<VersionInfo>();

        public static VersionInfo GetVersion(int index)
        {
            return versionInfo[index - 1];
        }

        public static List<string> GetNames()
        {
            List<string> names = new List<string>();
            foreach (VersionInfo version in versionInfo)
                names.Add(version.Name);
            return names;
        }

        static VersionInfo()
        {
            versionInfo.Add(new VersionInfo("Shadow of Chernobyl 1.0004 (RU, Retail, Cracked)",
                // 5832 KB
                new PatchInfo("xrGame.dll", 0x005B2000, 0x004F13C4, 67.5f),
                // 1536 KB
                new PatchInfo("XR_3DA.exe", 0x00180000, 0x000E4BA4, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Shadow of Chernobyl 1.0005 (RU, Retail, Cracked)",
                // 5852 KB
                new PatchInfo("xrGame.dll", 0x005B7000, 0x004F5504, 67.5f),
                // 1427 KB
                new PatchInfo("XR_3DA.exe", 0x00164C00, 0x000E4FA4, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Shadow of Chernobyl 1.0006 (EN, GOG)",
                // 6100 KB
                new PatchInfo("xrGame.dll", 0x005F5000, 0x0053C598, 67.5f),
                // 1599 KB
                new PatchInfo("XR_3DA.exe", 0x0018F848, 0x00106BA4, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Shadow of Chernobyl 1.0006 (EN, Steam)",
                // 6100 KB
                new PatchInfo("xrGame.dll", 0x005F5000, 0x0053C598, 67.5f),
                // 2176 KB
                new PatchInfo("XR_3DA.exe", 0x0021FD30, 0x00106BA4, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Shadow of Chernobyl 1.0006 (RU, Retail, Cracked)",
                // 6100 KB
                new PatchInfo("xrGame.dll", 0x005F5000, 0x0053C598, 67.5f),
                // 1597 KB
                new PatchInfo("XR_3DA.exe", 0x0018F2C0, 0x00106BA4, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Clear Sky 1.5.10 (EN, GOG)",
                // 6856 KB
                new PatchInfo("xrGame.dll", 0x006B2000, 0x005DC8F8, 67.5f),
                // 1103 KB
                new PatchInfo("xrEngine.exe", 0x00113848, 0x00094B98, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Clear Sky 1.5.10 (EN, Steam)",
                // 6861 KB
                new PatchInfo("xrGame.dll", 0x006B32C0, 0x005DC8F8, 67.5f),
                // 1680 KB
                new PatchInfo("xrEngine.exe", 0x001A3D30, 0x00094B98, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Clear Sky 1.5.10 (RU, Retail, Cracked)",
                // 6861 KB
                new PatchInfo("xrGame.dll", 0x006B32C0, 0x005DC8F8, 67.5f),
                // 1680 KB
                new PatchInfo("xrEngine.exe", 0x001132C0, 0x00094B98, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Call of Pripyat 1.6.02 (EN, GOG)",
                // 7089 KB
                new PatchInfo("xrGame.dll", 0x006EC2C0, 0x00635C44, 55.0f),
                // 1339 KB
                new PatchInfo("xrEngine.exe", 0x0014E848, 0x0090624, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Call of Pripyat 1.6.02 (EN, Steam)",
                // 7089 KB
                new PatchInfo("xrGame.dll", 0x006EC2C0, 0x00635C44, 55.0f),
                // 1916 KB
                new PatchInfo("xrEngine.exe", 0x001DED30, 0x0090624, 0.45f)
                ));

            versionInfo.Add(new VersionInfo("Call of Pripyat 1.6.02 (RU, Retail, Cracked)",
                // 7089 KB
                new PatchInfo("xrGame.dll", 0x006EC2C0, 0x00635C44, 55.0f),
                // 1033 KB
                new PatchInfo("xrEngine.exe", 0x0008EC24, 0x00102044, 0.45f)
                ));
        }
    }
}
