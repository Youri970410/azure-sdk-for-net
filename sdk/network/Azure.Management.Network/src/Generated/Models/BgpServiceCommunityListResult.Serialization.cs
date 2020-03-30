// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class BgpServiceCommunityListResult
    {
        internal static BgpServiceCommunityListResult DeserializeBgpServiceCommunityListResult(JsonElement element)
        {
            IReadOnlyList<BgpServiceCommunity> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BgpServiceCommunity> array = new List<BgpServiceCommunity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BgpServiceCommunity.DeserializeBgpServiceCommunity(item));
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
            return new BgpServiceCommunityListResult(value, nextLink);
        }
    }
}
