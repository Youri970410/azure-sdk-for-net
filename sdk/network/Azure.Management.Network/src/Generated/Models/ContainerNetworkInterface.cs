// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Container network interface child resource. </summary>
    public partial class ContainerNetworkInterface : SubResource
    {
        /// <summary> Initializes a new instance of ContainerNetworkInterface. </summary>
        public ContainerNetworkInterface()
        {
        }

        /// <summary> Initializes a new instance of ContainerNetworkInterface. </summary>
        /// <param name="name"> The name of the resource. This name can be used to access the resource. </param>
        /// <param name="type"> Sub Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="containerNetworkInterfaceConfiguration"> Container network interface configuration from which this container network interface is created. </param>
        /// <param name="container"> Reference to the container to which this container network interface is attached. </param>
        /// <param name="ipConfigurations"> Reference to the ip configuration on this container nic. </param>
        /// <param name="provisioningState"> The provisioning state of the container network interface resource. </param>
        /// <param name="id"> Resource ID. </param>
        internal ContainerNetworkInterface(string name, string type, string etag, ContainerNetworkInterfaceConfiguration containerNetworkInterfaceConfiguration, Container container, IList<ContainerNetworkInterfaceIpConfiguration> ipConfigurations, ProvisioningState? provisioningState, string id) : base(id)
        {
            Name = name;
            Type = type;
            Etag = etag;
            ContainerNetworkInterfaceConfiguration = containerNetworkInterfaceConfiguration;
            Container = container;
            IpConfigurations = ipConfigurations;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> Sub Resource type. </summary>
        public string Type { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Container network interface configuration from which this container network interface is created. </summary>
        public ContainerNetworkInterfaceConfiguration ContainerNetworkInterfaceConfiguration { get; }
        /// <summary> Reference to the container to which this container network interface is attached. </summary>
        public Container Container { get; set; }
        /// <summary> Reference to the ip configuration on this container nic. </summary>
        public IList<ContainerNetworkInterfaceIpConfiguration> IpConfigurations { get; }
        /// <summary> The provisioning state of the container network interface resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
