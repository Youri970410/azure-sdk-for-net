// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.KeyVault.Models
{
    /// <summary> The SecretPermissions. </summary>
    public readonly partial struct SecretPermissions : IEquatable<SecretPermissions>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="SecretPermissions"/> values are the same. </summary>
        public SecretPermissions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GetValue = "get";
        private const string ListValue = "list";
        private const string SetValue = "set";
        private const string DeleteValue = "delete";
        private const string BackupValue = "backup";
        private const string RestoreValue = "restore";
        private const string RecoverValue = "recover";
        private const string PurgeValue = "purge";

        /// <summary> get. </summary>
        public static SecretPermissions Get { get; } = new SecretPermissions(GetValue);
        /// <summary> list. </summary>
        public static SecretPermissions List { get; } = new SecretPermissions(ListValue);
        /// <summary> set. </summary>
        public static SecretPermissions Set { get; } = new SecretPermissions(SetValue);
        /// <summary> delete. </summary>
        public static SecretPermissions Delete { get; } = new SecretPermissions(DeleteValue);
        /// <summary> backup. </summary>
        public static SecretPermissions Backup { get; } = new SecretPermissions(BackupValue);
        /// <summary> restore. </summary>
        public static SecretPermissions Restore { get; } = new SecretPermissions(RestoreValue);
        /// <summary> recover. </summary>
        public static SecretPermissions Recover { get; } = new SecretPermissions(RecoverValue);
        /// <summary> purge. </summary>
        public static SecretPermissions Purge { get; } = new SecretPermissions(PurgeValue);
        /// <summary> Determines if two <see cref="SecretPermissions"/> values are the same. </summary>
        public static bool operator ==(SecretPermissions left, SecretPermissions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecretPermissions"/> values are not the same. </summary>
        public static bool operator !=(SecretPermissions left, SecretPermissions right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecretPermissions"/>. </summary>
        public static implicit operator SecretPermissions(string value) => new SecretPermissions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecretPermissions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecretPermissions other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
