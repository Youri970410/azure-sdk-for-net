// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayBackendHealthPool
    {
        internal static ApplicationGatewayBackendHealthPool DeserializeApplicationGatewayBackendHealthPool(JsonElement element)
        {
            ApplicationGatewayBackendAddressPool backendAddressPool = default;
            IReadOnlyList<ApplicationGatewayBackendHealthHttpSettings> backendHttpSettingsCollection = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendAddressPool"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendAddressPool = ApplicationGatewayBackendAddressPool.DeserializeApplicationGatewayBackendAddressPool(property.Value);
                    continue;
                }
                if (property.NameEquals("backendHttpSettingsCollection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayBackendHealthHttpSettings> array = new List<ApplicationGatewayBackendHealthHttpSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationGatewayBackendHealthHttpSettings.DeserializeApplicationGatewayBackendHealthHttpSettings(item));
                    }
                    backendHttpSettingsCollection = array;
                    continue;
                }
            }
            return new ApplicationGatewayBackendHealthPool(backendAddressPool, backendHttpSettingsCollection);
        }
    }
}
