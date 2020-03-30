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
    public partial class ExpressRouteCircuitsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ExpressRouteCircuitsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ExpressRouteCircuitsClient for mocking. </summary>
        protected ExpressRouteCircuitsClient()
        {
        }
        /// <summary> Initializes a new instance of ExpressRouteCircuitsClient. </summary>
        internal ExpressRouteCircuitsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            RestClient = new ExpressRouteCircuitsRestClient(clientDiagnostics, pipeline, subscriptionId, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Gets information about the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCircuit>> GetAsync(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, circuitName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets information about the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuit> Get(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, circuitName, cancellationToken);
        }

        /// <summary> Updates an express route circuit tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCircuit>> UpdateTagsAsync(string resourceGroupName, string circuitName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateTagsAsync(resourceGroupName, circuitName, tags, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates an express route circuit tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuit> UpdateTags(string resourceGroupName, string circuitName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdateTags(resourceGroupName, circuitName, tags, cancellationToken);
        }

        /// <summary> Gets all the stats from an express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCircuitStats>> GetStatsAsync(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetStatsAsync(resourceGroupName, circuitName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets all the stats from an express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitStats> GetStats(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            return RestClient.GetStats(resourceGroupName, circuitName, cancellationToken);
        }

        /// <summary> Gets all stats from an express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteCircuitStats>> GetPeeringStatsAsync(string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetPeeringStatsAsync(resourceGroupName, circuitName, peeringName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets all stats from an express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteCircuitStats> GetPeeringStats(string resourceGroupName, string circuitName, string peeringName, CancellationToken cancellationToken = default)
        {
            return RestClient.GetPeeringStats(resourceGroupName, circuitName, peeringName, cancellationToken);
        }

        /// <summary> Gets all the express route circuits in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRouteCircuit> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<ExpressRouteCircuit>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<ExpressRouteCircuit>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the express route circuits in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRouteCircuit> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<ExpressRouteCircuit> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(resourceGroupName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<ExpressRouteCircuit> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the express route circuits in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ExpressRouteCircuit> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCircuit>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<ExpressRouteCircuit>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the express route circuits in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ExpressRouteCircuit> ListAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCircuit> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListAll(cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<ExpressRouteCircuit> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified express route circuit. </summary>
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

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Delete, "ExpressRouteCircuitsClient.Delete", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> Deletes the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartDeleteAsync(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            var originalResponse = await RestClient.DeleteAsync(resourceGroupName, circuitName, cancellationToken).ConfigureAwait(false);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, circuitName));
        }

        /// <summary> Deletes the specified express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartDelete(string resourceGroupName, string circuitName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }

            var originalResponse = RestClient.Delete(resourceGroupName, circuitName, cancellationToken);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, circuitName));
        }

        /// <summary> Creates or updates an express route circuit. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<ExpressRouteCircuit> CreateCreateOrUpdate(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Put, "ExpressRouteCircuitsClient.CreateOrUpdate", OperationFinalStateVia.AzureAsyncOperation, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return ExpressRouteCircuit.DeserializeExpressRouteCircuit(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return ExpressRouteCircuit.DeserializeExpressRouteCircuit(document.RootElement);
            });
        }

        /// <summary> Creates or updates an express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="parameters"> Parameters supplied to the create or update express route circuit operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<ExpressRouteCircuit>> StartCreateOrUpdateAsync(string resourceGroupName, string circuitName, ExpressRouteCircuit parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, circuitName, parameters, cancellationToken).ConfigureAwait(false);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, circuitName, parameters));
        }

        /// <summary> Creates or updates an express route circuit. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="parameters"> Parameters supplied to the create or update express route circuit operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<ExpressRouteCircuit> StartCreateOrUpdate(string resourceGroupName, string circuitName, ExpressRouteCircuit parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, circuitName, parameters, cancellationToken);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, circuitName, parameters));
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route circuit in a resource group. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<ExpressRouteCircuitsArpTableListResult> CreateListArpTable(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "ExpressRouteCircuitsClient.ListArpTable", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return ExpressRouteCircuitsArpTableListResult.DeserializeExpressRouteCircuitsArpTableListResult(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return ExpressRouteCircuitsArpTableListResult.DeserializeExpressRouteCircuitsArpTableListResult(document.RootElement);
            });
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<ExpressRouteCircuitsArpTableListResult>> StartListArpTableAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            var originalResponse = await RestClient.ListArpTableAsync(resourceGroupName, circuitName, peeringName, devicePath, cancellationToken).ConfigureAwait(false);
            return CreateListArpTable(originalResponse, () => RestClient.CreateListArpTableRequest(resourceGroupName, circuitName, peeringName, devicePath));
        }

        /// <summary> Gets the currently advertised ARP table associated with the express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<ExpressRouteCircuitsArpTableListResult> StartListArpTable(string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            var originalResponse = RestClient.ListArpTable(resourceGroupName, circuitName, peeringName, devicePath, cancellationToken);
            return CreateListArpTable(originalResponse, () => RestClient.CreateListArpTableRequest(resourceGroupName, circuitName, peeringName, devicePath));
        }

        /// <summary> Gets the currently advertised routes table associated with the express route circuit in a resource group. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<ExpressRouteCircuitsRoutesTableListResult> CreateListRoutesTable(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "ExpressRouteCircuitsClient.ListRoutesTable", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return ExpressRouteCircuitsRoutesTableListResult.DeserializeExpressRouteCircuitsRoutesTableListResult(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return ExpressRouteCircuitsRoutesTableListResult.DeserializeExpressRouteCircuitsRoutesTableListResult(document.RootElement);
            });
        }

        /// <summary> Gets the currently advertised routes table associated with the express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<ExpressRouteCircuitsRoutesTableListResult>> StartListRoutesTableAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            var originalResponse = await RestClient.ListRoutesTableAsync(resourceGroupName, circuitName, peeringName, devicePath, cancellationToken).ConfigureAwait(false);
            return CreateListRoutesTable(originalResponse, () => RestClient.CreateListRoutesTableRequest(resourceGroupName, circuitName, peeringName, devicePath));
        }

        /// <summary> Gets the currently advertised routes table associated with the express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<ExpressRouteCircuitsRoutesTableListResult> StartListRoutesTable(string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            var originalResponse = RestClient.ListRoutesTable(resourceGroupName, circuitName, peeringName, devicePath, cancellationToken);
            return CreateListRoutesTable(originalResponse, () => RestClient.CreateListRoutesTableRequest(resourceGroupName, circuitName, peeringName, devicePath));
        }

        /// <summary> Gets the currently advertised routes table summary associated with the express route circuit in a resource group. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<ExpressRouteCircuitsRoutesTableSummaryListResult> CreateListRoutesTableSummary(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Post, "ExpressRouteCircuitsClient.ListRoutesTableSummary", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return ExpressRouteCircuitsRoutesTableSummaryListResult.DeserializeExpressRouteCircuitsRoutesTableSummaryListResult(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return ExpressRouteCircuitsRoutesTableSummaryListResult.DeserializeExpressRouteCircuitsRoutesTableSummaryListResult(document.RootElement);
            });
        }

        /// <summary> Gets the currently advertised routes table summary associated with the express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<ExpressRouteCircuitsRoutesTableSummaryListResult>> StartListRoutesTableSummaryAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            var originalResponse = await RestClient.ListRoutesTableSummaryAsync(resourceGroupName, circuitName, peeringName, devicePath, cancellationToken).ConfigureAwait(false);
            return CreateListRoutesTableSummary(originalResponse, () => RestClient.CreateListRoutesTableSummaryRequest(resourceGroupName, circuitName, peeringName, devicePath));
        }

        /// <summary> Gets the currently advertised routes table summary associated with the express route circuit in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="circuitName"> The name of the express route circuit. </param>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="devicePath"> The path of the device. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<ExpressRouteCircuitsRoutesTableSummaryListResult> StartListRoutesTableSummary(string resourceGroupName, string circuitName, string peeringName, string devicePath, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (circuitName == null)
            {
                throw new ArgumentNullException(nameof(circuitName));
            }
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (devicePath == null)
            {
                throw new ArgumentNullException(nameof(devicePath));
            }

            var originalResponse = RestClient.ListRoutesTableSummary(resourceGroupName, circuitName, peeringName, devicePath, cancellationToken);
            return CreateListRoutesTableSummary(originalResponse, () => RestClient.CreateListRoutesTableSummaryRequest(resourceGroupName, circuitName, peeringName, devicePath));
        }
    }
}
