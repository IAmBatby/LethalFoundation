using System;
using System.Collections.Generic;
using System.Text;
using Unity.Netcode;

namespace LethalFoundation
{
    public struct NetworkString : INetworkSerializable
    {
        public string StringValue;

        public NetworkString(string newString = null)
        {
            StringValue = string.IsNullOrEmpty(newString) ? string.Empty : newString;
        }

        public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
        {
            if (serializer.IsWriter)
                serializer.GetFastBufferWriter().WriteValueSafe(StringValue);
            else
                serializer.GetFastBufferReader().ReadValueSafe(out StringValue);
        }
    }
}
