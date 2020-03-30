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
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    internal partial class VirtualNetworkPeeringsRestClient
    {
        private string subscriptionId;
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;

        /// <summary> Initializes a new instance of VirtualNetworkPeeringsRestClient. </summary>
        public VirtualNetworkPeeringsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
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

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName)
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
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworks/", false);
            uri.AppendPath(virtualNetworkName, true);
            uri.AppendPath("/virtualNetworkPeerings/", false);
            uri.AppendPath(virtualNetworkPeeringName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the specified virtual network peering. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
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

        /// <summary> Deletes the specified virtual network peering. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
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

        internal HttpMessage CreateGetRequest(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName)
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
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworks/", false);
            uri.AppendPath(virtualNetworkName, true);
            uri.AppendPath("/virtualNetworkPeerings/", false);
            uri.AppendPath(virtualNetworkPeeringName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the specified virtual network peering. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<VirtualNetworkPeering>> GetAsync(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            VirtualNetworkPeering value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = VirtualNetworkPeering.DeserializeVirtualNetworkPeering(document.RootElement);
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

        /// <summary> Gets the specified virtual network peering. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<VirtualNetworkPeering> Get(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            VirtualNetworkPeering value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = VirtualNetworkPeering.DeserializeVirtualNetworkPeering(document.RootElement);
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

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, VirtualNetworkPeering virtualNetworkPeeringParameters)
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
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworks/", false);
            uri.AppendPath(virtualNetworkName, true);
            uri.AppendPath("/virtualNetworkPeerings/", false);
            uri.AppendPath(virtualNetworkPeeringName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(virtualNetworkPeeringParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a peering in the specified virtual network. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="virtualNetworkPeeringParameters"> Parameters supplied to the create or update virtual network peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> CreateOrUpdateAsync(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, VirtualNetworkPeering virtualNetworkPeeringParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }
            if (virtualNetworkPeeringParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringParameters));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, virtualNetworkPeeringParameters);
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

        /// <summary> Creates or updates a peering in the specified virtual network. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="virtualNetworkPeeringName"> The name of the virtual network peering. </param>
        /// <param name="virtualNetworkPeeringParameters"> Parameters supplied to the create or update virtual network peering operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string virtualNetworkName, string virtualNetworkPeeringName, VirtualNetworkPeering virtualNetworkPeeringParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (virtualNetworkPeeringName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringName));
            }
            if (virtualNetworkPeeringParameters == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkPeeringParameters));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(resourceGroupName, virtualNetworkName, virtualNetworkPeeringName, virtualNetworkPeeringParameters);
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

        internal HttpMessage CreateListRequest(string resourceGroupName, string virtualNetworkName)
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
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworks/", false);
            uri.AppendPath(virtualNetworkName, true);
            uri.AppendPath("/virtualNetworkPeerings", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all virtual network peerings in a virtual network. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<VirtualNetworkPeeringListResult>> ListAsync(string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(resourceGroupName, virtualNetworkName);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            VirtualNetworkPeeringListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = VirtualNetworkPeeringListResult.DeserializeVirtualNetworkPeeringListResult(document.RootElement);
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

        /// <summary> Gets all virtual network peerings in a virtual network. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<VirtualNetworkPeeringListResult> List(string resourceGroupName, string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(resourceGroupName, virtualNetworkName);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            VirtualNetworkPeeringListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = VirtualNetworkPeeringListResult.DeserializeVirtualNetworkPeeringListResult(document.RootElement);
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

        /// <summary> Gets all virtual network peerings in a virtual network. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<VirtualNetworkPeeringListResult>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.List");
            scope.Start();
            try
            {
                using var message = CreateListNextPageRequest(nextLink);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            VirtualNetworkPeeringListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = VirtualNetworkPeeringListResult.DeserializeVirtualNetworkPeeringListResult(document.RootElement);
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

        /// <summary> Gets all virtual network peerings in a virtual network. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<VirtualNetworkPeeringListResult> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("VirtualNetworkPeeringsClient.List");
            scope.Start();
            try
            {
                using var message = CreateListNextPageRequest(nextLink);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            VirtualNetworkPeeringListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = VirtualNetworkPeeringListResult.DeserializeVirtualNetworkPeeringListResult(document.RootElement);
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
