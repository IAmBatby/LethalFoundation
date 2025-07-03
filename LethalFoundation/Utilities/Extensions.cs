using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LethalFoundation
{
    public static class Extensions
    {

        public static CompatibleNoun GetFirstPair(this CompatibleNoun[] nouns) => nouns != null && nouns.Length > 0 ? nouns[0] : null;

        public static CompatibleNoun[] GetNouns(this TerminalKeyword keyword) => keyword.compatibleNouns;
        public static CompatibleNoun[] GetNouns(this TerminalNode node) => node.terminalOptions;
        public static CompatibleNoun GetNounAt(this TerminalKeyword keyword, int index) => keyword.compatibleNouns[index];
        public static CompatibleNoun GetNounAt(this TerminalNode node, int index) => node.terminalOptions[index];

        public static int GetClientId(this PlayerControllerB player) => (int)player.playerClientId;

        public static int GetRandomWeightedIndex(this RoundManager rM, IEnumerable<int> weights, System.Random randomSeed = null)
        {
            return rM.GetRandomWeightedIndex(weights.ToArray(), randomSeed);
        }

        public static bool IsBuyableItem(this Item item) => Refs.BuyableItemsList.Contains(item);

        public static NetworkString ToNetworked(this string input) => new NetworkString(input);

        public static T[] Add<T>(this T[] array, T value)
        {
            return (array.AddItem(value).ToArray());
        }

        public static bool IsACompanyMoon(this SelectableLevel level)
        {
            return (level != null && level.planetHasTime && !level.spawnEnemiesAndScrap && level.dungeonFlowTypes.Length == 0);
        }

    }
}
