// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ManagedRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleSetType");
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion");
            writer.WriteStringValue(RuleSetVersion);
            if (RuleGroupOverrides != null)
            {
                writer.WritePropertyName("ruleGroupOverrides");
                writer.WriteStartArray();
                foreach (var item in RuleGroupOverrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ManagedRuleSet DeserializeManagedRuleSet(JsonElement element)
        {
            string ruleSetType = default;
            string ruleSetVersion = default;
            IList<ManagedRuleGroupOverride> ruleGroupOverrides = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleSetType"))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleGroupOverrides"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedRuleGroupOverride> array = new List<ManagedRuleGroupOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedRuleGroupOverride.DeserializeManagedRuleGroupOverride(item));
                    }
                    ruleGroupOverrides = array;
                    continue;
                }
            }
            return new ManagedRuleSet(ruleSetType, ruleSetVersion, ruleGroupOverrides);
        }
    }
}
