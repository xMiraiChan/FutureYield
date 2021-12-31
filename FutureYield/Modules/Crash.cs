using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureYield.Modules
{
    public static class Crash
    {
        private static bool state = false;
        [UIProperty<bool>("FutureYield", "Crash")]
        public static bool State
        {
            get => state;
            set
            {
                if (state == value) return;
                state = value;
                if (value)
                {
                    AssetBundleDownloadManager.prop_AssetBundleDownloadManager_0.enabled = false;
                    SDK.OnLocalLoad += OnLocalLoad;
                }
                else
                {
                    SDK.OnLocalLoad -= OnLocalLoad;
                    AssetBundleDownloadManager.field_Private_Static_AssetBundleDownloadManager_0.field_Private_Queue_1_AssetBundleDownload_0.Clear();
                    AssetBundleDownloadManager.prop_AssetBundleDownloadManager_0.enabled = true;
                }
            }
        }

        [UIButton("FutureYield", "Crash.Fix")]
        public static void Fix() => AssetBundleDownloadManager.prop_AssetBundleDownloadManager_0.enabled = true;

        private static void OnLocalLoad(VRCPlayerApi _) => AssetBundleDownloadManager.prop_AssetBundleDownloadManager_0.enabled = false;
    }
}
