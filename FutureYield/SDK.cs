using MelonLoader;
using System;
using UnityEngine;

namespace FutureYield
{
    public static class SDK
    {
        public static event Action<int, string> OnSceneWasLoaded = new((_,__) => { });
        public static event Action<VRCPlayerApi> OnLocalLoad = new(_ => { });

        public static void Init() => OnSceneWasLoaded += (index, sceneName) => MelonCoroutines.Start(FindLocalPlayer(index, sceneName));

        internal static System.Collections.IEnumerator FindLocalPlayer(int index, string sceneName)
        {
            if (index != -1) yield break;

            VRCPlayerApi player;
            while ((player = Networking.LocalPlayer) is null)
                yield return null;

            OnLocalLoad(player);
        }
    }
}
