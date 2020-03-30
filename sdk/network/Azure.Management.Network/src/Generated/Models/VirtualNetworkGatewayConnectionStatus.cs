// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Virtual Network Gateway connection status. </summary>
    public readonly partial struct VirtualNetworkGatewayConnectionStatus : IEquatable<VirtualNetworkGatewayConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="VirtualNetworkGatewayConnectionStatus"/> values are the same. </summary>
        public VirtualNetworkGatewayConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ConnectingValue = "Connecting";
        private const string ConnectedValue = "Connected";
        private const string NotConnectedValue = "NotConnected";

        /// <summary> Unknown. </summary>
        public static VirtualNetworkGatewayConnectionStatus Unknown { get; } = new VirtualNetworkGatewayConnectionStatus(UnknownValue);
        /// <summary> Connecting. </summary>
        public static VirtualNetworkGatewayConnectionStatus Connecting { get; } = new VirtualNetworkGatewayConnectionStatus(ConnectingValue);
        /// <summary> Connected. </summary>
        public static VirtualNetworkGatewayConnectionStatus Connected { get; } = new VirtualNetworkGatewayConnectionStatus(ConnectedValue);
        /// <summary> NotConnected. </summary>
        public static VirtualNetworkGatewayConnectionStatus NotConnected { get; } = new VirtualNetworkGatewayConnectionStatus(NotConnectedValue);
        /// <summary> Determines if two <see cref="VirtualNetworkGatewayConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkGatewayConnectionStatus left, VirtualNetworkGatewayConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkGatewayConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkGatewayConnectionStatus left, VirtualNetworkGatewayConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VirtualNetworkGatewayConnectionStatus"/>. </summary>
        public static implicit operator VirtualNetworkGatewayConnectionStatus(string value) => new VirtualNetworkGatewayConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkGatewayConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkGatewayConnectionStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
