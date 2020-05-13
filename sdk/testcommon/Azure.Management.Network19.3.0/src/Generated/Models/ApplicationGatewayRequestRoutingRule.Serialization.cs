// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayRequestRoutingRule : IUtf8JsonSerializable
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
            if (RuleType != null)
            {
                writer.WritePropertyName("ruleType");
                writer.WriteStringValue(RuleType.Value.ToString());
            }
            if (BackendAddressPool != null)
            {
                writer.WritePropertyName("backendAddressPool");
                writer.WriteObjectValue(BackendAddressPool);
            }
            if (BackendHttpSettings != null)
            {
                writer.WritePropertyName("backendHttpSettings");
                writer.WriteObjectValue(BackendHttpSettings);
            }
            if (HttpListener != null)
            {
                writer.WritePropertyName("httpListener");
                writer.WriteObjectValue(HttpListener);
            }
            if (UrlPathMap != null)
            {
                writer.WritePropertyName("urlPathMap");
                writer.WriteObjectValue(UrlPathMap);
            }
            if (RedirectConfiguration != null)
            {
                writer.WritePropertyName("redirectConfiguration");
                writer.WriteObjectValue(RedirectConfiguration);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayRequestRoutingRule DeserializeApplicationGatewayRequestRoutingRule(JsonElement element)
        {
            string name = default;
            string etag = default;
            string type = default;
            string id = default;
            ApplicationGatewayRequestRoutingRuleType? ruleType = default;
            SubResource backendAddressPool = default;
            SubResource backendHttpSettings = default;
            SubResource httpListener = default;
            SubResource urlPathMap = default;
            SubResource redirectConfiguration = default;
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
                        if (property0.NameEquals("ruleType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ruleType = new ApplicationGatewayRequestRoutingRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("backendAddressPool"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendAddressPool = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backendHttpSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backendHttpSettings = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpListener"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpListener = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("urlPathMap"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            urlPathMap = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("redirectConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redirectConfiguration = DeserializeSubResource(property0.Value);
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
            return new ApplicationGatewayRequestRoutingRule(id, name, etag, type, ruleType, backendAddressPool, backendHttpSettings, httpListener, urlPathMap, redirectConfiguration, provisioningState);
        }
    }
}
