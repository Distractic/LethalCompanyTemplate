using HarmonyLib;

namespace YourThunderstoreTeam.patch;

[HarmonyPatch(typeof(ShipLights))]
public class ShipLightsPatch
{
    [HarmonyPatch(nameof(ShipLights.ToggleShipLights))]
    [HarmonyPrefix]
    private static bool OnPowerSwitch(ref ShipLights __instance, object[] __args)
    {
        Plugin.Log.LogInfo("The lights are now toggled!");
        return false;
    }
}
