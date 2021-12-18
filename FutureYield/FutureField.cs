using Astrum.AstralCore;
using Astrum.AstralCore.UI.Attributes;
using MelonLoader;

[assembly: MelonInfo(typeof(FutureYield.FutureYield), nameof(FutureYield.FutureYield), "0.2.0", downloadLink: "github.com/xMiraiChan/FutureYield")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace FutureYield
{
    public class FutureYield : MelonMod
    {
        [UIButton("FutureYield", "ServerHop")]
        public static void ServerHop()
        {
            Il2CppSystem.Collections.Generic.List<VRC.Core.ApiWorldInstance> instances = 
                RoomManager.field_Internal_Static_ApiWorld_0.GetViableInstances(VRC.Core.APIUser.CurrentUser.id, includePublicInstancesOnly: true)
                    .Cast<Il2CppSystem.Collections.Generic.List<VRC.Core.ApiWorldInstance>>();
            if (instances.Count == 0)
                Logger.Notif("There are no viable instances to hop to");
            VRC.SDKBase.Networking.GoToRoom(instances[UnityEngine.Random.Range(0, instances.Count - 1)].id);
        }

        private static bool loudMic = false;
        [UIProperty<bool>("FutureYield", "LoudMic")]
        public static bool LoudMic
        {
            get => loudMic;
            set => USpeaker.field_Internal_Static_Single_1 = (loudMic = value) ? float.MaxValue : 1;
        }
    }
}
