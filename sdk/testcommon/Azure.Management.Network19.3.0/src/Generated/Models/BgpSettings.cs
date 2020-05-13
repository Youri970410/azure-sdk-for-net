// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> BGP settings details. </summary>
    public partial class BgpSettings
    {
        /// <summary> Initializes a new instance of BgpSettings. </summary>
        public BgpSettings()
        {
        }

        /// <summary> Initializes a new instance of BgpSettings. </summary>
        /// <param name="asn"> The BGP speaker&apos;s ASN. </param>
        /// <param name="bgpPeeringAddress"> The BGP peering address and BGP identifier of this BGP speaker. </param>
        /// <param name="peerWeight"> The weight added to routes learned from this BGP speaker. </param>
        internal BgpSettings(long? asn, string bgpPeeringAddress, int? peerWeight)
        {
            Asn = asn;
            BgpPeeringAddress = bgpPeeringAddress;
            PeerWeight = peerWeight;
        }

        /// <summary> The BGP speaker&apos;s ASN. </summary>
        public long? Asn { get; set; }
        /// <summary> The BGP peering address and BGP identifier of this BGP speaker. </summary>
        public string BgpPeeringAddress { get; set; }
        /// <summary> The weight added to routes learned from this BGP speaker. </summary>
        public int? PeerWeight { get; set; }
    }
}
