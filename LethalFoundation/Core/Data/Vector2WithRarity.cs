using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LethalFoundation
{
    [Serializable]
    public class Vector2WithRarity
    {
        [SerializeField] private Vector2 _minMax;
        [SerializeField] private int _rarity;

        [HideInInspector] public float Min { get { return (_minMax.x); } set { _minMax.x = value; } }
        [HideInInspector] public float Max { get { return (_minMax.y); } set { _minMax.y = value; } }
        [HideInInspector] public int Rarity { get { return (_rarity); } set { _rarity = value; } }

        public Vector2WithRarity(Vector2 vector2, int newRarity) { _minMax.x = vector2.x; _minMax.y = vector2.y; _rarity = newRarity; }
        public Vector2WithRarity(float newMin, float newMax, int newRarity) { _minMax.x = newMin; _minMax.y = newMax; _rarity = newRarity; }
    }
}
