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
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    public partial class ExpressRoutePortsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ExpressRoutePortsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ExpressRoutePortsClient for mocking. </summary>
        protected ExpressRoutePortsClient()
        {
        }
        /// <summary> Initializes a new instance of ExpressRoutePortsClient. </summary>
        internal ExpressRoutePortsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            RestClient = new ExpressRoutePortsRestClient(clientDiagnostics, pipeline, subscriptionId, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Retrieves the requested ExpressRoutePort resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRoutePort>> GetAsync(string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, expressRoutePortName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves the requested ExpressRoutePort resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRoutePort> Get(string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, expressRoutePortName, cancellationToken);
        }

        /// <summary> Update ExpressRoutePort tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRoutePort>> UpdateTagsAsync(string resourceGroupName, string expressRoutePortName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateTagsAsync(resourceGroupName, expressRoutePortName, tags, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Update ExpressRoutePort tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRoutePort> UpdateTags(string resourceGroupName, string expressRoutePortName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdateTags(resourceGroupName, expressRoutePortName, tags, cancellationToken);
        }

        /// <summary> List all the ExpressRoutePort resources in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRoutePort> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<ExpressRoutePort>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<ExpressRoutePort>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List all the ExpressRoutePort resources in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRoutePort> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<ExpressRoutePort> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<ExpressRoutePort> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListByResourceGroupNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List all the ExpressRoutePort resources in the specified subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRoutePort> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRoutePort>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<ExpressRoutePort>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List all the ExpressRoutePort resources in the specified subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRoutePort> List(CancellationToken cancellationToken = default)
        {
            Page<ExpressRoutePort> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<ExpressRoutePort> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified ExpressRoutePort resource. </summary>
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

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Delete, "ExpressRoutePortsClient.Delete", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> Deletes the specified ExpressRoutePort resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartDeleteAsync(string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }

            var originalResponse = await RestClient.DeleteAsync(resourceGroupName, expressRoutePortName, cancellationToken).ConfigureAwait(false);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, expressRoutePortName));
        }

        /// <summary> Deletes the specified ExpressRoutePort resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartDelete(string resourceGroupName, string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }

            var originalResponse = RestClient.Delete(resourceGroupName, expressRoutePortName, cancellationToken);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, expressRoutePortName));
        }

        /// <summary> Creates or updates the specified ExpressRoutePort resource. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<ExpressRoutePort> CreateCreateOrUpdate(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Put, "ExpressRoutePortsClient.CreateOrUpdate", OperationFinalStateVia.AzureAsyncOperation, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return ExpressRoutePort.DeserializeExpressRoutePort(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return ExpressRoutePort.DeserializeExpressRoutePort(document.RootElement);
            });
        }

        /// <summary> Creates or updates the specified ExpressRoutePort resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="parameters"> Parameters supplied to the create ExpressRoutePort operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<ExpressRoutePort>> StartCreateOrUpdateAsync(string resourceGroupName, string expressRoutePortName, ExpressRoutePort parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, expressRoutePortName, parameters, cancellationToken).ConfigureAwait(false);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, expressRoutePortName, parameters));
        }

        /// <summary> Creates or updates the specified ExpressRoutePort resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="parameters"> Parameters supplied to the create ExpressRoutePort operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<ExpressRoutePort> StartCreateOrUpdate(string resourceGroupName, string expressRoutePortName, ExpressRoutePort parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRoutePortName == null)
            {
                throw new ArgumentNullException(nameof(expressRoutePortName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, expressRoutePortName, parameters, cancellationToken);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, expressRoutePortName, parameters));
        }
    }
}
