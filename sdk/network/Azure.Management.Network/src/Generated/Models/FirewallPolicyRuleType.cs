// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The type of the rule. </summary>
    public readonly partial struct FirewallPolicyRuleType : IEquatable<FirewallPolicyRuleType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FirewallPolicyRuleType"/> values are the same. </summary>
        public FirewallPolicyRuleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FirewallPolicyNatRuleValue = "FirewallPolicyNatRule";
        private const string FirewallPolicyFilterRuleValue = "FirewallPolicyFilterRule";

        /// <summary> FirewallPolicyNatRule. </summary>
        public static FirewallPolicyRuleType FirewallPolicyNatRule { get; } = new FirewallPolicyRuleType(FirewallPolicyNatRuleValue);
        /// <summary> FirewallPolicyFilterRule. </summary>
        public static FirewallPolicyRuleType FirewallPolicyFilterRule { get; } = new FirewallPolicyRuleType(FirewallPolicyFilterRuleValue);
        /// <summary> Determines if two <see cref="FirewallPolicyRuleType"/> values are the same. </summary>
        public static bool operator ==(FirewallPolicyRuleType left, FirewallPolicyRuleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallPolicyRuleType"/> values are not the same. </summary>
        public static bool operator !=(FirewallPolicyRuleType left, FirewallPolicyRuleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallPolicyRuleType"/>. </summary>
        public static implicit operator FirewallPolicyRuleType(string value) => new FirewallPolicyRuleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallPolicyRuleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallPolicyRuleType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
