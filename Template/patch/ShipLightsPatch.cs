using HarmonyLib;

namespace YourThunderstoreTeam.patch;

/// <summary>
/// Patch to modify the behavior of the ship lights.
/// </summary>
[HarmonyPatch(typeof(ShipLights))]
public class ShipLightsPatch
{
    /// <summary>
    /// Method called when the ship lights are toggled.
    ///
    /// Check the link below for more information about Harmony patches.
    /// Class patches: https://github.com/BepInEx/HarmonyX/wiki/Class-patches
    /// Patch parameters: https://github.com/BepInEx/HarmonyX/wiki/Patch-parameters
    /// </summary>
    /// <param name="__instance">Instance that called the method.</param>
    /// <param name="__args">Arguments passed to the method.</param>
    /// <returns>True if the original method should be called, false otherwise.</returns>
    [HarmonyPatch(nameof(ShipLights.ToggleShipLights))]
    [HarmonyPrefix]
    private static bool OnPowerSwitch(ref ShipLights __instance, object[] __args)
    {
        Plugin.Log.LogInfo("The lights are now toggled!");
        // When someone toggles the ship lights, the lights will not be changed.
        return false;
    }
}
