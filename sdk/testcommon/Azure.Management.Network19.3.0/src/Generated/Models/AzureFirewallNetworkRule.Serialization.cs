// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AzureFirewallNetworkRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Protocols != null)
            {
                writer.WritePropertyName("protocols");
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (SourceAddresses != null)
            {
                writer.WritePropertyName("sourceAddresses");
                writer.WriteStartArray();
                foreach (var item in SourceAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (DestinationAddresses != null)
            {
                writer.WritePropertyName("destinationAddresses");
                writer.WriteStartArray();
                foreach (var item in DestinationAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (DestinationPorts != null)
            {
                writer.WritePropertyName("destinationPorts");
                writer.WriteStartArray();
                foreach (var item in DestinationPorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AzureFirewallNetworkRule DeserializeAzureFirewallNetworkRule(JsonElement element)
        {
            string name = default;
            string description = default;
            IList<AzureFirewallNetworkRuleProtocol> protocols = default;
            IList<string> sourceAddresses = default;
            IList<string> destinationAddresses = default;
            IList<string> destinationPorts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocols"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureFirewallNetworkRuleProtocol> array = new List<AzureFirewallNetworkRuleProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureFirewallNetworkRuleProtocol(item.GetString()));
                    }
                    protocols = array;
                    continue;
                }
                if (property.NameEquals("sourceAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    sourceAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    destinationAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationPorts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    destinationPorts = array;
                    continue;
                }
            }
            return new AzureFirewallNetworkRule(name, description, protocols, sourceAddresses, destinationAddresses, destinationPorts);
        }
    }
}
