// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for ListArpTable associated with the Express Route Circuits API. </summary>
    public partial class ExpressRouteCircuitsArpTableListResult
    {
        /// <summary> Initializes a new instance of ExpressRouteCircuitsArpTableListResult. </summary>
        internal ExpressRouteCircuitsArpTableListResult()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCircuitsArpTableListResult. </summary>
        /// <param name="value"> Gets list of the ARP table. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteCircuitsArpTableListResult(IReadOnlyList<ExpressRouteCircuitArpTable> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets list of the ARP table. </summary>
        public IReadOnlyList<ExpressRouteCircuitArpTable> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
