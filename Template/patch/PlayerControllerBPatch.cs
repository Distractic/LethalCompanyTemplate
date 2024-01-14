using GameNetcodeStuff;
using HarmonyLib;

namespace LethalCompanyTemplate.patch;

/// <summary>
/// Patch to apply the effect when the game is loaded and unloaded.
/// </summary>
[HarmonyPatch(typeof(PlayerControllerB))]
public class PlayerControllerBPatch
{

    [HarmonyPatch("PlayerJump")]
    [HarmonyPrefix]
    private static bool OnPlayerJump(ref PlayerControllerB __instance)
    {
        HUDManager.Instance.AddTextToChatOnServer("isJumping: " + __instance.isJumping);
        __instance.isJumping = false;
        return false;
    }
    
}
