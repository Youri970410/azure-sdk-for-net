// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> UrlPathMaps give a url path to the backend mapping information for PathBasedRouting. </summary>
    public partial class ApplicationGatewayUrlPathMap : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayUrlPathMap. </summary>
        public ApplicationGatewayUrlPathMap()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayUrlPathMap. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the URL path map that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="defaultBackendAddressPool"> Default backend address pool resource of URL path map. </param>
        /// <param name="defaultBackendHttpSettings"> Default backend http settings resource of URL path map. </param>
        /// <param name="defaultRedirectConfiguration"> Default redirect configuration resource of URL path map. </param>
        /// <param name="pathRules"> Path rule of URL path map resource. </param>
        /// <param name="provisioningState"> Provisioning state of the backend http settings resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </param>
        internal ApplicationGatewayUrlPathMap(string id, string name, string etag, string type, SubResource defaultBackendAddressPool, SubResource defaultBackendHttpSettings, SubResource defaultRedirectConfiguration, IList<ApplicationGatewayPathRule> pathRules, string provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            DefaultBackendAddressPool = defaultBackendAddressPool;
            DefaultBackendHttpSettings = defaultBackendHttpSettings;
            DefaultRedirectConfiguration = defaultRedirectConfiguration;
            PathRules = pathRules;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the URL path map that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; set; }
        /// <summary> Default backend address pool resource of URL path map. </summary>
        public SubResource DefaultBackendAddressPool { get; set; }
        /// <summary> Default backend http settings resource of URL path map. </summary>
        public SubResource DefaultBackendHttpSettings { get; set; }
        /// <summary> Default redirect configuration resource of URL path map. </summary>
        public SubResource DefaultRedirectConfiguration { get; set; }
        /// <summary> Path rule of URL path map resource. </summary>
        public IList<ApplicationGatewayPathRule> PathRules { get; set; }
        /// <summary> Provisioning state of the backend http settings resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </summary>
        public string ProvisioningState { get; set; }
    }
}
