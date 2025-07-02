using System;
using System.Collections.Generic;
using System.Text;
using Unity.Netcode;

namespace LethalFoundation
{
    public struct NetworkValueWithRarity<T> : INetworkWithRarity<T>, INetworkSerializable where T : struct, INetworkSerializable
    {
        public T Value { get; }
        public int Rarity => _rarity;
        private int _rarity;

        public NetworkValueWithRarity(T value, int rarity)
        {
            Value = value;
            _rarity = rarity;
        }

        public void NetworkSerialize<T1>(BufferSerializer<T1> serializer) where T1 : IReaderWriter
        {
            serializer.SerializeValue(ref _rarity);
            Value.NetworkSerialize(serializer);
        }
    }
}
