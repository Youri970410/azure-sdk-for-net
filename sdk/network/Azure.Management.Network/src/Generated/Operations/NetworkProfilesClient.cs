// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    public partial class NetworkProfilesClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal NetworkProfilesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of NetworkProfilesClient for mocking. </summary>
        protected NetworkProfilesClient()
        {
        }
        /// <summary> Initializes a new instance of NetworkProfilesClient. </summary>
        internal NetworkProfilesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            RestClient = new NetworkProfilesRestClient(clientDiagnostics, pipeline, subscriptionId, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Gets the specified network profile in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkProfile>> GetAsync(string resourceGroupName, string networkProfileName, string expand, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, networkProfileName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets the specified network profile in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkProfile> Get(string resourceGroupName, string networkProfileName, string expand, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, networkProfileName, expand, cancellationToken);
        }

        /// <summary> Creates or updates a network profile. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network profile operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkProfile>> CreateOrUpdateAsync(string resourceGroupName, string networkProfileName, NetworkProfile parameters, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateOrUpdateAsync(resourceGroupName, networkProfileName, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates or updates a network profile. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="parameters"> Parameters supplied to the create or update network profile operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkProfile> CreateOrUpdate(string resourceGroupName, string networkProfileName, NetworkProfile parameters, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateOrUpdate(resourceGroupName, networkProfileName, parameters, cancellationToken);
        }

        /// <summary> Updates network profile tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkProfile>> UpdateTagsAsync(string resourceGroupName, string networkProfileName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateTagsAsync(resourceGroupName, networkProfileName, tags, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates network profile tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkProfile> UpdateTags(string resourceGroupName, string networkProfileName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdateTags(resourceGroupName, networkProfileName, tags, cancellationToken);
        }

        /// <summary> Gets all the network profiles in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkProfile> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkProfile>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<NetworkProfile>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the network profiles in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkProfile> ListAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkProfile> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListAll(cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<NetworkProfile> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network profiles in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<NetworkProfile> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<NetworkProfile>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<NetworkProfile>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all network profiles in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<NetworkProfile> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<NetworkProfile> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(resourceGroupName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<NetworkProfile> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified network profile. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Response> CreateDelete(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Delete, "NetworkProfilesClient.Delete", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> Deletes the specified network profile. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartDeleteAsync(string resourceGroupName, string networkProfileName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkProfileName == null)
            {
                throw new ArgumentNullException(nameof(networkProfileName));
            }

            var originalResponse = await RestClient.DeleteAsync(resourceGroupName, networkProfileName, cancellationToken).ConfigureAwait(false);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, networkProfileName));
        }

        /// <summary> Deletes the specified network profile. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkProfileName"> The name of the NetworkProfile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartDelete(string resourceGroupName, string networkProfileName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkProfileName == null)
            {
                throw new ArgumentNullException(nameof(networkProfileName));
            }

            var originalResponse = RestClient.Delete(resourceGroupName, networkProfileName, cancellationToken);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, networkProfileName));
        }
    }
}
