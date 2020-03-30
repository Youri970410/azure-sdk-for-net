// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Rule condition of type network. </summary>
    public partial class NetworkRuleCondition : FirewallPolicyRuleCondition
    {
        /// <summary> Initializes a new instance of NetworkRuleCondition. </summary>
        public NetworkRuleCondition()
        {
            RuleConditionType = "NetworkRuleCondition";
        }

        /// <summary> Initializes a new instance of NetworkRuleCondition. </summary>
        /// <param name="ipProtocols"> Array of FirewallPolicyRuleConditionNetworkProtocols. </param>
        /// <param name="sourceAddresses"> List of source IP addresses for this rule. </param>
        /// <param name="destinationAddresses"> List of destination IP addresses or Service Tags. </param>
        /// <param name="destinationPorts"> List of destination ports. </param>
        /// <param name="sourceIpGroups"> List of source IpGroups for this rule. </param>
        /// <param name="destinationIpGroups"> List of destination IpGroups for this rule. </param>
        /// <param name="name"> Name of the rule condition. </param>
        /// <param name="description"> Description of the rule condition. </param>
        /// <param name="ruleConditionType"> Rule Condition Type. </param>
        internal NetworkRuleCondition(IList<FirewallPolicyRuleConditionNetworkProtocol> ipProtocols, IList<string> sourceAddresses, IList<string> destinationAddresses, IList<string> destinationPorts, IList<string> sourceIpGroups, IList<string> destinationIpGroups, string name, string description, FirewallPolicyRuleConditionType ruleConditionType) : base(name, description, ruleConditionType)
        {
            IpProtocols = ipProtocols;
            SourceAddresses = sourceAddresses;
            DestinationAddresses = destinationAddresses;
            DestinationPorts = destinationPorts;
            SourceIpGroups = sourceIpGroups;
            DestinationIpGroups = destinationIpGroups;
            RuleConditionType = ruleConditionType ?? "NetworkRuleCondition";
        }

        /// <summary> Array of FirewallPolicyRuleConditionNetworkProtocols. </summary>
        public IList<FirewallPolicyRuleConditionNetworkProtocol> IpProtocols { get; set; }
        /// <summary> List of source IP addresses for this rule. </summary>
        public IList<string> SourceAddresses { get; set; }
        /// <summary> List of destination IP addresses or Service Tags. </summary>
        public IList<string> DestinationAddresses { get; set; }
        /// <summary> List of destination ports. </summary>
        public IList<string> DestinationPorts { get; set; }
        /// <summary> List of source IpGroups for this rule. </summary>
        public IList<string> SourceIpGroups { get; set; }
        /// <summary> List of destination IpGroups for this rule. </summary>
        public IList<string> DestinationIpGroups { get; set; }
    }
}
