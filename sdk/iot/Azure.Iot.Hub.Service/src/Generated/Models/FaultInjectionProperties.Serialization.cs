// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    internal partial class FaultInjectionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IotHubName))
            {
                writer.WritePropertyName("IotHubName");
                writer.WriteStringValue(IotHubName);
            }
            if (Optional.IsDefined(Connection))
            {
                writer.WritePropertyName("connection");
                writer.WriteObjectValue(Connection);
            }
            if (Optional.IsDefined(LastUpdatedTimeUtc))
            {
                writer.WritePropertyName("lastUpdatedTimeUtc");
                writer.WriteStringValue(LastUpdatedTimeUtc.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static FaultInjectionProperties DeserializeFaultInjectionProperties(JsonElement element)
        {
            Optional<string> iotHubName = default;
            Optional<FaultInjectionConnectionProperties> connection = default;
            Optional<DateTimeOffset> lastUpdatedTimeUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("IotHubName"))
                {
                    iotHubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connection"))
                {
                    connection = FaultInjectionConnectionProperties.DeserializeFaultInjectionConnectionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdatedTimeUtc"))
                {
                    lastUpdatedTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new FaultInjectionProperties(iotHubName.Value, connection.Value, Optional.ToNullable(lastUpdatedTimeUtc));
        }
    }
}
