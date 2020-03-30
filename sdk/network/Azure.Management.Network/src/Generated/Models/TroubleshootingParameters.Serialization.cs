// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class TroubleshootingParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId");
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("storageId");
            writer.WriteStringValue(StorageId);
            writer.WritePropertyName("storagePath");
            writer.WriteStringValue(StoragePath);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
