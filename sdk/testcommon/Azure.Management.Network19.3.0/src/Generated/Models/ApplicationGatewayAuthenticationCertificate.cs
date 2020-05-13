// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Network.Models
{
    /// <summary> Authentication certificates of an application gateway. </summary>
    public partial class ApplicationGatewayAuthenticationCertificate : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayAuthenticationCertificate. </summary>
        public ApplicationGatewayAuthenticationCertificate()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayAuthenticationCertificate. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the authentication certificate that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="data"> Certificate public data. </param>
        /// <param name="provisioningState"> Provisioning state of the authentication certificate resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </param>
        internal ApplicationGatewayAuthenticationCertificate(string id, string name, string etag, string type, string data, string provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            Data = data;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the authentication certificate that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; set; }
        /// <summary> Certificate public data. </summary>
        public string Data { get; set; }
        /// <summary> Provisioning state of the authentication certificate resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </summary>
        public string ProvisioningState { get; set; }
    }
}
