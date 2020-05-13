// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class DedicatedHostAllocatableVM : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (VmSize != null)
            {
                writer.WritePropertyName("vmSize");
                writer.WriteStringValue(VmSize);
            }
            if (Count != null)
            {
                writer.WritePropertyName("count");
                writer.WriteNumberValue(Count.Value);
            }
            writer.WriteEndObject();
        }

        internal static DedicatedHostAllocatableVM DeserializeDedicatedHostAllocatableVM(JsonElement element)
        {
            string vmSize = default;
            double? count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetDouble();
                    continue;
                }
            }
            return new DedicatedHostAllocatableVM(vmSize, count);
        }
    }
}
