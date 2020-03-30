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
    internal partial class ApplicationSecurityGroupsRestClient
    {
        private string subscriptionId;
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;

        /// <summary> Initializes a new instance of ApplicationSecurityGroupsRestClient. </summary>
        public ApplicationSecurityGroupsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
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

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string applicationSecurityGroupName)
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
            uri.AppendPath("/providers/Microsoft.Network/applicationSecurityGroups/", false);
            uri.AppendPath(applicationSecurityGroupName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Deletes the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(resourceGroupName, applicationSecurityGroupName);
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

        /// <summary> Deletes the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(resourceGroupName, applicationSecurityGroupName);
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

        internal HttpMessage CreateGetRequest(string resourceGroupName, string applicationSecurityGroupName)
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
            uri.AppendPath("/providers/Microsoft.Network/applicationSecurityGroups/", false);
            uri.AppendPath(applicationSecurityGroupName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ApplicationSecurityGroup>> GetAsync(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, applicationSecurityGroupName);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroup value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(document.RootElement);
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

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ApplicationSecurityGroup> Get(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(resourceGroupName, applicationSecurityGroupName);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroup value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(document.RootElement);
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

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string applicationSecurityGroupName, ApplicationSecurityGroup parameters)
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
            uri.AppendPath("/providers/Microsoft.Network/applicationSecurityGroups/", false);
            uri.AppendPath(applicationSecurityGroupName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> CreateOrUpdateAsync(string resourceGroupName, string applicationSecurityGroupName, ApplicationSecurityGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(resourceGroupName, applicationSecurityGroupName, parameters);
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

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateOrUpdate(string resourceGroupName, string applicationSecurityGroupName, ApplicationSecurityGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(resourceGroupName, applicationSecurityGroupName, parameters);
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

        internal HttpMessage CreateUpdateTagsRequest(string resourceGroupName, string applicationSecurityGroupName, IDictionary<string, string> tags)
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
            uri.AppendPath("/providers/Microsoft.Network/applicationSecurityGroups/", false);
            uri.AppendPath(applicationSecurityGroupName, true);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var model = new TagsObject(tags);
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Updates an application security group&apos;s tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ApplicationSecurityGroup>> UpdateTagsAsync(string resourceGroupName, string applicationSecurityGroupName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.UpdateTags");
            scope.Start();
            try
            {
                using var message = CreateUpdateTagsRequest(resourceGroupName, applicationSecurityGroupName, tags);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroup value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(document.RootElement);
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

        /// <summary> Updates an application security group&apos;s tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ApplicationSecurityGroup> UpdateTags(string resourceGroupName, string applicationSecurityGroupName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.UpdateTags");
            scope.Start();
            try
            {
                using var message = CreateUpdateTagsRequest(resourceGroupName, applicationSecurityGroupName, tags);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroup value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(document.RootElement);
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

        internal HttpMessage CreateListAllRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Network/applicationSecurityGroups", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all application security groups in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ApplicationSecurityGroupListResult>> ListAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.ListAll");
            scope.Start();
            try
            {
                using var message = CreateListAllRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroupListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = ApplicationSecurityGroupListResult.DeserializeApplicationSecurityGroupListResult(document.RootElement);
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

        /// <summary> Gets all application security groups in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ApplicationSecurityGroupListResult> ListAll(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.ListAll");
            scope.Start();
            try
            {
                using var message = CreateListAllRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroupListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = ApplicationSecurityGroupListResult.DeserializeApplicationSecurityGroupListResult(document.RootElement);
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

        internal HttpMessage CreateListRequest(string resourceGroupName)
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
            uri.AppendPath("/providers/Microsoft.Network/applicationSecurityGroups", false);
            uri.AppendQuery("api-version", "2019-12-01", true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ApplicationSecurityGroupListResult>> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(resourceGroupName);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroupListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = ApplicationSecurityGroupListResult.DeserializeApplicationSecurityGroupListResult(document.RootElement);
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

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ApplicationSecurityGroupListResult> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.List");
            scope.Start();
            try
            {
                using var message = CreateListRequest(resourceGroupName);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroupListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = ApplicationSecurityGroupListResult.DeserializeApplicationSecurityGroupListResult(document.RootElement);
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

        internal HttpMessage CreateListAllNextPageRequest(string nextLink)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets all application security groups in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ApplicationSecurityGroupListResult>> ListAllNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.ListAll");
            scope.Start();
            try
            {
                using var message = CreateListAllNextPageRequest(nextLink);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroupListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = ApplicationSecurityGroupListResult.DeserializeApplicationSecurityGroupListResult(document.RootElement);
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

        /// <summary> Gets all application security groups in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ApplicationSecurityGroupListResult> ListAllNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.ListAll");
            scope.Start();
            try
            {
                using var message = CreateListAllNextPageRequest(nextLink);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroupListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = ApplicationSecurityGroupListResult.DeserializeApplicationSecurityGroupListResult(document.RootElement);
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

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ApplicationSecurityGroupListResult>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.List");
            scope.Start();
            try
            {
                using var message = CreateListNextPageRequest(nextLink);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroupListResult value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = ApplicationSecurityGroupListResult.DeserializeApplicationSecurityGroupListResult(document.RootElement);
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

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ApplicationSecurityGroupListResult> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var scope = clientDiagnostics.CreateScope("ApplicationSecurityGroupsClient.List");
            scope.Start();
            try
            {
                using var message = CreateListNextPageRequest(nextLink);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ApplicationSecurityGroupListResult value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = ApplicationSecurityGroupListResult.DeserializeApplicationSecurityGroupListResult(document.RootElement);
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
