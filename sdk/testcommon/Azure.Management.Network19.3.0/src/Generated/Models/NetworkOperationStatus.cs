// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> Status of the Azure async operation. Possible values are: &apos;InProgress&apos;, &apos;Succeeded&apos;, and &apos;Failed&apos;. </summary>
    public readonly partial struct NetworkOperationStatus : IEquatable<NetworkOperationStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="NetworkOperationStatus"/> values are the same. </summary>
        public NetworkOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> InProgress. </summary>
        public static NetworkOperationStatus InProgress { get; } = new NetworkOperationStatus(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static NetworkOperationStatus Succeeded { get; } = new NetworkOperationStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static NetworkOperationStatus Failed { get; } = new NetworkOperationStatus(FailedValue);
        /// <summary> Determines if two <see cref="NetworkOperationStatus"/> values are the same. </summary>
        public static bool operator ==(NetworkOperationStatus left, NetworkOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(NetworkOperationStatus left, NetworkOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkOperationStatus"/>. </summary>
        public static implicit operator NetworkOperationStatus(string value) => new NetworkOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
