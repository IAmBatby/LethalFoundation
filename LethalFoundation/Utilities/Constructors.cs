using DunGen.Graph;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using Unity.Netcode;
using UnityEngine;

namespace LethalFoundation
{
    public static class Constructors
    {
        private static GameObject _hideAndDontSaveParent;
        private static GameObject HideAndDontSave
        {
            get
            {
                if (_hideAndDontSaveParent == null)
                {
                    _hideAndDontSaveParent = new GameObject("LethalFoundation_HideAndDontSaveParent");
                    _hideAndDontSaveParent.hideFlags = HideFlags.HideAndDontSave;
                    _hideAndDontSaveParent.SetActive(false);
                }
                return (_hideAndDontSaveParent);
            }
        }

        public static IntWithRarity Create(int id, int rarity)
        {
            IntWithRarity returnR = new IntWithRarity();
            returnR.id = id;
            returnR.rarity = rarity;
            return (returnR);
        }

        public static IndoorMapType Create(DungeonFlow dungeonFlow, float mapTileSize, AudioClip firstTimeAudio)
        {
            IndoorMapType returnR = new IndoorMapType();
            returnR.dungeonFlow = dungeonFlow;
            returnR.MapTileSize = mapTileSize;
            returnR.firstTimeAudio = firstTimeAudio;
            return (returnR);
        }

        public static SpawnableEnemyWithRarity Create(EnemyType enemy, int rarity)
        {
            SpawnableEnemyWithRarity returnR = new SpawnableEnemyWithRarity();
            returnR.enemyType = enemy;
            returnR.rarity = rarity;
            return (returnR);
        }

        public static CompatibleNoun Create(TerminalKeyword noun, TerminalNode result)
        {
            CompatibleNoun returnR = new CompatibleNoun();
            returnR.result = result;
            returnR.noun = noun;
            return (returnR);
        }

        public static TerminalKeyword CreateKeyword(bool registerNewKeyword, string name = null, string word = null, TerminalKeyword defaultVerb = null)
        {
            TerminalKeyword newTerminalKeyword = ScriptableObject.CreateInstance<TerminalKeyword>();
            newTerminalKeyword.name = string.IsNullOrEmpty(name) ? "NewFoundationKeyword" : name;
            newTerminalKeyword.compatibleNouns = new CompatibleNoun[0];
            newTerminalKeyword.word = word == null ? null : word;
            newTerminalKeyword.defaultVerb = defaultVerb;
            if (registerNewKeyword)
                Utilities.Insert(ref Refs.Terminal.terminalNodes.allKeywords, newTerminalKeyword);
            return (newTerminalKeyword);
        }

        public static TerminalNode CreateNode(string name = null, string displayText = null)
        {
            TerminalNode newTerminalNode = ScriptableObject.CreateInstance<TerminalNode>();
            newTerminalNode.name = string.IsNullOrEmpty(name) ? "NewLethalFoundationNode" : name;

            newTerminalNode.displayText = string.IsNullOrEmpty(displayText) ? string.Empty : displayText;
            newTerminalNode.terminalEvent = string.Empty;
            newTerminalNode.maxCharactersToType = 25;
            newTerminalNode.buyItemIndex = -1;
            newTerminalNode.buyRerouteToMoon = -1;
            newTerminalNode.displayPlanetInfo = -1;
            newTerminalNode.shipUnlockableID = -1;
            newTerminalNode.creatureFileID = -1;
            newTerminalNode.storyLogFileID = -1;
            newTerminalNode.playSyncedClip = -1;
            newTerminalNode.terminalOptions = new CompatibleNoun[0];

            return (newTerminalNode);
        }

        public static GameObject CreatePrefab(string prefabName)
        {
            GameObject newPrefab = new GameObject(prefabName);
            newPrefab.hideFlags = HideFlags.HideAndDontSave;
            newPrefab.transform.SetParent(HideAndDontSave.transform);
            return (newPrefab);
        }

        public static NetworkObject CreateNetworkPrefab(string prefabName, byte[] hash = null)
        {
            GameObject newPrefab = CreatePrefab(prefabName);
            NetworkObject newNetworkObject = newPrefab.AddComponent<NetworkObject>();
            newNetworkObject.GlobalObjectIdHash = BitConverter.ToUInt32(hash != null ? hash : GetDefaultHash(prefabName), 0);
            return (newNetworkObject);
        }

        private static byte[] GetDefaultHash(string prefabName)
        {
            return (MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Assembly.GetCallingAssembly().GetName().Name + prefabName)));
        }
    }
}
