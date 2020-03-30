// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Protocol to be filtered on. </summary>
    public readonly partial struct PcProtocol : IEquatable<PcProtocol>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PcProtocol"/> values are the same. </summary>
        public PcProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TCPValue = "TCP";
        private const string UDPValue = "UDP";
        private const string AnyValue = "Any";

        /// <summary> TCP. </summary>
        public static PcProtocol TCP { get; } = new PcProtocol(TCPValue);
        /// <summary> UDP. </summary>
        public static PcProtocol UDP { get; } = new PcProtocol(UDPValue);
        /// <summary> Any. </summary>
        public static PcProtocol Any { get; } = new PcProtocol(AnyValue);
        /// <summary> Determines if two <see cref="PcProtocol"/> values are the same. </summary>
        public static bool operator ==(PcProtocol left, PcProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PcProtocol"/> values are not the same. </summary>
        public static bool operator !=(PcProtocol left, PcProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PcProtocol"/>. </summary>
        public static implicit operator PcProtocol(string value) => new PcProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PcProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PcProtocol other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
