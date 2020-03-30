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
    public partial class FirewallPolicyRuleGroupsClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal FirewallPolicyRuleGroupsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of FirewallPolicyRuleGroupsClient for mocking. </summary>
        protected FirewallPolicyRuleGroupsClient()
        {
        }
        /// <summary> Initializes a new instance of FirewallPolicyRuleGroupsClient. </summary>
        internal FirewallPolicyRuleGroupsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, string host = "https://management.azure.com")
        {
            RestClient = new FirewallPolicyRuleGroupsRestClient(clientDiagnostics, pipeline, subscriptionId, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Gets the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FirewallPolicyRuleGroup>> GetAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FirewallPolicyRuleGroup> Get(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken);
        }

        /// <summary> Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<FirewallPolicyRuleGroup> ListAsync(string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            async Task<Page<FirewallPolicyRuleGroup>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(resourceGroupName, firewallPolicyName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<FirewallPolicyRuleGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all FirewallPolicyRuleGroups in a FirewallPolicy resource. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<FirewallPolicyRuleGroup> List(string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            Page<FirewallPolicyRuleGroup> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(resourceGroupName, firewallPolicyName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<FirewallPolicyRuleGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified FirewallPolicyRuleGroup. </summary>
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

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Delete, "FirewallPolicyRuleGroupsClient.Delete", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> Deletes the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartDeleteAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }

            var originalResponse = await RestClient.DeleteAsync(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken).ConfigureAwait(false);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, firewallPolicyName, ruleGroupName));
        }

        /// <summary> Deletes the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartDelete(string resourceGroupName, string firewallPolicyName, string ruleGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }

            var originalResponse = RestClient.Delete(resourceGroupName, firewallPolicyName, ruleGroupName, cancellationToken);
            return CreateDelete(originalResponse, () => RestClient.CreateDeleteRequest(resourceGroupName, firewallPolicyName, ruleGroupName));
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<FirewallPolicyRuleGroup> CreateCreateOrUpdate(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(pipeline, clientDiagnostics, originalResponse, RequestMethod.Put, "FirewallPolicyRuleGroupsClient.CreateOrUpdate", OperationFinalStateVia.AzureAsyncOperation, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                return FirewallPolicyRuleGroup.DeserializeFirewallPolicyRuleGroup(document.RootElement);
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                return FirewallPolicyRuleGroup.DeserializeFirewallPolicyRuleGroup(document.RootElement);
            });
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<FirewallPolicyRuleGroup>> StartCreateOrUpdateAsync(string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, firewallPolicyName, ruleGroupName, parameters, cancellationToken).ConfigureAwait(false);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, firewallPolicyName, ruleGroupName, parameters));
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleGroup. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleGroupName"> The name of the FirewallPolicyRuleGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<FirewallPolicyRuleGroup> StartCreateOrUpdate(string resourceGroupName, string firewallPolicyName, string ruleGroupName, FirewallPolicyRuleGroup parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, firewallPolicyName, ruleGroupName, parameters, cancellationToken);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, firewallPolicyName, ruleGroupName, parameters));
        }
    }
}
