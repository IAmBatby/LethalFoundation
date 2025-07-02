using System;
using System.Collections.Generic;
using System.Text;
using Unity.Netcode;

namespace LethalFoundation
{
    public interface INetworkWithRarity<T> where T : struct, INetworkSerializable
    {
        public T Value { get; }
        public int Rarity { get; }


    }
}
