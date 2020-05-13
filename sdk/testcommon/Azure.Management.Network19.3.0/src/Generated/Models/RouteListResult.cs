// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Response for the ListRoute API service call. </summary>
    public partial class RouteListResult
    {
        /// <summary> Initializes a new instance of RouteListResult. </summary>
        internal RouteListResult()
        {
        }

        /// <summary> Initializes a new instance of RouteListResult. </summary>
        /// <param name="value"> Gets a list of routes in a resource group. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal RouteListResult(IReadOnlyList<Route> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets a list of routes in a resource group. </summary>
        public IReadOnlyList<Route> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
