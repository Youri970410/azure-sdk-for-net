// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Application gateway BackendHealthHttp settings. </summary>
    public partial class ApplicationGatewayBackendHealthHttpSettings
    {
        /// <summary> Initializes a new instance of ApplicationGatewayBackendHealthHttpSettings. </summary>
        internal ApplicationGatewayBackendHealthHttpSettings()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayBackendHealthHttpSettings. </summary>
        /// <param name="backendHttpSettings"> Reference of an ApplicationGatewayBackendHttpSettings resource. </param>
        /// <param name="servers"> List of ApplicationGatewayBackendHealthServer resources. </param>
        internal ApplicationGatewayBackendHealthHttpSettings(ApplicationGatewayBackendHttpSettings backendHttpSettings, IReadOnlyList<ApplicationGatewayBackendHealthServer> servers)
        {
            BackendHttpSettings = backendHttpSettings;
            Servers = servers;
        }

        /// <summary> Reference of an ApplicationGatewayBackendHttpSettings resource. </summary>
        public ApplicationGatewayBackendHttpSettings BackendHttpSettings { get; }
        /// <summary> List of ApplicationGatewayBackendHealthServer resources. </summary>
        public IReadOnlyList<ApplicationGatewayBackendHealthServer> Servers { get; }
    }
}
