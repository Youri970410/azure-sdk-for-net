// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ScopeProperties
    {
        /// <summary>
        /// Initializes a new instance of the ScopeProperties class.
        /// </summary>
        public ScopeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScopeProperties class.
        /// </summary>
        public ScopeProperties(string scope = default(string), bool? valid = default(bool?))
        {
            Scope = new List<string>
            {
                scope
            };
            Valid = valid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scopes")]
        public List<string> Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "valid")]
        public bool? Valid { get; set; }

    }
}
