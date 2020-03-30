// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network;
using Azure.Management.Network.Models;

namespace Azure.Template
{
    public partial class TemplateClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of TemplateClient for mocking. </summary>
        protected TemplateClient()
        {
        }
        /// <summary> Initializes a new instance of TemplateClient. </summary>
        internal TemplateClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, subscriptionId, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Checks whether a domain name in the cloudapp.azure.com zone is available for use. </summary>
        /// <param name="location"> The location of the subnet. </param>
        /// <param name="domainNameLabel"> The domain name to be verified. It must conform to the following regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DnsNameAvailabilityResult>> CheckDnsNameAvailabilityAsync(string location, string domainNameLabel, CancellationToken cancellationToken = default)
        {
            return await RestClient.CheckDnsNameAvailabilityAsync(location, domainNameLabel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Checks whether a domain name in the cloudapp.azure.com zone is available for use. </summary>
        /// <param name="location"> The location of the subnet. </param>
        /// <param name="domainNameLabel"> The domain name to be verified. It must conform to the following regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DnsNameAvailabilityResult> CheckDnsNameAvailability(string location, string domainNameLabel, CancellationToken cancellationToken = default)
        {
            return RestClient.CheckDnsNameAvailability(location, domainNameLabel, cancellationToken);
        }

        /// <summary> Gives the supported security providers for the virtual wan. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN for which configuration of all vpn-sites is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualWanSecurityProviders>> SupportedSecurityProvidersAsync(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            return await RestClient.SupportedSecurityProvidersAsync(resourceGroupName, virtualWANName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gives the supported security providers for the virtual wan. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN for which configuration of all vpn-sites is needed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualWanSecurityProviders> SupportedSecurityProviders(string resourceGroupName, string virtualWANName, CancellationToken cancellationToken = default)
        {
            return RestClient.SupportedSecurityProviders(resourceGroupName, virtualWANName, cancellationToken);
        }

        /// <summary> Return the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="vms"> List of VM references. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<BastionShareableLink> GetBastionShareableLinkAsync(string resourceGroupName, string bastionHostName, IEnumerable<BastionShareableLink> vms, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            async Task<Page<BastionShareableLink>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.GetBastionShareableLinkAsync(resourceGroupName, bastionHostName, vms, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<BastionShareableLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.GetBastionShareableLinkNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Return the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="vms"> List of VM references. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<BastionShareableLink> GetBastionShareableLink(string resourceGroupName, string bastionHostName, IEnumerable<BastionShareableLink> vms, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            Page<BastionShareableLink> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.GetBastionShareableLink(resourceGroupName, bastionHostName, vms, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<BastionShareableLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.GetBastionShareableLinkNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="sessionIds"> List of session IDs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<BastionSessionState> DisconnectActiveSessionsAsync(string resourceGroupName, string bastionHostName, IEnumerable<string> sessionIds, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            async Task<Page<BastionSessionState>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.DisconnectActiveSessionsAsync(resourceGroupName, bastionHostName, sessionIds, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<BastionSessionState>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.DisconnectActiveSessionsNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="sessionIds"> List of session IDs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<BastionSessionState> DisconnectActiveSessions(string resourceGroupName, string bastionHostName, IEnumerable<string> sessionIds, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            Page<BastionSessionState> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.DisconnectActiveSessions(resourceGroupName, bastionHostName, sessionIds, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<BastionSessionState> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.DisconnectActiveSessionsNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates a Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<BastionShareableLinkListResult> CreatePutBastionShareableLink(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "ServiceClient.PutBastionShareableLink", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return BastionShareableLinkListResult.DeserializeBastionShareableLinkListResult(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return BastionShareableLinkListResult.DeserializeBastionShareableLinkListResult(document.RootElement);
            });
        }

        /// <summary> Creates a Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="vms"> List of VM references. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<BastionShareableLinkListResult>> StartPutBastionShareableLinkAsync(string resourceGroupName, string bastionHostName, IEnumerable<BastionShareableLink> vms, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            var originalResponse = await RestClient.PutBastionShareableLinkAsync(resourceGroupName, bastionHostName, vms, cancellationToken).ConfigureAwait(false);
            return CreatePutBastionShareableLink(originalResponse, () => RestClient.CreatePutBastionShareableLinkRequest(resourceGroupName, bastionHostName, vms));
        }

        /// <summary> Creates a Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="vms"> List of VM references. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<BastionShareableLinkListResult> StartPutBastionShareableLink(string resourceGroupName, string bastionHostName, IEnumerable<BastionShareableLink> vms, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            var originalResponse = RestClient.PutBastionShareableLink(resourceGroupName, bastionHostName, vms, cancellationToken);
            return CreatePutBastionShareableLink(originalResponse, () => RestClient.CreatePutBastionShareableLinkRequest(resourceGroupName, bastionHostName, vms));
        }

        /// <summary> Deletes the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Response> CreateDeleteBastionShareableLink(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "ServiceClient.DeleteBastionShareableLink", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> Deletes the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="vms"> List of VM references. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartDeleteBastionShareableLinkAsync(string resourceGroupName, string bastionHostName, IEnumerable<BastionShareableLink> vms, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            var originalResponse = await RestClient.DeleteBastionShareableLinkAsync(resourceGroupName, bastionHostName, vms, cancellationToken).ConfigureAwait(false);
            return CreateDeleteBastionShareableLink(originalResponse, () => RestClient.CreateDeleteBastionShareableLinkRequest(resourceGroupName, bastionHostName, vms));
        }

        /// <summary> Deletes the Bastion Shareable Links for all the VMs specified in the request. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="vms"> List of VM references. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartDeleteBastionShareableLink(string resourceGroupName, string bastionHostName, IEnumerable<BastionShareableLink> vms, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            var originalResponse = RestClient.DeleteBastionShareableLink(resourceGroupName, bastionHostName, vms, cancellationToken);
            return CreateDeleteBastionShareableLink(originalResponse, () => RestClient.CreateDeleteBastionShareableLinkRequest(resourceGroupName, bastionHostName, vms));
        }

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<BastionActiveSessionListResult> CreateGetActiveSessions(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "ServiceClient.GetActiveSessions", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return BastionActiveSessionListResult.DeserializeBastionActiveSessionListResult(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return BastionActiveSessionListResult.DeserializeBastionActiveSessionListResult(document.RootElement);
            });
        }

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<BastionActiveSessionListResult>> StartGetActiveSessionsAsync(string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            var originalResponse = await RestClient.GetActiveSessionsAsync(resourceGroupName, bastionHostName, cancellationToken).ConfigureAwait(false);
            return CreateGetActiveSessions(originalResponse, () => RestClient.CreateGetActiveSessionsRequest(resourceGroupName, bastionHostName));
        }

        /// <summary> Returns the list of currently active sessions on the Bastion. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="bastionHostName"> The name of the Bastion Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<BastionActiveSessionListResult> StartGetActiveSessions(string resourceGroupName, string bastionHostName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (bastionHostName == null)
            {
                throw new ArgumentNullException(nameof(bastionHostName));
            }

            var originalResponse = RestClient.GetActiveSessions(resourceGroupName, bastionHostName, cancellationToken);
            return CreateGetActiveSessions(originalResponse, () => RestClient.CreateGetActiveSessionsRequest(resourceGroupName, bastionHostName));
        }

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<VpnProfileResponse> CreateGeneratevirtualwanvpnserverconfigurationvpnprofile(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "ServiceClient.Generatevirtualwanvpnserverconfigurationvpnprofile", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return VpnProfileResponse.DeserializeVpnProfileResponse(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return VpnProfileResponse.DeserializeVpnProfileResponse(document.RootElement);
            });
        }

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN for which configuration of all vpn-sites is needed. </param>
        /// <param name="vpnServerConfigurationResourceId"> VpnServerConfiguration partial resource uri with which VirtualWan is associated to. </param>
        /// <param name="authenticationMethod"> VPN client authentication method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<VpnProfileResponse>> StartGeneratevirtualwanvpnserverconfigurationvpnprofileAsync(string resourceGroupName, string virtualWANName, string vpnServerConfigurationResourceId, AuthenticationMethod? authenticationMethod, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }

            var originalResponse = await RestClient.GeneratevirtualwanvpnserverconfigurationvpnprofileAsync(resourceGroupName, virtualWANName, vpnServerConfigurationResourceId, authenticationMethod, cancellationToken).ConfigureAwait(false);
            return CreateGeneratevirtualwanvpnserverconfigurationvpnprofile(originalResponse, () => RestClient.CreateGeneratevirtualwanvpnserverconfigurationvpnprofileRequest(resourceGroupName, virtualWANName, vpnServerConfigurationResourceId, authenticationMethod));
        }

        /// <summary> Generates a unique VPN profile for P2S clients for VirtualWan and associated VpnServerConfiguration combination in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualWANName"> The name of the VirtualWAN for which configuration of all vpn-sites is needed. </param>
        /// <param name="vpnServerConfigurationResourceId"> VpnServerConfiguration partial resource uri with which VirtualWan is associated to. </param>
        /// <param name="authenticationMethod"> VPN client authentication method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<VpnProfileResponse> StartGeneratevirtualwanvpnserverconfigurationvpnprofile(string resourceGroupName, string virtualWANName, string vpnServerConfigurationResourceId, AuthenticationMethod? authenticationMethod, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }

            var originalResponse = RestClient.Generatevirtualwanvpnserverconfigurationvpnprofile(resourceGroupName, virtualWANName, vpnServerConfigurationResourceId, authenticationMethod, cancellationToken);
            return CreateGeneratevirtualwanvpnserverconfigurationvpnprofile(originalResponse, () => RestClient.CreateGeneratevirtualwanvpnserverconfigurationvpnprofileRequest(resourceGroupName, virtualWANName, vpnServerConfigurationResourceId, authenticationMethod));
        }
    }
}
