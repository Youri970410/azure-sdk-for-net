// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Express Route Circuit Connection in an ExpressRouteCircuitPeering resource. </summary>
    public partial class ExpressRouteCircuitConnection : SubResource
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitConnection. </summary>
        public ExpressRouteCircuitConnection()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitConnection. </summary>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="expressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection. </param>
        /// <param name="peerExpressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </param>
        /// <param name="addressPrefix"> /29 IP address space to carve out Customer addresses for tunnels. </param>
        /// <param name="authorizationKey"> The authorization key. </param>
        /// <param name="ipv6CircuitConnectionConfig"> IPv6 Address PrefixProperties of the express route circuit connection. </param>
        /// <param name="circuitConnectionStatus"> Express Route Circuit connection state. </param>
        /// <param name="provisioningState"> The provisioning state of the express route circuit connection resource. </param>
        /// <param name="id"> Resource ID. </param>
        internal ExpressRouteCircuitConnection(string name, string etag, string type, SubResource expressRouteCircuitPeering, SubResource peerExpressRouteCircuitPeering, string addressPrefix, string authorizationKey, Ipv6CircuitConnectionConfig ipv6CircuitConnectionConfig, CircuitConnectionStatus? circuitConnectionStatus, ProvisioningState? provisioningState, string id) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            AddressPrefix = addressPrefix;
            AuthorizationKey = authorizationKey;
            Ipv6CircuitConnectionConfig = ipv6CircuitConnectionConfig;
            CircuitConnectionStatus = circuitConnectionStatus;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection. </summary>
        public SubResource ExpressRouteCircuitPeering { get; set; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </summary>
        public SubResource PeerExpressRouteCircuitPeering { get; set; }
        /// <summary> /29 IP address space to carve out Customer addresses for tunnels. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The authorization key. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> IPv6 Address PrefixProperties of the express route circuit connection. </summary>
        public Ipv6CircuitConnectionConfig Ipv6CircuitConnectionConfig { get; set; }
        /// <summary> Express Route Circuit connection state. </summary>
        public CircuitConnectionStatus? CircuitConnectionStatus { get; set; }
        /// <summary> The provisioning state of the express route circuit connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
