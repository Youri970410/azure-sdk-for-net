// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayBackendHttpSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Port != null)
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (Protocol != null)
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (CookieBasedAffinity != null)
            {
                writer.WritePropertyName("cookieBasedAffinity");
                writer.WriteStringValue(CookieBasedAffinity.Value.ToString());
            }
            if (RequestTimeout != null)
            {
                writer.WritePropertyName("requestTimeout");
                writer.WriteNumberValue(RequestTimeout.Value);
            }
            if (Probe != null)
            {
                writer.WritePropertyName("probe");
                writer.WriteObjectValue(Probe);
            }
            if (AuthenticationCertificates != null)
            {
                writer.WritePropertyName("authenticationCertificates");
                writer.WriteStartArray();
                foreach (var item in AuthenticationCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ConnectionDraining != null)
            {
                writer.WritePropertyName("connectionDraining");
                writer.WriteObjectValue(ConnectionDraining);
            }
            if (HostName != null)
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (PickHostNameFromBackendAddress != null)
            {
                writer.WritePropertyName("pickHostNameFromBackendAddress");
                writer.WriteBooleanValue(PickHostNameFromBackendAddress.Value);
            }
            if (AffinityCookieName != null)
            {
                writer.WritePropertyName("affinityCookieName");
                writer.WriteStringValue(AffinityCookieName);
            }
            if (ProbeEnabled != null)
            {
                writer.WritePropertyName("probeEnabled");
                writer.WriteBooleanValue(ProbeEnabled.Value);
            }
            if (Path != null)
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayBackendHttpSettings DeserializeApplicationGatewayBackendHttpSettings(JsonElement element)
        {
            string name = default;
            string etag = default;
            string type = default;
            string id = default;
            int? port = default;
            ApplicationGatewayProtocol? protocol = default;
            ApplicationGatewayCookieBasedAffinity? cookieBasedAffinity = default;
            int? requestTimeout = default;
            SubResource probe = default;
            IList<SubResource> authenticationCertificates = default;
            ApplicationGatewayConnectionDraining connectionDraining = default;
            string hostName = default;
            bool? pickHostNameFromBackendAddress = default;
            string affinityCookieName = default;
            bool? probeEnabled = default;
            string path = default;
            string provisioningState = default;
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
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
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
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("protocol"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new ApplicationGatewayProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("cookieBasedAffinity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cookieBasedAffinity = new ApplicationGatewayCookieBasedAffinity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestTimeout"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestTimeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("probe"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            probe = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authenticationCertificates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(DeserializeSubResource(item));
                                }
                            }
                            authenticationCertificates = array;
                            continue;
                        }
                        if (property0.NameEquals("connectionDraining"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionDraining = ApplicationGatewayConnectionDraining.DeserializeApplicationGatewayConnectionDraining(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("pickHostNameFromBackendAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pickHostNameFromBackendAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("affinityCookieName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            affinityCookieName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("probeEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            probeEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("path"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayBackendHttpSettings(id, name, etag, type, port, protocol, cookieBasedAffinity, requestTimeout, probe, authenticationCertificates, connectionDraining, hostName, pickHostNameFromBackendAddress, affinityCookieName, probeEnabled, path, provisioningState);
        }
    }
}
