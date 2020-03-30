// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectionMonitorTcpConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Port != null)
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (DisableTraceRoute != null)
            {
                writer.WritePropertyName("disableTraceRoute");
                writer.WriteBooleanValue(DisableTraceRoute.Value);
            }
            writer.WriteEndObject();
        }
    }
}
