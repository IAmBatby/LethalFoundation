using System;
using System.Collections.Generic;
using System.Text;

namespace LethalFoundation
{
    public static class Tags
    {
        ////////// For Misc. Game/Engine Logic //////////

        public const string Untagged = nameof(Untagged);
        public const string Respawn = nameof(Respawn);
        public const string Finish = nameof(Finish);
        public const string EditorOnly = nameof(EditorOnly);
        public const string MainCamera = nameof(MainCamera);
        public const string GameController = nameof(GameController);
        public const string MapCamera = nameof(MapCamera);
        public const string DoNotSet = nameof(DoNotSet);
        public const string GameOverCameraHandle = nameof(GameOverCameraHandle);
        public const string Tiles = nameof(Tiles);
        public const string TemporaryEffect = nameof(TemporaryEffect);

        ////////// Player References //////////

        public const string Player = nameof(Player);

        public const string PlayerVoice = nameof(PlayerVoice);

        public const string PlayerBody = nameof(PlayerBody);
        public const string PlayerBody1 = nameof(PlayerBody1);
        public const string PlayerBody2 = nameof(PlayerBody2);
        public const string PlayerBody3 = nameof(PlayerBody3);

        public const string PlayerRagdoll = nameof(PlayerRagdoll);
        public const string PlayerRagdoll1 = nameof(PlayerRagdoll1);
        public const string PlayerRagdoll2 = nameof(PlayerRagdoll2);
        public const string PlayerRagdoll3 = nameof(PlayerRagdoll3);

        ////////// For Various Forms Of Content Identification //////////

        public const string PoweredObject = nameof(PoweredObject);
        public const string PlaceableObject = nameof(PlaceableObject);
        public const string AnomalySpawn = nameof(AnomalySpawn);
        public const string AnomalyObject = nameof(AnomalyObject);
        public const string MapProp = nameof(MapProp);
        public const string Puddle = nameof(Puddle);
        public const string OutsideMeshes = nameof(OutsideMeshes);
        public const string Enemy = nameof(Enemy);
        public const string PhysicsProp = nameof(PhysicsProp);
        public const string InteractTrigger = nameof(InteractTrigger);
        public const string Catwalk = nameof(Catwalk);
        public const string Bush = nameof(Bush);
        public const string PoweredLight = nameof(PoweredLight);
        public const string Battery = nameof(Battery);
        public const string BatteryPack = nameof(BatteryPack);
        public const string Snowman = nameof(Snowman);

        ////////// For Various Node/AI/Spawning Points //////////

        public const string AINode = nameof(AINode); //"InsideAINode"
        public const string OutsideAINode = nameof(OutsideAINode);
        public const string SpawnDenialPoint = nameof(SpawnDenialPoint);
        public const string CaveNode = nameof(CaveNode);
        public const string ScrapSpawn = nameof(ScrapSpawn);
        public const string EnemySpawn = nameof(EnemySpawn);

        ////////// Required Moon Scene References //////////
        public const string EntranceA = nameof(EntranceA);
        public const string OutsideLevelNavMesh = nameof(OutsideLevelNavMesh);
        public const string ItemShipLandingNode = nameof(ItemShipLandingNode);
        public const string MapPropsContainer = nameof(MapPropsContainer);
        public const string DungeonGenerator = nameof(DungeonGenerator);
        public const string PoweredLightsContainer = nameof(PoweredLightsContainer);

        ////////// For FootstepSurface Selection //////////

        public const string Wood = nameof(Wood);
        public const string Snow = nameof(Snow);
        public const string Grass = nameof(Grass);
        public const string Aluminum = nameof(Aluminum);
        public const string Gravel = nameof(Gravel);
        public const string Metal = nameof(Metal);
        public const string Concrete = nameof(Concrete);
        public const string Carpet = nameof(Carpet);
        public const string Rock = nameof(Rock);

        ////////// Terminal Radar / MapCamera Object Identification //////////

        public const string RadarRoomSprite = nameof(RadarRoomSprite);
        public const string RadarCodeUIObject = nameof(RadarCodeUIObject);
        public const string TerrainContourMap = nameof(TerrainContourMap);

        ////////// For Currently Unused Vain Shroud Mechanic //////////
        public const string MoldAttractionPoint = nameof(MoldAttractionPoint);
        public const string MoldSpore = nameof(MoldSpore);
        public const string MoldSporeCollider = nameof(MoldSporeCollider);
    }
}
