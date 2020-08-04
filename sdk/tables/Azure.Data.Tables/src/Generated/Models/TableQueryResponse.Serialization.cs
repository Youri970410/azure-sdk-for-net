// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    internal partial class TableQueryResponse
    {
        internal static TableQueryResponse DeserializeTableQueryResponse(JsonElement element)
        {
            Optional<string> odataMetadata = default;
            Optional<IReadOnlyList<TableItem>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.metadata"))
                {
                    odataMetadata = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    List<TableItem> array = new List<TableItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TableItem.DeserializeTableItem(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new TableQueryResponse(odataMetadata.Value, Optional.ToList(value));
        }
    }
}
