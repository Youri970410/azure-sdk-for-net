// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Create operation.
    /// </summary>
    public partial class DataFlowDebugSessionCreateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the DataFlowDebugSessionCreateHeaders
        /// class.
        /// </summary>
        public DataFlowDebugSessionCreateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataFlowDebugSessionCreateHeaders
        /// class.
        /// </summary>
        /// <param name="location">URI to poll for asynchronous operation
        /// status.</param>
        public DataFlowDebugSessionCreateHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URI to poll for asynchronous operation status.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}