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

        public static void Add<T>(this T[] a, ref T[] array, T value)
        {
            array = array.AddItem(value).ToArray();
        }

        public static T[] Add<T>(this T[] a, T value) => Utilities.Add(a,value);

        public static NetworkString ToNetworked(this string input) => new NetworkString(input);

    }
}
