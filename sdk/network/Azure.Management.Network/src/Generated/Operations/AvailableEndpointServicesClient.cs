// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    public partial class AvailableEndpointServicesClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal AvailableEndpointServicesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of AvailableEndpointServicesClient for mocking. </summary>
        protected AvailableEndpointServicesClient()
        {
        }
        /// <summary> Initializes a new instance of AvailableEndpointServicesClient. </summary>
        internal AvailableEndpointServicesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            RestClient = new AvailableEndpointServicesRestClient(clientDiagnostics, pipeline, subscriptionId, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> List what values of endpoint services are available for use. </summary>
        /// <param name="location"> The location of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<EndpointServiceResult> ListAsync(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            async Task<Page<EndpointServiceResult>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(location, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<EndpointServiceResult>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List what values of endpoint services are available for use. </summary>
        /// <param name="location"> The location of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<EndpointServiceResult> List(string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Page<EndpointServiceResult> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(location, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<EndpointServiceResult> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
