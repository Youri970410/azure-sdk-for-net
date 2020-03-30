// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Redirect type enum. </summary>
    public readonly partial struct ApplicationGatewayRedirectType : IEquatable<ApplicationGatewayRedirectType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ApplicationGatewayRedirectType"/> values are the same. </summary>
        public ApplicationGatewayRedirectType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PermanentValue = "Permanent";
        private const string FoundValue = "Found";
        private const string SeeOtherValue = "SeeOther";
        private const string TemporaryValue = "Temporary";

        /// <summary> Permanent. </summary>
        public static ApplicationGatewayRedirectType Permanent { get; } = new ApplicationGatewayRedirectType(PermanentValue);
        /// <summary> Found. </summary>
        public static ApplicationGatewayRedirectType Found { get; } = new ApplicationGatewayRedirectType(FoundValue);
        /// <summary> SeeOther. </summary>
        public static ApplicationGatewayRedirectType SeeOther { get; } = new ApplicationGatewayRedirectType(SeeOtherValue);
        /// <summary> Temporary. </summary>
        public static ApplicationGatewayRedirectType Temporary { get; } = new ApplicationGatewayRedirectType(TemporaryValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayRedirectType"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayRedirectType left, ApplicationGatewayRedirectType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayRedirectType"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayRedirectType left, ApplicationGatewayRedirectType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationGatewayRedirectType"/>. </summary>
        public static implicit operator ApplicationGatewayRedirectType(string value) => new ApplicationGatewayRedirectType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayRedirectType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayRedirectType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
