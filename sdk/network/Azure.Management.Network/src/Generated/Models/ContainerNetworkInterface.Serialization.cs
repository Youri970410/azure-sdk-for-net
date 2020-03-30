// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ContainerNetworkInterface : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ContainerNetworkInterfaceConfiguration != null)
            {
                writer.WritePropertyName("containerNetworkInterfaceConfiguration");
                writer.WriteObjectValue(ContainerNetworkInterfaceConfiguration);
            }
            if (Container != null)
            {
                writer.WritePropertyName("container");
                writer.WriteObjectValue(Container);
            }
            if (IpConfigurations != null)
            {
                writer.WritePropertyName("ipConfigurations");
                writer.WriteStartArray();
                foreach (var item in IpConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerNetworkInterface DeserializeContainerNetworkInterface(JsonElement element)
        {
            string name = default;
            string type = default;
            string etag = default;
            string id = default;
            ContainerNetworkInterfaceConfiguration containerNetworkInterfaceConfiguration = default;
            Container container = default;
            IList<ContainerNetworkInterfaceIpConfiguration> ipConfigurations = default;
            ProvisioningState? provisioningState = default;
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
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("containerNetworkInterfaceConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerNetworkInterfaceConfiguration = ContainerNetworkInterfaceConfiguration.DeserializeContainerNetworkInterfaceConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("container"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            container = Container.DeserializeContainer(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerNetworkInterfaceIpConfiguration> array = new List<ContainerNetworkInterfaceIpConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerNetworkInterfaceIpConfiguration.DeserializeContainerNetworkInterfaceIpConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerNetworkInterface(name, type, etag, containerNetworkInterfaceConfiguration, container, ipConfigurations, provisioningState, id);
        }
    }
}
