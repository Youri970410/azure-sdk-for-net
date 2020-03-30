// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Private link service resource. </summary>
    public partial class PrivateLinkService : Resource
    {
        /// <summary> Initializes a new instance of PrivateLinkService. </summary>
        public PrivateLinkService()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkService. </summary>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="loadBalancerFrontendIpConfigurations"> An array of references to the load balancer IP configurations. </param>
        /// <param name="ipConfigurations"> An array of private link service IP configurations. </param>
        /// <param name="networkInterfaces"> An array of references to the network interfaces created for this private link service. </param>
        /// <param name="provisioningState"> The provisioning state of the private link service resource. </param>
        /// <param name="privateEndpointConnections"> An array of list about connections to the private endpoint. </param>
        /// <param name="visibility"> The visibility list of the private link service. </param>
        /// <param name="autoApproval"> The auto-approval list of the private link service. </param>
        /// <param name="fqdns"> The list of Fqdn. </param>
        /// <param name="alias"> The alias of the private link service. </param>
        /// <param name="enableProxyProtocol"> Whether the private link service is enabled for proxy protocol or not. </param>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal PrivateLinkService(string etag, IList<FrontendIPConfiguration> loadBalancerFrontendIpConfigurations, IList<PrivateLinkServiceIpConfiguration> ipConfigurations, IList<NetworkInterface> networkInterfaces, ProvisioningState? provisioningState, IList<PrivateEndpointConnection> privateEndpointConnections, PrivateLinkServicePropertiesVisibility visibility, PrivateLinkServicePropertiesAutoApproval autoApproval, IList<string> fqdns, string alias, bool? enableProxyProtocol, string id, string name, string type, string location, IDictionary<string, string> tags) : base(id, name, type, location, tags)
        {
            Etag = etag;
            LoadBalancerFrontendIpConfigurations = loadBalancerFrontendIpConfigurations;
            IpConfigurations = ipConfigurations;
            NetworkInterfaces = networkInterfaces;
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            Visibility = visibility;
            AutoApproval = autoApproval;
            Fqdns = fqdns;
            Alias = alias;
            EnableProxyProtocol = enableProxyProtocol;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> An array of references to the load balancer IP configurations. </summary>
        public IList<FrontendIPConfiguration> LoadBalancerFrontendIpConfigurations { get; set; }
        /// <summary> An array of private link service IP configurations. </summary>
        public IList<PrivateLinkServiceIpConfiguration> IpConfigurations { get; set; }
        /// <summary> An array of references to the network interfaces created for this private link service. </summary>
        public IList<NetworkInterface> NetworkInterfaces { get; }
        /// <summary> The provisioning state of the private link service resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> An array of list about connections to the private endpoint. </summary>
        public IList<PrivateEndpointConnection> PrivateEndpointConnections { get; }
        /// <summary> The visibility list of the private link service. </summary>
        public PrivateLinkServicePropertiesVisibility Visibility { get; set; }
        /// <summary> The auto-approval list of the private link service. </summary>
        public PrivateLinkServicePropertiesAutoApproval AutoApproval { get; set; }
        /// <summary> The list of Fqdn. </summary>
        public IList<string> Fqdns { get; set; }
        /// <summary> The alias of the private link service. </summary>
        public string Alias { get; }
        /// <summary> Whether the private link service is enabled for proxy protocol or not. </summary>
        public bool? EnableProxyProtocol { get; set; }
    }
}
