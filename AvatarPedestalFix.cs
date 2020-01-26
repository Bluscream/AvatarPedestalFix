using System;
using VRCModLoader;

namespace AvatarPedestalFix
{
    public static class ModInfo
    {
        public const string Name = "AvatarPedestalFix";
        public const string Author = "Herp Derpinstine";
        public const string Company = "NanoNuke @ nanonuke.net";
        public const string Version = "1.0.0";
    }
    [VRCModInfo(ModInfo.Name, ModInfo.Version, ModInfo.Author)]

    public class AvatarPedestalFix : VRCMod
    {
        void OnApplicationStart()
        {
            VRCSDK2.RPC rpc1 = (VRCSDK2.RPC)Attribute.GetCustomAttributes(typeof(AvatarPedestal).GetMethod("SetAvatarUse"))[0];
            rpc1.allowedTargets[0] = VRCSDK2.VRC_EventHandler.VrcTargetType.Local;
            VRCSDK2.RPC rpc2 = (VRCSDK2.RPC)Attribute.GetCustomAttributes(typeof(VRCSDK2.VRC_AvatarPedestal).GetMethod("SetAvatarUse"))[0];
            rpc2.allowedTargets[0] = VRCSDK2.VRC_EventHandler.VrcTargetType.Local;
        }
    }
}
