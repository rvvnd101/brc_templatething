using HarmonyLib;
using Reptile;


namespace Plugin.Patches;

// example patch
[HarmonyPatch(typeof(Player))]
internal static class PlayerPatch {
    private static readonly Config ConfigSettings = Plugin.CFG;

    [HarmonyPatch(nameof(Player.FixedUpdatePlayer))]
    [HarmonyPostfix]
    private static void FixedUpdatePlayer_Postfix(Player __instance) {
        if (ConfigSettings.general.InfBoost.Value) {
            if (__instance.boostCharge != __instance.maxBoostCharge) {
                __instance.AddBoostCharge(1f); // essentially infinite boost except not really, yes i basically stole this from that infinite boost plugin and i'm not really that ashamed of it, srry i'll replace the example code with something better soon enough
            }
        }
    }

    [HarmonyPatch(nameof(Player.OnTriggerStay))]
    [HarmonyPostfix]
    private static void OnTriggerStay_Postfix(Player __instance)
    {
        if (!ConfigSettings.general.MoveStyleOnStairs.Value) return; // maybe find a shorthand for these longass value checks other than creating a temp var, future problems though
        if (!__instance.isAI) {
            __instance.inWalkZone = false;
        }
    }
}
