using GameNetcodeStuff;
using HarmonyLib;

namespace YourThunderstoreTeam.patch;

/// <summary>
/// Patch to modify the behavior of a player.
/// </summary>
[HarmonyPatch(typeof(PlayerControllerB))]
public class PlayerControllerBPatch
{
    /// <summary>
    /// Method called when the player jumps.
    ///
    /// Check the link below for more information about Harmony patches.
    /// Class patches: https://github.com/BepInEx/HarmonyX/wiki/Class-patches
    /// Patch parameters: https://github.com/BepInEx/HarmonyX/wiki/Patch-parameters
    /// </summary>
    /// <param name="__instance">Instance that called the method.</param>
    /// <returns>True if the original method should be called, false otherwise.</returns>
    [HarmonyPatch("PlayerJump")]
    [HarmonyPrefix]
    private static bool OnPlayerJump(ref PlayerControllerB __instance)
    {
        HUDManager.Instance.AddTextToChatOnServer("isJumping: " + __instance.isJumping);
        // When a player jumps, set isJumping to false to prevent the player from jumping.
        __instance.isJumping = false;
        return false;
    }
    
}
