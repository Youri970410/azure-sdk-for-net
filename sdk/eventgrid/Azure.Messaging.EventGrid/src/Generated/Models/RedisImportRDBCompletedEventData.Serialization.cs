// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class RedisImportRDBCompletedEventData
    {
        internal static RedisImportRDBCompletedEventData DeserializeRedisImportRDBCompletedEventData(JsonElement element)
        {
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> name = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new RedisImportRDBCompletedEventData(Optional.ToNullable(timestamp), name.Value, status.Value);
        }
    }
}
