using DunGen.Graph;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LethalFoundation
{
    public static class Constructors
    {

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
    }
}
