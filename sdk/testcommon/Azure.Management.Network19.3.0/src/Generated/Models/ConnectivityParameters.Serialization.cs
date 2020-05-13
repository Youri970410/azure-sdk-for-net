// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectivityParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("source");
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("destination");
            writer.WriteObjectValue(Destination);
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (ProtocolConfiguration != null)
            {
                writer.WritePropertyName("protocolConfiguration");
                writer.WriteObjectValue(ProtocolConfiguration);
            }
            writer.WriteEndObject();
        }
    }
}
