// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.KeyVault.Models
{
    /// <summary> Parameters for creating or updating a vault. </summary>
    public partial class VaultPatchParameters
    {
        /// <summary> Initializes a new instance of VaultPatchParameters. </summary>
        public VaultPatchParameters()
        {
        }

        /// <summary> Initializes a new instance of VaultPatchParameters. </summary>
        /// <param name="tags"> The tags that will be assigned to the key vault. </param>
        /// <param name="properties"> Properties of the vault. </param>
        internal VaultPatchParameters(IDictionary<string, string> tags, VaultPatchProperties properties)
        {
            Tags = tags;
            Properties = properties;
        }

        /// <summary> The tags that will be assigned to the key vault. </summary>
        public IDictionary<string, string> Tags { get; set; }
        /// <summary> Properties of the vault. </summary>
        public VaultPatchProperties Properties { get; set; }
    }
}
