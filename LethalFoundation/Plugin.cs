using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace LethalFoundation
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string ModGUID = "iambatby.lethalfoundation";
        public const string ModName = "LethalFoundation";
        public const string ModVersion = "1.0.0";

        public static Plugin Instance;
        internal static readonly Harmony Harmony = new Harmony(ModGUID);
        internal static ManualLogSource logger;

        private void Awake()
        {
            logger = Logger;
        }

        internal static void Log(string message)
        {
            logger.LogInfo(message);
        }
    }
}