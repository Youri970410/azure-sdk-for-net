// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Network interface and its custom security rules. </summary>
    public partial class SubnetAssociation
    {
        /// <summary> Initializes a new instance of SubnetAssociation. </summary>
        internal SubnetAssociation()
        {
        }

        /// <summary> Initializes a new instance of SubnetAssociation. </summary>
        /// <param name="id"> Subnet ID. </param>
        /// <param name="securityRules"> Collection of custom security rules. </param>
        internal SubnetAssociation(string id, IReadOnlyList<SecurityRule> securityRules)
        {
            Id = id;
            SecurityRules = securityRules;
        }

        /// <summary> Subnet ID. </summary>
        public string Id { get; }
        /// <summary> Collection of custom security rules. </summary>
        public IReadOnlyList<SecurityRule> SecurityRules { get; }
    }
}
