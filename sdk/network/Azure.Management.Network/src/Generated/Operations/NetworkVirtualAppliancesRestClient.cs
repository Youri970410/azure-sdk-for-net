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
    internal partial class NetworkVirtualAppliancesRestClient
    {
        private string subscriptionId;
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;

        /// <summary> Initializes a new instance of NetworkVirtualAppliancesRestClient. </summary>
        public NetworkVirtualAppliancesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.subscriptionId = subscriptionId;
            this.host = host;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string networkVirtualApplianceName)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkVirtualAppliances/", false);
            uri.AppendPath(networkVirtualApplianceName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string resourceGroupName, string networkVirtualApplianceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(resourceGroupName, networkVirtualApplianceName);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 202:
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string networkVirtualApplianceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(resourceGroupName, networkVirtualApplianceName);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 202:
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string networkVirtualApplianceName, string expand)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkVirtualAppliances/", false);
            uri.AppendPath(networkVirtualApplianceName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<NetworkVirtualAppliance>> GetAsync(string resourceGroupName, string networkVirtualApplianceName, string expand, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, networkVirtualApplianceName, expand);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualAppliance value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = NetworkVirtualAppliance.DeserializeNetworkVirtualAppliance(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands BackendAddressPool and BackendHttpSettings referenced in backend health. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<NetworkVirtualAppliance> Get(string resourceGroupName, string networkVirtualApplianceName, string expand, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, networkVirtualApplianceName, expand);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualAppliance value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = NetworkVirtualAppliance.DeserializeNetworkVirtualAppliance(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateUpdateTagsRequest(string resourceGroupName, string networkVirtualApplianceName, IDictionary<string, string> tags)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkVirtualAppliances/", false);
            uri.AppendPath(networkVirtualApplianceName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var model = new TagsObject(tags);
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Updates a Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<NetworkVirtualAppliance>> UpdateTagsAsync(string resourceGroupName, string networkVirtualApplianceName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.UpdateTags");
            scope.Start();
            try
            {
                using var message = CreateUpdateTagsRequest(resourceGroupName, networkVirtualApplianceName, tags);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualAppliance value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = NetworkVirtualAppliance.DeserializeNetworkVirtualAppliance(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<NetworkVirtualAppliance> UpdateTags(string resourceGroupName, string networkVirtualApplianceName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.UpdateTags");
            scope.Start();
            try
            {
                using var message = CreateUpdateTagsRequest(resourceGroupName, networkVirtualApplianceName, tags);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualAppliance value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = NetworkVirtualAppliance.DeserializeNetworkVirtualAppliance(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkVirtualAppliances/", false);
            uri.AppendPath(networkVirtualApplianceName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> CreateOrUpdateAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(resourceGroupName, networkVirtualApplianceName, parameters);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 201:
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(resourceGroupName, networkVirtualApplianceName, parameters);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 201:
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string resourceGroupName)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkVirtualAppliances", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all Network Virtual Appliances in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<NetworkVirtualApplianceListResult>> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.ListByResourceGroup");
            scope.Start();
            try
            {
                using var message = CreateListByResourceGroupRequest(resourceGroupName);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualApplianceListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = NetworkVirtualApplianceListResult.DeserializeNetworkVirtualApplianceListResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Network Virtual Appliances in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<NetworkVirtualApplianceListResult> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.ListByResourceGroup");
            scope.Start();
            try
            {
                using var message = CreateListByResourceGroupRequest(resourceGroupName);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualApplianceListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = NetworkVirtualApplianceListResult.DeserializeNetworkVirtualApplianceListResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateListRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Network/networkVirtualAppliances", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all Network Virtual Appliances in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<NetworkVirtualApplianceListResult>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualApplianceListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = NetworkVirtualApplianceListResult.DeserializeNetworkVirtualApplianceListResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all Network Virtual Appliances in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<NetworkVirtualApplianceListResult> List(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualApplianceListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = NetworkVirtualApplianceListResult.DeserializeNetworkVirtualApplianceListResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateListByResourceGroupNextPageRequest(string nextLink)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Lists all Network Virtual Appliances in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<NetworkVirtualApplianceListResult>> ListByResourceGroupNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.ListByResourceGroup");
            scope.Start();
            try
            {
                using var message = CreateListByResourceGroupNextPageRequest(nextLink);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualApplianceListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = NetworkVirtualApplianceListResult.DeserializeNetworkVirtualApplianceListResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Network Virtual Appliances in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<NetworkVirtualApplianceListResult> ListByResourceGroupNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.ListByResourceGroup");
            scope.Start();
            try
            {
                using var message = CreateListByResourceGroupNextPageRequest(nextLink);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualApplianceListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = NetworkVirtualApplianceListResult.DeserializeNetworkVirtualApplianceListResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all Network Virtual Appliances in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<NetworkVirtualApplianceListResult>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.List");
            scope.Start();
            try
            {
                using var message = CreateListNextPageRequest(nextLink);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualApplianceListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = NetworkVirtualApplianceListResult.DeserializeNetworkVirtualApplianceListResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all Network Virtual Appliances in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<NetworkVirtualApplianceListResult> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("NetworkVirtualAppliancesClient.List");
            scope.Start();
            try
            {
                using var message = CreateListNextPageRequest(nextLink);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            NetworkVirtualApplianceListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = NetworkVirtualApplianceListResult.DeserializeNetworkVirtualApplianceListResult(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
