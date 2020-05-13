// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class TrafficAnalyticsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("networkWatcherFlowAnalyticsConfiguration");
            writer.WriteObjectValue(NetworkWatcherFlowAnalyticsConfiguration);
            writer.WriteEndObject();
        }

        internal static TrafficAnalyticsProperties DeserializeTrafficAnalyticsProperties(JsonElement element)
        {
            TrafficAnalyticsConfigurationProperties networkWatcherFlowAnalyticsConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkWatcherFlowAnalyticsConfiguration"))
                {
                    networkWatcherFlowAnalyticsConfiguration = TrafficAnalyticsConfigurationProperties.DeserializeTrafficAnalyticsConfigurationProperties(property.Value);
                    continue;
                }
            }
            return new TrafficAnalyticsProperties(networkWatcherFlowAnalyticsConfiguration);
        }
    }
}
