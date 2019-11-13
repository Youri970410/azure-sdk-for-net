// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Deployment script object.
    /// </summary>
    public partial class DeploymentScript : AzureResourceBase
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentScript class.
        /// </summary>
        public DeploymentScript()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentScript class.
        /// </summary>
        /// <param name="identity">Managed identity to be used for this
        /// deployment script. Currently, only user-assigned MSI is
        /// supported.</param>
        /// <param name="location">The location of the ACI and the storage
        /// account for the deployment script.</param>
        /// <param name="id">String Id used to locate any resource on
        /// Azure.</param>
        /// <param name="name">Name of this resource.</param>
        /// <param name="type">Type of this resource.</param>
        /// <param name="tags">Resource tags.</param>
        public DeploymentScript(ManagedServiceIdentity identity, string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets managed identity to be used for this deployment
        /// script. Currently, only user-assigned MSI is supported.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ManagedServiceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the location of the ACI and the storage account for
        /// the deployment script.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identity");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}