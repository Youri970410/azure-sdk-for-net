// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> VirtualNetworkGatewayConnection properties. </summary>
    public partial class TunnelConnectionHealth
    {
        /// <summary> Initializes a new instance of TunnelConnectionHealth. </summary>
        public TunnelConnectionHealth()
        {
        }

        /// <summary> Initializes a new instance of TunnelConnectionHealth. </summary>
        /// <param name="tunnel"> Tunnel name. </param>
        /// <param name="connectionStatus"> Virtual network Gateway connection status. </param>
        /// <param name="ingressBytesTransferred"> The Ingress Bytes Transferred in this connection. </param>
        /// <param name="egressBytesTransferred"> The Egress Bytes Transferred in this connection. </param>
        /// <param name="lastConnectionEstablishedUtcTime"> The time at which connection was established in Utc format. </param>
        internal TunnelConnectionHealth(string tunnel, VirtualNetworkGatewayConnectionStatus? connectionStatus, long? ingressBytesTransferred, long? egressBytesTransferred, string lastConnectionEstablishedUtcTime)
        {
            Tunnel = tunnel;
            ConnectionStatus = connectionStatus;
            IngressBytesTransferred = ingressBytesTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            LastConnectionEstablishedUtcTime = lastConnectionEstablishedUtcTime;
        }

        /// <summary> Tunnel name. </summary>
        public string Tunnel { get; }
        /// <summary> Virtual network Gateway connection status. </summary>
        public VirtualNetworkGatewayConnectionStatus? ConnectionStatus { get; }
        /// <summary> The Ingress Bytes Transferred in this connection. </summary>
        public long? IngressBytesTransferred { get; }
        /// <summary> The Egress Bytes Transferred in this connection. </summary>
        public long? EgressBytesTransferred { get; }
        /// <summary> The time at which connection was established in Utc format. </summary>
        public string LastConnectionEstablishedUtcTime { get; }
    }
}
