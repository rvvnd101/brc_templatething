using BepInEx;
using HarmonyLib;
using Reptile;
using UnityEngine;

namespace Plugin;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
[BepInProcess("Bomb Rush Cyberfunk.exe")]
public class Plugin : BaseUnityPlugin {
    public static Harmony harmony { get; private set; } = null!;
    public static Config CFG { get; private set; } = null!;

    private void Awake() {  
        CFG = new Config(this.Config);

        harmony = new Harmony(PluginInfo.PLUGIN_GUID);
        harmony.PatchAll();

        this.Logger.LogInfo($"v{PluginInfo.PLUGIN_VERSION} loaded :3");
    }
    
}
