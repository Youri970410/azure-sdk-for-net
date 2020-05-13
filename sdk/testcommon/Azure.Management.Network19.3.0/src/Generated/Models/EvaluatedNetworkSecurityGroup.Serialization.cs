// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class EvaluatedNetworkSecurityGroup
    {
        internal static EvaluatedNetworkSecurityGroup DeserializeEvaluatedNetworkSecurityGroup(JsonElement element)
        {
            string networkSecurityGroupId = default;
            MatchedRule matchedRule = default;
            IReadOnlyList<NetworkSecurityRulesEvaluationResult> rulesEvaluationResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkSecurityGroupId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkSecurityGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("matchedRule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchedRule = MatchedRule.DeserializeMatchedRule(property.Value);
                    continue;
                }
                if (property.NameEquals("rulesEvaluationResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkSecurityRulesEvaluationResult> array = new List<NetworkSecurityRulesEvaluationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(NetworkSecurityRulesEvaluationResult.DeserializeNetworkSecurityRulesEvaluationResult(item));
                        }
                    }
                    rulesEvaluationResult = array;
                    continue;
                }
            }
            return new EvaluatedNetworkSecurityGroup(networkSecurityGroupId, matchedRule, rulesEvaluationResult);
        }
    }
}
