// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Properties of the rule. </summary>
    public partial class FirewallPolicyRule
    {
        /// <summary> Initializes a new instance of FirewallPolicyRule. </summary>
        public FirewallPolicyRule()
        {
            RuleType = null;
        }

        /// <summary> Initializes a new instance of FirewallPolicyRule. </summary>
        /// <param name="ruleType"> The type of the rule. </param>
        /// <param name="name"> The name of the rule. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule resource. </param>
        internal FirewallPolicyRule(FirewallPolicyRuleType ruleType, string name, int? priority)
        {
            RuleType = ruleType ?? null;
            Name = name;
            Priority = priority;
        }

        /// <summary> The type of the rule. </summary>
        internal FirewallPolicyRuleType RuleType { get; set; }
        /// <summary> The name of the rule. </summary>
        public string Name { get; set; }
        /// <summary> Priority of the Firewall Policy Rule resource. </summary>
        public int? Priority { get; set; }
    }
}
