// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VirtualNetworkGatewayConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (AuthorizationKey != null)
            {
                writer.WritePropertyName("authorizationKey");
                writer.WriteStringValue(AuthorizationKey);
            }
            writer.WritePropertyName("virtualNetworkGateway1");
            writer.WriteObjectValue(VirtualNetworkGateway1);
            if (VirtualNetworkGateway2 != null)
            {
                writer.WritePropertyName("virtualNetworkGateway2");
                writer.WriteObjectValue(VirtualNetworkGateway2);
            }
            if (LocalNetworkGateway2 != null)
            {
                writer.WritePropertyName("localNetworkGateway2");
                writer.WriteObjectValue(LocalNetworkGateway2);
            }
            writer.WritePropertyName("connectionType");
            writer.WriteStringValue(ConnectionType.ToString());
            if (ConnectionProtocol != null)
            {
                writer.WritePropertyName("connectionProtocol");
                writer.WriteStringValue(ConnectionProtocol.Value.ToString());
            }
            if (RoutingWeight != null)
            {
                writer.WritePropertyName("routingWeight");
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (SharedKey != null)
            {
                writer.WritePropertyName("sharedKey");
                writer.WriteStringValue(SharedKey);
            }
            if (ConnectionStatus != null)
            {
                writer.WritePropertyName("connectionStatus");
                writer.WriteStringValue(ConnectionStatus.Value.ToString());
            }
            if (TunnelConnectionStatus != null)
            {
                writer.WritePropertyName("tunnelConnectionStatus");
                writer.WriteStartArray();
                foreach (var item in TunnelConnectionStatus)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (EgressBytesTransferred != null)
            {
                writer.WritePropertyName("egressBytesTransferred");
                writer.WriteNumberValue(EgressBytesTransferred.Value);
            }
            if (IngressBytesTransferred != null)
            {
                writer.WritePropertyName("ingressBytesTransferred");
                writer.WriteNumberValue(IngressBytesTransferred.Value);
            }
            if (Peer != null)
            {
                writer.WritePropertyName("peer");
                writer.WriteObjectValue(Peer);
            }
            if (EnableBgp != null)
            {
                writer.WritePropertyName("enableBgp");
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (UseLocalAzureIpAddress != null)
            {
                writer.WritePropertyName("useLocalAzureIpAddress");
                writer.WriteBooleanValue(UseLocalAzureIpAddress.Value);
            }
            if (UsePolicyBasedTrafficSelectors != null)
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors");
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (IpsecPolicies != null)
            {
                writer.WritePropertyName("ipsecPolicies");
                writer.WriteStartArray();
                foreach (var item in IpsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TrafficSelectorPolicies != null)
            {
                writer.WritePropertyName("trafficSelectorPolicies");
                writer.WriteStartArray();
                foreach (var item in TrafficSelectorPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ResourceGuid != null)
            {
                writer.WritePropertyName("resourceGuid");
                writer.WriteStringValue(ResourceGuid);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (ExpressRouteGatewayBypass != null)
            {
                writer.WritePropertyName("expressRouteGatewayBypass");
                writer.WriteBooleanValue(ExpressRouteGatewayBypass.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualNetworkGatewayConnection DeserializeVirtualNetworkGatewayConnection(JsonElement element)
        {
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            string authorizationKey = default;
            VirtualNetworkGateway virtualNetworkGateway1 = default;
            VirtualNetworkGateway virtualNetworkGateway2 = default;
            LocalNetworkGateway localNetworkGateway2 = default;
            VirtualNetworkGatewayConnectionType connectionType = default;
            VirtualNetworkGatewayConnectionProtocol? connectionProtocol = default;
            int? routingWeight = default;
            string sharedKey = default;
            VirtualNetworkGatewayConnectionStatus? connectionStatus = default;
            IList<TunnelConnectionHealth> tunnelConnectionStatus = default;
            long? egressBytesTransferred = default;
            long? ingressBytesTransferred = default;
            SubResource peer = default;
            bool? enableBgp = default;
            bool? useLocalAzureIpAddress = default;
            bool? usePolicyBasedTrafficSelectors = default;
            IList<IpsecPolicy> ipsecPolicies = default;
            IList<TrafficSelectorPolicy> trafficSelectorPolicies = default;
            string resourceGuid = default;
            ProvisioningState? provisioningState = default;
            bool? expressRouteGatewayBypass = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("authorizationKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGateway1"))
                        {
                            virtualNetworkGateway1 = VirtualNetworkGateway.DeserializeVirtualNetworkGateway(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkGateway2"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkGateway2 = VirtualNetworkGateway.DeserializeVirtualNetworkGateway(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("localNetworkGateway2"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localNetworkGateway2 = LocalNetworkGateway.DeserializeLocalNetworkGateway(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectionType"))
                        {
                            connectionType = new VirtualNetworkGatewayConnectionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("connectionProtocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionProtocol = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionStatus = new VirtualNetworkGatewayConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tunnelConnectionStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TunnelConnectionHealth> array = new List<TunnelConnectionHealth>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TunnelConnectionHealth.DeserializeTunnelConnectionHealth(item));
                            }
                            tunnelConnectionStatus = array;
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("peer"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peer = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useLocalAzureIpAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IpsecPolicy> array = new List<IpsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IpsecPolicy.DeserializeIpsecPolicy(item));
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("trafficSelectorPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TrafficSelectorPolicy> array = new List<TrafficSelectorPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrafficSelectorPolicy.DeserializeTrafficSelectorPolicy(item));
                            }
                            trafficSelectorPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetString();
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
                        if (property0.NameEquals("expressRouteGatewayBypass"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteGatewayBypass = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualNetworkGatewayConnection(etag, authorizationKey, virtualNetworkGateway1, virtualNetworkGateway2, localNetworkGateway2, connectionType, connectionProtocol, routingWeight, sharedKey, connectionStatus, tunnelConnectionStatus, egressBytesTransferred, ingressBytesTransferred, peer, enableBgp, useLocalAzureIpAddress, usePolicyBasedTrafficSelectors, ipsecPolicies, trafficSelectorPolicies, resourceGuid, provisioningState, expressRouteGatewayBypass, id, name, type, location, tags);
        }
    }
}
