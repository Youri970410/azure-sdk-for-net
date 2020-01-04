// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The API resource policies.
    /// </summary>
    public partial class ApiResourcePolicies
    {
        /// <summary>
        /// Initializes a new instance of the ApiResourcePolicies class.
        /// </summary>
        public ApiResourcePolicies()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiResourcePolicies class.
        /// </summary>
        /// <param name="content">The API level only policies XML as embedded
        /// content.</param>
        /// <param name="contentLink">The content link to the policies.</param>
        public ApiResourcePolicies(string content = default(string), string contentLink = default(string))
        {
            Content = content;
            ContentLink = contentLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the API level only policies XML as embedded content.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the content link to the policies.
        /// </summary>
        [JsonProperty(PropertyName = "contentLink")]
        public string ContentLink { get; set; }

    }
}