// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.KeyVault.Models
{
    public partial class DeletedVaultProperties
    {
        internal static DeletedVaultProperties DeserializeDeletedVaultProperties(JsonElement element)
        {
            string vaultId = default;
            string location = default;
            DateTimeOffset? deletionDate = default;
            DateTimeOffset? scheduledPurgeDate = default;
            IReadOnlyDictionary<string, string> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletionDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionDate = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledPurgeDate = property.Value.GetDateTimeOffset("S");
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new DeletedVaultProperties(vaultId, location, deletionDate, scheduledPurgeDate, tags);
        }
    }
}
