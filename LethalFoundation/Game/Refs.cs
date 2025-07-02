using DunGen;
using DunGen.Graph;
using GameNetcodeStuff;
using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using Unity.AI.Navigation;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LethalFoundation
{
    public static class Refs
    {
        ////////// Singletons //////////

        private static StartOfRound _startOfRound;
        public static StartOfRound StartOfRound => Utilities.TrySeekObject(ref _startOfRound, StartOfRound.Instance);

        private static RoundManager _roundManager;
        public static RoundManager RoundManager => Utilities.TrySeekObject(ref _roundManager, RoundManager.Instance);

        private static Terminal _terminal;
        public static Terminal Terminal => Utilities.TrySeekObject(ref _terminal);

        private static TimeOfDay _timeOfDay;
        public static TimeOfDay TimeOfDay => Utilities.TrySeekObject(ref _timeOfDay, TimeOfDay.Instance);

        private static QuickMenuManager _quickMenuManager;
        public static QuickMenuManager QuickMenuManager => Utilities.TrySeekObject(ref _quickMenuManager);

        private static HUDManager _hudManager;
        public static HUDManager HUDManager => Utilities.TrySeekObject<HUDManager>(ref _hudManager, HUDManager.Instance);

        private static NetworkManager _networkManager;
        public static NetworkManager NetworkManager => Utilities.TrySeekObject(ref _networkManager, NetworkManager.Singleton);

        private static GameNetworkManager _gameNetworkManager;
        public static GameNetworkManager GameNetworkManager => Utilities.TrySeekObject(ref _gameNetworkManager, GameNetworkManager.Instance);

        private static NetworkPrefabsList _networkPrefabsList;
        public static NetworkPrefabsList NetworkPrefabsList => Utilities.TrySeekResource(ref _networkPrefabsList);

        private static NavMeshSurface _navMeshSurface;
        public static NavMeshSurface NavMeshSurface => Utilities.TrySeekObject(ref _navMeshSurface);

        public static IReadOnlyList<NetworkPrefab> NetworkPrefabs => NetworkManager?.NetworkConfig?.Prefabs?.Prefabs;

        ////////// "Game" / More-Engine Based //////////

        public static Camera ActiveCamera => StartOfRound?.activeCamera;

        public static PlayerControllerB LocalPlayer => GameNetworkManager?.localPlayerController;
        public static PlayerControllerB[] AllPlayers => StartOfRound?.allPlayerScripts;

        public static bool IsChallengeFile => StartOfRound.isChallengeFile;

        ////////// General Content //////////

        public static int RandomMapSeed => StartOfRound.randomMapSeed;

        public static AllItemsList AllItemsList => StartOfRound?.allItemsList;
        public static List<Item> ItemsList { get => AllItemsList?.itemsList; set => AllItemsList.itemsList = value; }

        public static UnlockablesList UnlockablesList => StartOfRound?.unlockablesList;
        public static List<UnlockableItem> Unlockables { get => UnlockablesList?.unlockables; set => UnlockablesList.unlockables = value; }

        public static Item[] BuyableItemsList { get => Terminal.buyableItemsList; set => Terminal.buyableItemsList = value; }

        public static SelectableLevel[] Levels { get => StartOfRound?.levels; set => StartOfRound.levels = value; }
        public static IndoorMapType[] DungeonFlowTypes { get => RoundManager?.dungeonFlowTypes; set => RoundManager.dungeonFlowTypes = value; }
        public static AudioClip[] FirstTimeDungeonAudios { get => RoundManager?.firstTimeDungeonAudios; set => RoundManager.firstTimeDungeonAudios = value; }

        public static GameObject KeyPrefab => RoundManager?.keyPrefab;
        public static GameObject QuicksandPrefab => RoundManager?.quicksandPrefab;

        public static int TimesFulfilledQuota => TimeOfDay.timesFulfilledQuota;
        
        public static LevelWeatherType CurrentWeather => CurrentLevel.currentWeather;

        ////////// Terminal //////////

        public static TerminalNodesList TerminalNodesList => Terminal?.terminalNodes;
        public static TerminalKeyword[] AllKeywords => TerminalNodesList?.allKeywords;

        public static KeywordReferences Keywords { get; private set; } = new KeywordReferences();
        public static NodeReferences Nodes { get; private set; } = new NodeReferences();

        public static TMP_Text TerminalText => Terminal?.screenText?.textComponent;

        ////////// Ship //////////

        private static StartMatchLever _startMatchLever;
        public static StartMatchLever StartMatchLever => Utilities.TrySeekObject(ref _startMatchLever);

        private static ShipLights _shipLights;
        public static ShipLights ShipLights => Utilities.TrySeekObject(ref _shipLights);

        private static HangarShipDoor _hangarShipDoor;
        public static HangarShipDoor HangerShipDoor => Utilities.TrySeekObject(ref _hangarShipDoor);

        public static ManualCameraRenderer MapScreen => StartOfRound.mapScreen;

        public static Transform[] InsideShipPositions => StartOfRound?.insideShipPositions;
        public static Transform ShipNode => StartOfRound?.middleOfShipNode;
        public static Collider ShipBounds => StartOfRound?.shipBounds;
        public static Vector3 ShipNodePos => ShipNode.transform.position;
        public static Vector3 ShipForward => ShipBounds.transform.forward;
        public static Vector3 ShipRight => ShipBounds.transform.right;

        public static bool IsShipLeaving => StartOfRound.shipIsLeaving;
        public static bool IsInShipPhase => StartOfRound.inShipPhase;
        public static bool HasShipLanded => StartOfRound.shipHasLanded;

        ////////// Round / Day / Level //////////

        public static SelectableLevel CurrentLevel => StartOfRound?.currentLevel;
        public static List<SpawnableItemWithRarity> CurrentSpawnableScraps => CurrentLevel?.spawnableScrap;
        public static SpawnableMapObject[] CurrentSpawnableMapObjects { get => CurrentLevel?.spawnableMapObjects; set => CurrentLevel.spawnableMapObjects = value; }


        public static Scene LoadedLevelScene => SunAnimator != null ? SunAnimator.gameObject.scene : default; //Weird but avoids checking SelectableLevel string incase another mod like LLL overrides it
        public static bool IsCurrentLevelLoaded => SunAnimator != null;

        public static GameObject[] LevelRootObjects => IsCurrentLevelLoaded ? LoadedLevelScene.GetRootGameObjects() : [];

        public static Animator SunAnimator => TimeOfDay?.sunAnimator;

        public static Transform MapPropsContainer => RoundManager?.mapPropsContainer?.transform;
        public static Transform PropsContainer => StartOfRound?.propsContainer;
        public static Transform SpawnedScrapContainer => RoundManager?.spawnedScrapContainer;
        public static Transform VehiclesContainer => RoundManager?.VehiclesContainer;

        public static RuntimeDungeon RuntimeDungeon => RoundManager?.dungeonGenerator;
        public static DungeonGenerator DungeonGenerator => RuntimeDungeon?.Generator;
        public static DungeonFlow CurrentDungeonFlow => DungeonGenerator?.DungeonFlow;

        public static SpawnableMapObject[] SpawnableMapObjects => RoundManager?.spawnableMapObjects;
        public static List<GameObject> SpawnedSyncedObjects => RoundManager?.spawnedSyncedObjects;

        public static EnemyVent[] AllEnemyVents => RoundManager?.allEnemyVents;
        public static List<Light> AllPowereredLights => RoundManager?.allPoweredLights;
        public static List<EnemyAINestSpawnObject> AllEnemyNestSpawnObjects => RoundManager?.enemyNestSpawnObjects;

        public static GameObject[] OutsideAINodes => RoundManager?.outsideAINodes;
        public static GameObject[] InsideAINodes => RoundManager?.insideAINodes;

        public static List<EnemyAI> SpawnedEnemies => RoundManager?.SpawnedEnemies;

        private static GameObject _itemShipLandingNode;
        public static GameObject ItemShipLandingNode
        {
            get
            {
                if (_itemShipLandingNode == null)
                    _itemShipLandingNode = GameObject.FindGameObjectWithTag("ItemShipLandingNode");
                return _itemShipLandingNode;
            }
        }

        //All have Colliders & Room
        public static int Layer_Primary => StartOfRound.collidersAndRoomMask;
        public static int Layer_WithDefault => StartOfRound.collidersAndRoomMaskAndDefault;
        public static int Layer_WithPlayers => StartOfRound.collidersAndRoomMaskAndPlayers;
        public static int Layer_WithDefaultAndFoliage => StartOfRound.collidersRoomDefaultAndFoliage;
        public static int Layer_WithDefaultAndPlayers => StartOfRound.collidersRoomMaskDefaultAndPlayers;
    }
}
