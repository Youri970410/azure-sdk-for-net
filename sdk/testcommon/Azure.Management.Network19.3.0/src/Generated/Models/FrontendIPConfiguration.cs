// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Frontend IP address of the load balancer. </summary>
    public partial class FrontendIPConfiguration : SubResource
    {
        /// <summary> Initializes a new instance of FrontendIPConfiguration. </summary>
        public FrontendIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of FrontendIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="zones"> A list of availability zones denoting the IP allocated for the resource needs to come from. </param>
        /// <param name="inboundNatRules"> Read only. Inbound rules URIs that use this frontend IP. </param>
        /// <param name="inboundNatPools"> Read only. Inbound pools URIs that use this frontend IP. </param>
        /// <param name="outboundRules"> Read only. Outbound rules URIs that use this frontend IP. </param>
        /// <param name="loadBalancingRules"> Gets load balancing rules URIs that use this frontend IP. </param>
        /// <param name="privateIPAddress"> The private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> The Private IP allocation method. Possible values are: &apos;Static&apos; and &apos;Dynamic&apos;. </param>
        /// <param name="subnet"> The reference of the subnet resource. </param>
        /// <param name="publicIPAddress"> The reference of the Public IP resource. </param>
        /// <param name="publicIPPrefix"> The reference of the Public IP Prefix resource. </param>
        /// <param name="provisioningState"> Gets the provisioning state of the public IP resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </param>
        internal FrontendIPConfiguration(string id, string name, string etag, IList<string> zones, IList<SubResource> inboundNatRules, IList<SubResource> inboundNatPools, IList<SubResource> outboundRules, IList<SubResource> loadBalancingRules, string privateIPAddress, IPAllocationMethod? privateIPAllocationMethod, Subnet subnet, PublicIPAddress publicIPAddress, SubResource publicIPPrefix, string provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Zones = zones;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundRules = outboundRules;
            LoadBalancingRules = loadBalancingRules;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            PublicIPPrefix = publicIPPrefix;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; set; }
        /// <summary> A list of availability zones denoting the IP allocated for the resource needs to come from. </summary>
        public IList<string> Zones { get; set; }
        /// <summary> Read only. Inbound rules URIs that use this frontend IP. </summary>
        public IList<SubResource> InboundNatRules { get; }
        /// <summary> Read only. Inbound pools URIs that use this frontend IP. </summary>
        public IList<SubResource> InboundNatPools { get; }
        /// <summary> Read only. Outbound rules URIs that use this frontend IP. </summary>
        public IList<SubResource> OutboundRules { get; }
        /// <summary> Gets load balancing rules URIs that use this frontend IP. </summary>
        public IList<SubResource> LoadBalancingRules { get; }
        /// <summary> The private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The Private IP allocation method. Possible values are: &apos;Static&apos; and &apos;Dynamic&apos;. </summary>
        public IPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The reference of the subnet resource. </summary>
        public Subnet Subnet { get; set; }
        /// <summary> The reference of the Public IP resource. </summary>
        public PublicIPAddress PublicIPAddress { get; set; }
        /// <summary> The reference of the Public IP Prefix resource. </summary>
        public SubResource PublicIPPrefix { get; set; }
        /// <summary> Gets the provisioning state of the public IP resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </summary>
        public string ProvisioningState { get; set; }
    }
}
