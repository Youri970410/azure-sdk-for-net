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
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Gets name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="expressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection. </param>
        /// <param name="peerExpressRouteCircuitPeering"> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </param>
        /// <param name="addressPrefix"> /29 IP address space to carve out Customer addresses for tunnels. </param>
        /// <param name="authorizationKey"> The authorization key. </param>
        /// <param name="circuitConnectionStatus"> Express Route Circuit Connection State. Possible values are: &apos;Connected&apos; and &apos;Disconnected&apos;. </param>
        /// <param name="provisioningState"> Provisioning state of the circuit connection resource. Possible values are: &apos;Succeeded&apos;, &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </param>
        internal ExpressRouteCircuitConnection(string id, string name, string etag, SubResource expressRouteCircuitPeering, SubResource peerExpressRouteCircuitPeering, string addressPrefix, string authorizationKey, CircuitConnectionStatus? circuitConnectionStatus, string provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            AddressPrefix = addressPrefix;
            AuthorizationKey = authorizationKey;
            CircuitConnectionStatus = circuitConnectionStatus;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection. </summary>
        public SubResource ExpressRouteCircuitPeering { get; set; }
        /// <summary> Reference to Express Route Circuit Private Peering Resource of the peered circuit. </summary>
        public SubResource PeerExpressRouteCircuitPeering { get; set; }
        /// <summary> /29 IP address space to carve out Customer addresses for tunnels. </summary>
        public string AddressPrefix { get; set; }
        /// <summary> The authorization key. </summary>
        public string AuthorizationKey { get; set; }
        /// <summary> Express Route Circuit Connection State. Possible values are: &apos;Connected&apos; and &apos;Disconnected&apos;. </summary>
        public CircuitConnectionStatus? CircuitConnectionStatus { get; }
        /// <summary> Provisioning state of the circuit connection resource. Possible values are: &apos;Succeeded&apos;, &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </summary>
        public string ProvisioningState { get; }
    }
}
