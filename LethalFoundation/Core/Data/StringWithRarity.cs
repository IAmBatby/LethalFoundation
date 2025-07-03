using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LethalFoundation
{
    [Serializable]
    public class StringWithRarity
    {
        [SerializeField] private string _name;
        [SerializeField, Range(0, 300)] private int _rarity;

        [HideInInspector] public string Name { get { return (_name); } set { _name = value; } }
        [HideInInspector] public int Rarity { get { return (_rarity); } set { _rarity = value; } }

        [HideInInspector] public StringWithRarity(string newName, int newRarity) { _name = newName; _rarity = newRarity; }
    }
}
