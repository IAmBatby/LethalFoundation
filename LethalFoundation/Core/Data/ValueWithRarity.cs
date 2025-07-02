using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace LethalFoundation
{
    [System.Serializable]
    public struct ValueWithRarity<T>
    {
        [field: SerializeField] public T Value { get; private set; }
        [field: SerializeField] public int Rarity { get; private set; }

        public ValueWithRarity(T newVal, int newRar)
        {
            Value = newVal;
            Rarity = newRar;
        }
    }
}
