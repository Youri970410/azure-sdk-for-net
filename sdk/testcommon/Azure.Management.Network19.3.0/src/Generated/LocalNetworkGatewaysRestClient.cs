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
    internal partial class LocalNetworkGatewaysRestClient
    {
        private string subscriptionId;
        private string host;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of LocalNetworkGatewaysRestClient. </summary>
        public LocalNetworkGatewaysRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
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
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/localNetworkGateways/", false);
            uri.AppendPath(localNetworkGatewayName, true);
            uri.AppendQuery("api-version", "2018-07-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a local network gateway in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update local network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> CreateOrUpdateAsync(string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, localNetworkGatewayName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a local network gateway in the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update local network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string localNetworkGatewayName, LocalNetworkGateway parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, localNetworkGatewayName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string localNetworkGatewayName)
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
            uri.AppendPath("/providers/Microsoft.Network/localNetworkGateways/", false);
            uri.AppendPath(localNetworkGatewayName, true);
            uri.AppendQuery("api-version", "2018-07-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the specified local network gateway in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<LocalNetworkGateway>> GetAsync(string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }

            using var message = CreateGetRequest(resourceGroupName, localNetworkGatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LocalNetworkGateway value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = LocalNetworkGateway.DeserializeLocalNetworkGateway(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified local network gateway in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<LocalNetworkGateway> Get(string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }

            using var message = CreateGetRequest(resourceGroupName, localNetworkGatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LocalNetworkGateway value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = LocalNetworkGateway.DeserializeLocalNetworkGateway(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string localNetworkGatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/localNetworkGateways/", false);
            uri.AppendPath(localNetworkGatewayName, true);
            uri.AppendQuery("api-version", "2018-07-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the specified local network gateway. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, localNetworkGatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified local network gateway. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, localNetworkGatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateTagsRequest(string resourceGroupName, string localNetworkGatewayName, TagsObject parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/localNetworkGateways/", false);
            uri.AppendPath(localNetworkGatewayName, true);
            uri.AppendQuery("api-version", "2018-07-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Updates a local network gateway tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="parameters"> Parameters supplied to update local network gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> UpdateTagsAsync(string resourceGroupName, string localNetworkGatewayName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateUpdateTagsRequest(resourceGroupName, localNetworkGatewayName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates a local network gateway tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="parameters"> Parameters supplied to update local network gateway tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response UpdateTags(string resourceGroupName, string localNetworkGatewayName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (localNetworkGatewayName == null)
            {
                throw new ArgumentNullException(nameof(localNetworkGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateUpdateTagsRequest(resourceGroupName, localNetworkGatewayName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string resourceGroupName)
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
            uri.AppendPath("/providers/Microsoft.Network/localNetworkGateways", false);
            uri.AppendQuery("api-version", "2018-07-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all the local network gateways in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<LocalNetworkGatewayListResult>> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LocalNetworkGatewayListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = LocalNetworkGatewayListResult.DeserializeLocalNetworkGatewayListResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the local network gateways in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<LocalNetworkGatewayListResult> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LocalNetworkGatewayListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = LocalNetworkGatewayListResult.DeserializeLocalNetworkGatewayListResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceGroupName)
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

        /// <summary> Gets all the local network gateways in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<LocalNetworkGatewayListResult>> ListNextPageAsync(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LocalNetworkGatewayListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = LocalNetworkGatewayListResult.DeserializeLocalNetworkGatewayListResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all the local network gateways in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<LocalNetworkGatewayListResult> ListNextPage(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListNextPageRequest(nextLink, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LocalNetworkGatewayListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = LocalNetworkGatewayListResult.DeserializeLocalNetworkGatewayListResult(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
