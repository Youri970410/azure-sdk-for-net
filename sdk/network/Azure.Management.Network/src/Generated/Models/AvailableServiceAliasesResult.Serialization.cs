// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AvailableServiceAliasesResult
    {
        internal static AvailableServiceAliasesResult DeserializeAvailableServiceAliasesResult(JsonElement element)
        {
            IReadOnlyList<AvailableServiceAlias> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailableServiceAlias> array = new List<AvailableServiceAlias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableServiceAlias.DeserializeAvailableServiceAlias(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AvailableServiceAliasesResult(value, nextLink);
        }
    }
}
