// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> IP configuration for virtual network gateway. </summary>
    public partial class VirtualNetworkGatewayIPConfiguration : SubResource
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayIPConfiguration. </summary>
        public VirtualNetworkGatewayIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateIPAllocationMethod"> The private IP allocation method. Possible values are: &apos;Static&apos; and &apos;Dynamic&apos;. </param>
        /// <param name="subnet"> The reference of the subnet resource. </param>
        /// <param name="publicIPAddress"> The reference of the public IP resource. </param>
        /// <param name="provisioningState"> The provisioning state of the public IP resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </param>
        internal VirtualNetworkGatewayIPConfiguration(string id, string name, string etag, IPAllocationMethod? privateIPAllocationMethod, SubResource subnet, SubResource publicIPAddress, string provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; set; }
        /// <summary> The private IP allocation method. Possible values are: &apos;Static&apos; and &apos;Dynamic&apos;. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The reference of the subnet resource. </summary>
        public SubResource Subnet { get; set; }
        /// <summary> The reference of the public IP resource. </summary>
        public SubResource PublicIPAddress { get; set; }
        /// <summary> The provisioning state of the public IP resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </summary>
        public string ProvisioningState { get; }
    }
}
