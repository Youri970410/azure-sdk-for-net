// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class NetworkConfigurationDiagnosticResult
    {
        internal static NetworkConfigurationDiagnosticResult DeserializeNetworkConfigurationDiagnosticResult(JsonElement element)
        {
            TrafficQuery trafficQuery = default;
            NetworkSecurityGroupResult networkSecurityGroupResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trafficQuery"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficQuery = TrafficQuery.DeserializeTrafficQuery(property.Value);
                    continue;
                }
                if (property.NameEquals("networkSecurityGroupResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkSecurityGroupResult = NetworkSecurityGroupResult.DeserializeNetworkSecurityGroupResult(property.Value);
                    continue;
                }
            }
            return new NetworkConfigurationDiagnosticResult(trafficQuery, networkSecurityGroupResult);
        }
    }
}
