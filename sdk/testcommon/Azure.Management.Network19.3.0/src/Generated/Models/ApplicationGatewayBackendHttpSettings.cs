// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Backend address pool settings of an application gateway. </summary>
    public partial class ApplicationGatewayBackendHttpSettings : SubResource
    {
        /// <summary> Initializes a new instance of ApplicationGatewayBackendHttpSettings. </summary>
        public ApplicationGatewayBackendHttpSettings()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayBackendHttpSettings. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the backend http settings that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="port"> The destination port on the backend. </param>
        /// <param name="protocol"> The protocol used to communicate with the backend. Possible values are &apos;Http&apos; and &apos;Https&apos;. </param>
        /// <param name="cookieBasedAffinity"> Cookie based affinity. </param>
        /// <param name="requestTimeout"> Request timeout in seconds. Application Gateway will fail the request if response is not received within RequestTimeout. Acceptable values are from 1 second to 86400 seconds. </param>
        /// <param name="probe"> Probe resource of an application gateway. </param>
        /// <param name="authenticationCertificates"> Array of references to application gateway authentication certificates. </param>
        /// <param name="connectionDraining"> Connection draining of the backend http settings resource. </param>
        /// <param name="hostName"> Host header to be sent to the backend servers. </param>
        /// <param name="pickHostNameFromBackendAddress"> Whether to pick host header should be picked from the host name of the backend server. Default value is false. </param>
        /// <param name="affinityCookieName"> Cookie name to use for the affinity cookie. </param>
        /// <param name="probeEnabled"> Whether the probe is enabled. Default value is false. </param>
        /// <param name="path"> Path which should be used as a prefix for all HTTP requests. Null means no path will be prefixed. Default value is null. </param>
        /// <param name="provisioningState"> Provisioning state of the backend http settings resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </param>
        internal ApplicationGatewayBackendHttpSettings(string id, string name, string etag, string type, int? port, ApplicationGatewayProtocol? protocol, ApplicationGatewayCookieBasedAffinity? cookieBasedAffinity, int? requestTimeout, SubResource probe, IList<SubResource> authenticationCertificates, ApplicationGatewayConnectionDraining connectionDraining, string hostName, bool? pickHostNameFromBackendAddress, string affinityCookieName, bool? probeEnabled, string path, string provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            Port = port;
            Protocol = protocol;
            CookieBasedAffinity = cookieBasedAffinity;
            RequestTimeout = requestTimeout;
            Probe = probe;
            AuthenticationCertificates = authenticationCertificates;
            ConnectionDraining = connectionDraining;
            HostName = hostName;
            PickHostNameFromBackendAddress = pickHostNameFromBackendAddress;
            AffinityCookieName = affinityCookieName;
            ProbeEnabled = probeEnabled;
            Path = path;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the backend http settings that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; set; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; set; }
        /// <summary> The destination port on the backend. </summary>
        public int? Port { get; set; }
        /// <summary> The protocol used to communicate with the backend. Possible values are &apos;Http&apos; and &apos;Https&apos;. </summary>
        public ApplicationGatewayProtocol? Protocol { get; set; }
        /// <summary> Cookie based affinity. </summary>
        public ApplicationGatewayCookieBasedAffinity? CookieBasedAffinity { get; set; }
        /// <summary> Request timeout in seconds. Application Gateway will fail the request if response is not received within RequestTimeout. Acceptable values are from 1 second to 86400 seconds. </summary>
        public int? RequestTimeout { get; set; }
        /// <summary> Probe resource of an application gateway. </summary>
        public SubResource Probe { get; set; }
        /// <summary> Array of references to application gateway authentication certificates. </summary>
        public IList<SubResource> AuthenticationCertificates { get; set; }
        /// <summary> Connection draining of the backend http settings resource. </summary>
        public ApplicationGatewayConnectionDraining ConnectionDraining { get; set; }
        /// <summary> Host header to be sent to the backend servers. </summary>
        public string HostName { get; set; }
        /// <summary> Whether to pick host header should be picked from the host name of the backend server. Default value is false. </summary>
        public bool? PickHostNameFromBackendAddress { get; set; }
        /// <summary> Cookie name to use for the affinity cookie. </summary>
        public string AffinityCookieName { get; set; }
        /// <summary> Whether the probe is enabled. Default value is false. </summary>
        public bool? ProbeEnabled { get; set; }
        /// <summary> Path which should be used as a prefix for all HTTP requests. Null means no path will be prefixed. Default value is null. </summary>
        public string Path { get; set; }
        /// <summary> Provisioning state of the backend http settings resource. Possible values are: &apos;Updating&apos;, &apos;Deleting&apos;, and &apos;Failed&apos;. </summary>
        public string ProvisioningState { get; set; }
    }
}
