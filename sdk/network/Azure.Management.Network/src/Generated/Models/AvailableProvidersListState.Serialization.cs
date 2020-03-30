// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AvailableProvidersListState
    {
        internal static AvailableProvidersListState DeserializeAvailableProvidersListState(JsonElement element)
        {
            string stateName = default;
            IReadOnlyList<string> providers = default;
            IReadOnlyList<AvailableProvidersListCity> cities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stateName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    providers = array;
                    continue;
                }
                if (property.NameEquals("cities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableProvidersListCity> array = new List<AvailableProvidersListCity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableProvidersListCity.DeserializeAvailableProvidersListCity(item));
                    }
                    cities = array;
                    continue;
                }
            }
            return new AvailableProvidersListState(stateName, providers, cities);
        }
    }
}
