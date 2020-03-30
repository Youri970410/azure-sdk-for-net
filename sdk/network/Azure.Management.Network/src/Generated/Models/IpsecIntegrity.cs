// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The IPSec integrity algorithm (IKE phase 1). </summary>
    public readonly partial struct IpsecIntegrity : IEquatable<IpsecIntegrity>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="IpsecIntegrity"/> values are the same. </summary>
        public IpsecIntegrity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MD5Value = "MD5";
        private const string SHA1Value = "SHA1";
        private const string SHA256Value = "SHA256";
        private const string Gcmaes128Value = "GCMAES128";
        private const string Gcmaes192Value = "GCMAES192";
        private const string Gcmaes256Value = "GCMAES256";

        /// <summary> MD5. </summary>
        public static IpsecIntegrity MD5 { get; } = new IpsecIntegrity(MD5Value);
        /// <summary> SHA1. </summary>
        public static IpsecIntegrity SHA1 { get; } = new IpsecIntegrity(SHA1Value);
        /// <summary> SHA256. </summary>
        public static IpsecIntegrity SHA256 { get; } = new IpsecIntegrity(SHA256Value);
        /// <summary> GCMAES128. </summary>
        public static IpsecIntegrity Gcmaes128 { get; } = new IpsecIntegrity(Gcmaes128Value);
        /// <summary> GCMAES192. </summary>
        public static IpsecIntegrity Gcmaes192 { get; } = new IpsecIntegrity(Gcmaes192Value);
        /// <summary> GCMAES256. </summary>
        public static IpsecIntegrity Gcmaes256 { get; } = new IpsecIntegrity(Gcmaes256Value);
        /// <summary> Determines if two <see cref="IpsecIntegrity"/> values are the same. </summary>
        public static bool operator ==(IpsecIntegrity left, IpsecIntegrity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IpsecIntegrity"/> values are not the same. </summary>
        public static bool operator !=(IpsecIntegrity left, IpsecIntegrity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IpsecIntegrity"/>. </summary>
        public static implicit operator IpsecIntegrity(string value) => new IpsecIntegrity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IpsecIntegrity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IpsecIntegrity other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
