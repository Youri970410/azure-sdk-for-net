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
    public partial class ApplicationSecurityGroupsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal ApplicationSecurityGroupsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ApplicationSecurityGroupsClient for mocking. </summary>
        protected ApplicationSecurityGroupsClient()
        {
        }
        /// <summary> Initializes a new instance of ApplicationSecurityGroupsClient. </summary>
        internal ApplicationSecurityGroupsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            RestClient = new ApplicationSecurityGroupsRestClient(clientDiagnostics, pipeline, subscriptionId, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationSecurityGroup>> GetAsync(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, applicationSecurityGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets information about the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationSecurityGroup> Get(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, applicationSecurityGroupName, cancellationToken);
        }

        /// <summary> Updates an application security group&apos;s tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApplicationSecurityGroup>> UpdateTagsAsync(string resourceGroupName, string applicationSecurityGroupName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateTagsAsync(resourceGroupName, applicationSecurityGroupName, tags, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates an application security group&apos;s tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApplicationSecurityGroup> UpdateTags(string resourceGroupName, string applicationSecurityGroupName, IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdateTags(resourceGroupName, applicationSecurityGroupName, tags, cancellationToken);
        }

        /// <summary> Gets all application security groups in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ApplicationSecurityGroup> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ApplicationSecurityGroup>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<ApplicationSecurityGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all application security groups in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ApplicationSecurityGroup> ListAll(CancellationToken cancellationToken = default)
        {
            Page<ApplicationSecurityGroup> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListAll(cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<ApplicationSecurityGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ApplicationSecurityGroup> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<ApplicationSecurityGroup>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<ApplicationSecurityGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the application security groups in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ApplicationSecurityGroup> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<ApplicationSecurityGroup> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(resourceGroupName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<ApplicationSecurityGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified application security group. </summary>
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

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Delete, "ApplicationSecurityGroupsClient.Delete", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> Deletes the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartDeleteAsync(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            var originalResponse = await RestClient.DeleteAsync(resourceGroupName, applicationSecurityGroupName, cancellationToken).ConfigureAwait(false);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, applicationSecurityGroupName));
        }

        /// <summary> Deletes the specified application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartDelete(string resourceGroupName, string applicationSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(applicationSecurityGroupName));
            }

            var originalResponse = RestClient.Delete(resourceGroupName, applicationSecurityGroupName, cancellationToken);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, applicationSecurityGroupName));
        }

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<ApplicationSecurityGroup> CreateCreateOrUpdate(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Put, "ApplicationSecurityGroupsClient.CreateOrUpdate", OperationFinalStateVia.AzureAsyncOperation, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(document.RootElement);
            });
        }

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<ApplicationSecurityGroup>> StartCreateOrUpdateAsync(string resourceGroupName, string applicationSecurityGroupName, ApplicationSecurityGroup parameters, CancellationToken cancellationToken = default)
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

            var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, applicationSecurityGroupName, parameters, cancellationToken).ConfigureAwait(false);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, applicationSecurityGroupName, parameters));
        }

        /// <summary> Creates or updates an application security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="applicationSecurityGroupName"> The name of the application security group. </param>
        /// <param name="parameters"> Parameters supplied to the create or update ApplicationSecurityGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<ApplicationSecurityGroup> StartCreateOrUpdate(string resourceGroupName, string applicationSecurityGroupName, ApplicationSecurityGroup parameters, CancellationToken cancellationToken = default)
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

            var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, applicationSecurityGroupName, parameters, cancellationToken);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, applicationSecurityGroupName, parameters));
        }
    }
}
