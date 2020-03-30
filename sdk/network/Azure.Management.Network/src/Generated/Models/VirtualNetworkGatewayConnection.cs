// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> A common class for general resource information. </summary>
    public partial class VirtualNetworkGatewayConnection : Resource
    {
        /// <summary> Initializes a new instance of VirtualNetworkGatewayConnection. </summary>
        /// <param name="virtualNetworkGateway1"> The reference to virtual network gateway resource. </param>
        /// <param name="connectionType"> Gateway connection type. </param>
        public VirtualNetworkGatewayConnection(VirtualNetworkGateway virtualNetworkGateway1, VirtualNetworkGatewayConnectionType connectionType)
        {
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            ConnectionType = connectionType;
        }

        /// <summary> Initializes a new instance of VirtualNetworkGatewayConnection. </summary>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="authorizationKey"> The authorizationKey. </param>
        /// <param name="virtualNetworkGateway1"> The reference to virtual network gateway resource. </param>
        /// <param name="virtualNetworkGateway2"> The reference to virtual network gateway resource. </param>
        /// <param name="localNetworkGateway2"> The reference to local network gateway resource. </param>
        /// <param name="connectionType"> Gateway connection type. </param>
        /// <param name="connectionProtocol"> Connection protocol used for this connection. </param>
        /// <param name="routingWeight"> The routing weight. </param>
        /// <param name="sharedKey"> The IPSec shared key. </param>
        /// <param name="connectionStatus"> Virtual Network Gateway connection status. </param>
        /// <param name="tunnelConnectionStatus"> Collection of all tunnels&apos; connection health status. </param>
        /// <param name="egressBytesTransferred"> The egress bytes transferred in this connection. </param>
        /// <param name="ingressBytesTransferred"> The ingress bytes transferred in this connection. </param>
        /// <param name="peer"> The reference to peerings resource. </param>
        /// <param name="enableBgp"> EnableBgp flag. </param>
        /// <param name="useLocalAzureIpAddress"> Use private local Azure IP for the connection. </param>
        /// <param name="usePolicyBasedTrafficSelectors"> Enable policy-based traffic selectors. </param>
        /// <param name="ipsecPolicies"> The IPSec Policies to be considered by this connection. </param>
        /// <param name="trafficSelectorPolicies"> The Traffic Selector Policies to be considered by this connection. </param>
        /// <param name="resourceGuid"> The resource GUID property of the virtual network gateway connection resource. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network gateway connection resource. </param>
        /// <param name="expressRouteGatewayBypass"> Bypass ExpressRoute Gateway for data forwarding. </param>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        internal VirtualNetworkGatewayConnection(string etag, string authorizationKey, VirtualNetworkGateway virtualNetworkGateway1, VirtualNetworkGateway virtualNetworkGateway2, LocalNetworkGateway localNetworkGateway2, VirtualNetworkGatewayConnectionType connectionType, VirtualNetworkGatewayConnectionProtocol? connectionProtocol, int? routingWeight, string sharedKey, VirtualNetworkGatewayConnectionStatus? connectionStatus, IList<TunnelConnectionHealth> tunnelConnectionStatus, long? egressBytesTransferred, long? ingressBytesTransferred, SubResource peer, bool? enableBgp, bool? useLocalAzureIpAddress, bool? usePolicyBasedTrafficSelectors, IList<IpsecPolicy> ipsecPolicies, IList<TrafficSelectorPolicy> trafficSelectorPolicies, string resourceGuid, ProvisioningState? provisioningState, bool? expressRouteGatewayBypass, string id, string name, string type, string location, IDictionary<string, string> tags) : base(id, name, type, location, tags)
        {
            Etag = etag;
            AuthorizationKey = authorizationKey;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
            LocalNetworkGateway2 = localNetworkGateway2;
            ConnectionType = connectionType;
            ConnectionProtocol = connectionProtocol;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            ConnectionStatus = connectionStatus;
            TunnelConnectionStatus = tunnelConnectionStatus;
            EgressBytesTransferred = egressBytesTransferred;
            IngressBytesTransferred = ingressBytesTransferred;
            Peer = peer;
            EnableBgp = enableBgp;
            UseLocalAzureIpAddress = useLocalAzureIpAddress;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IpsecPolicies = ipsecPolicies;
            TrafficSelectorPolicies = trafficSelectorPolicies;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            ExpressRouteGatewayBypass = expressRouteGatewayBypass;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The authorizationKey. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> The reference to virtual network gateway resource. </summary>
        public VirtualNetworkGateway VirtualNetworkGateway1 { get; }
        /// <summary> The reference to virtual network gateway resource. </summary>
        public VirtualNetworkGateway VirtualNetworkGateway2 { get; set; }
        /// <summary> The reference to local network gateway resource. </summary>
        public LocalNetworkGateway LocalNetworkGateway2 { get; set; }
        /// <summary> Gateway connection type. </summary>
        public VirtualNetworkGatewayConnectionType ConnectionType { get; }
        /// <summary> Connection protocol used for this connection. </summary>
        public VirtualNetworkGatewayConnectionProtocol? ConnectionProtocol { get; set; }
        /// <summary> The routing weight. </summary>
        public int? RoutingWeight { get; set; }
        /// <summary> The IPSec shared key. </summary>
        public string SharedKey { get; set; }
        /// <summary> Virtual Network Gateway connection status. </summary>
        public VirtualNetworkGatewayConnectionStatus? ConnectionStatus { get; }
        /// <summary> Collection of all tunnels&apos; connection health status. </summary>
        public IList<TunnelConnectionHealth> TunnelConnectionStatus { get; }
        /// <summary> The egress bytes transferred in this connection. </summary>
        public long? EgressBytesTransferred { get; }
        /// <summary> The ingress bytes transferred in this connection. </summary>
        public long? IngressBytesTransferred { get; }
        /// <summary> The reference to peerings resource. </summary>
        public SubResource Peer { get; set; }
        /// <summary> EnableBgp flag. </summary>
        public bool? EnableBgp { get; set; }
        /// <summary> Use private local Azure IP for the connection. </summary>
        public bool? UseLocalAzureIpAddress { get; set; }
        /// <summary> Enable policy-based traffic selectors. </summary>
        public bool? UsePolicyBasedTrafficSelectors { get; set; }
        /// <summary> The IPSec Policies to be considered by this connection. </summary>
        public IList<IpsecPolicy> IpsecPolicies { get; set; }
        /// <summary> The Traffic Selector Policies to be considered by this connection. </summary>
        public IList<TrafficSelectorPolicy> TrafficSelectorPolicies { get; set; }
        /// <summary> The resource GUID property of the virtual network gateway connection resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the virtual network gateway connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Bypass ExpressRoute Gateway for data forwarding. </summary>
        public bool? ExpressRouteGatewayBypass { get; set; }
    }
}
