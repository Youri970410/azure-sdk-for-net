// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> VPN client root certificate of virtual network gateway. </summary>
    public partial class VpnClientRootCertificate : SubResource
    {
        /// <summary> Initializes a new instance of VpnClientRootCertificate. </summary>
        /// <param name="publicCertData"> The certificate public data. </param>
        public VpnClientRootCertificate(string publicCertData)
        {
            PublicCertData = publicCertData;
        }

        /// <summary> Initializes a new instance of VpnClientRootCertificate. </summary>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="publicCertData"> The certificate public data. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN client root certificate resource. </param>
        /// <param name="id"> Resource ID. </param>
        internal VpnClientRootCertificate(string name, string etag, string publicCertData, ProvisioningState? provisioningState, string id) : base(id)
        {
            Name = name;
            Etag = etag;
            PublicCertData = publicCertData;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The certificate public data. </summary>
        public string PublicCertData { get; }
        /// <summary> The provisioning state of the VPN client root certificate resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
