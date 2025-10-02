using System.Collections.Generic;
using System.ComponentModel;
using BepInEx.Configuration;
using Reptile;
using UnityEngine;

namespace Plugin;

// general config setup i may have stolen from movementplus eheheehhehe
public class Config(ConfigFile config) {
    public GeneralSection general = new(config, "General");


    public class GeneralSection(ConfigFile config, string category) {
        public ConfigEntry<bool> InfBoost { get; } = config.Bind(
            category,
            "Infinite Boost",
            false,
            "Enables infinite boost (template code)"
        );

        public ConfigEntry<bool> MoveStyleOnStairs { get; } = config.Bind(
            category,
            "Movestyles on stairs",
            false,
            "Enables movestyles on stairs (template code)"
        );
    }
}
