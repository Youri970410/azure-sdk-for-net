// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> A network interface in a resource group. </summary>
    public partial class NetworkInterface : Resource
    {
        /// <summary> Initializes a new instance of NetworkInterface. </summary>
        public NetworkInterface()
        {
        }

        /// <summary> Initializes a new instance of NetworkInterface. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualMachine"> The reference of a virtual machine. </param>
        /// <param name="networkSecurityGroup"> The reference of the NetworkSecurityGroup resource. </param>
        /// <param name="ipConfigurations"> A list of IPConfigurations of the network interface. </param>
        /// <param name="dnsSettings"> The DNS settings in network interface. </param>
        /// <param name="macAddress"> The MAC address of the network interface. </param>
        /// <param name="primary"> Gets whether this is a primary network interface on a virtual machine. </param>
        /// <param name="enableAcceleratedNetworking"> If the network interface is accelerated networking enabled. </param>
        /// <param name="enableIPForwarding"> Indicates whether IP forwarding is enabled on this network interface. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network interface resource. </param>
        /// <param name="provisioningState"> The provisioning state of the public IP resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </param>
        internal NetworkInterface(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, SubResource virtualMachine, NetworkSecurityGroup networkSecurityGroup, IList<NetworkInterfaceIPConfiguration> ipConfigurations, NetworkInterfaceDnsSettings dnsSettings, string macAddress, bool? primary, bool? enableAcceleratedNetworking, bool? enableIPForwarding, string resourceGuid, string provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            VirtualMachine = virtualMachine;
            NetworkSecurityGroup = networkSecurityGroup;
            IpConfigurations = ipConfigurations;
            DnsSettings = dnsSettings;
            MacAddress = macAddress;
            Primary = primary;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            EnableIPForwarding = enableIPForwarding;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; set; }
        /// <summary> The reference of a virtual machine. </summary>
        public SubResource VirtualMachine { get; set; }
        /// <summary> The reference of the NetworkSecurityGroup resource. </summary>
        public NetworkSecurityGroup NetworkSecurityGroup { get; set; }
        /// <summary> A list of IPConfigurations of the network interface. </summary>
        public IList<NetworkInterfaceIPConfiguration> IpConfigurations { get; set; }
        /// <summary> The DNS settings in network interface. </summary>
        public NetworkInterfaceDnsSettings DnsSettings { get; set; }
        /// <summary> The MAC address of the network interface. </summary>
        public string MacAddress { get; set; }
        /// <summary> Gets whether this is a primary network interface on a virtual machine. </summary>
        public bool? Primary { get; set; }
        /// <summary> If the network interface is accelerated networking enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Indicates whether IP forwarding is enabled on this network interface. </summary>
        public bool? EnableIPForwarding { get; set; }
        /// <summary> The resource GUID property of the network interface resource. </summary>
        public string ResourceGuid { get; set; }
        /// <summary> The provisioning state of the public IP resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </summary>
        public string ProvisioningState { get; set; }
    }
}
