// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.AppConfiguration.Models;

namespace Azure.Management.AppConfiguration
{
    internal partial class PrivateLinkResourcesRestClient
    {
        private string subscriptionId;
        private string host;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of PrivateLinkResourcesRestClient. </summary>
        public PrivateLinkResourcesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com", string apiVersion = "2019-11-01-preview")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.host = host;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListByConfigurationStoreRequest(string resourceGroupName, string configStoreName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateLinkResources", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<PrivateLinkResourceListResult>> ListByConfigurationStoreAsync(string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesClient.ListByConfigurationStore");
            scope.Start();
            try
            {
                using var message = CreateListByConfigurationStoreRequest(resourceGroupName, configStoreName);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            PrivateLinkResourceListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = PrivateLinkResourceListResult.DeserializePrivateLinkResourceListResult(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateLinkResourceListResult> ListByConfigurationStore(string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesClient.ListByConfigurationStore");
            scope.Start();
            try
            {
                using var message = CreateListByConfigurationStoreRequest(resourceGroupName, configStoreName);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            PrivateLinkResourceListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = PrivateLinkResourceListResult.DeserializePrivateLinkResourceListResult(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string configStoreName, string groupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateLinkResources/", false);
            uri.AppendPath(groupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets a private link resource that need to be created for a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<PrivateLinkResource>> GetAsync(string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, configStoreName, groupName);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            PrivateLinkResource value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = PrivateLinkResource.DeserializePrivateLinkResource(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a private link resource that need to be created for a configuration store. </summary>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateLinkResource> Get(string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (groupName == null)
            {
                throw new ArgumentNullException(nameof(groupName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, configStoreName, groupName);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            PrivateLinkResource value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = PrivateLinkResource.DeserializePrivateLinkResource(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateListByConfigurationStoreNextPageRequest(string nextLink, string resourceGroupName, string configStoreName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<PrivateLinkResourceListResult>> ListByConfigurationStoreNextPageAsync(string nextLink, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesClient.ListByConfigurationStore");
            scope.Start();
            try
            {
                using var message = CreateListByConfigurationStoreNextPageRequest(nextLink, resourceGroupName, configStoreName);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            PrivateLinkResourceListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = PrivateLinkResourceListResult.DeserializePrivateLinkResourceListResult(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateLinkResourceListResult> ListByConfigurationStoreNextPage(string nextLink, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesClient.ListByConfigurationStore");
            scope.Start();
            try
            {
                using var message = CreateListByConfigurationStoreNextPageRequest(nextLink, resourceGroupName, configStoreName);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            PrivateLinkResourceListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = PrivateLinkResourceListResult.DeserializePrivateLinkResourceListResult(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
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
