// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.KeyVault.Models
{
    /// <summary> Tells what traffic can bypass network rules. This can be &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the default is &apos;AzureServices&apos;. </summary>
    public readonly partial struct NetworkRuleBypassOptions : IEquatable<NetworkRuleBypassOptions>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="NetworkRuleBypassOptions"/> values are the same. </summary>
        public NetworkRuleBypassOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureServicesValue = "AzureServices";
        private const string NoneValue = "None";

        /// <summary> AzureServices. </summary>
        public static NetworkRuleBypassOptions AzureServices { get; } = new NetworkRuleBypassOptions(AzureServicesValue);
        /// <summary> None. </summary>
        public static NetworkRuleBypassOptions None { get; } = new NetworkRuleBypassOptions(NoneValue);
        /// <summary> Determines if two <see cref="NetworkRuleBypassOptions"/> values are the same. </summary>
        public static bool operator ==(NetworkRuleBypassOptions left, NetworkRuleBypassOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkRuleBypassOptions"/> values are not the same. </summary>
        public static bool operator !=(NetworkRuleBypassOptions left, NetworkRuleBypassOptions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkRuleBypassOptions"/>. </summary>
        public static implicit operator NetworkRuleBypassOptions(string value) => new NetworkRuleBypassOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkRuleBypassOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkRuleBypassOptions other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
