// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Management.Resource;

namespace Azure.Management.Resource
{
    /// <summary> Resource service management client. </summary>
    public class ResourceManagementClient
    {
        private readonly ResourceManagementClientOptions _options;
        private readonly TokenCredential _tokenCredential;
        private readonly string _subscriptionId;
        private readonly string _host;

        /// <summary> Initializes a new instance of ResourceManagementClient for mocking. </summary>
        protected ResourceManagementClient()
        {
        }

        /// <summary> Initializes a new instance of ResourceManagementClient. </summary>
        public ResourceManagementClient(string subscriptionId, TokenCredential tokenCredential, ResourceManagementClientOptions options = null) : this(subscriptionId, "https://management.azure.com", tokenCredential, options)
        {
        }
        /// <summary> Initializes a new instance of ResourceManagementClient. </summary>
        public ResourceManagementClient(string subscriptionId, string host, TokenCredential tokenCredential, ResourceManagementClientOptions options = null)
        {
            _options = options ?? new ResourceManagementClientOptions();
            _tokenCredential = tokenCredential;
            _subscriptionId = subscriptionId;
            _host = host;
        }

        /// <summary> Creates a new instance of DeploymentsClient. </summary>
        public virtual DeploymentsClient GetDeploymentsClient()
        {
            return new DeploymentsClient(_subscriptionId, _host, _tokenCredential, _options);
        }

        /// <summary> Creates a new instance of ProvidersClient. </summary>
        public virtual ProvidersClient GetProvidersClient()
        {
            return new ProvidersClient(_subscriptionId, _host, _tokenCredential, _options);
        }

        /// <summary> Creates a new instance of ResourcesClient. </summary>
        public virtual ResourcesClient GetResourcesClient()
        {
            return new ResourcesClient(_subscriptionId, _host, _tokenCredential, _options);
        }

        /// <summary> Creates a new instance of ResourceGroupsClient. </summary>
        public virtual ResourceGroupsClient GetResourceGroupsClient()
        {
            return new ResourceGroupsClient(_subscriptionId, _host, _tokenCredential, _options);
        }

        /// <summary> Creates a new instance of TagsClient. </summary>
        public virtual TagsClient GetTagsClient()
        {
            return new TagsClient(_subscriptionId, _host, _tokenCredential, _options);
        }

        /// <summary> Creates a new instance of DeploymentClient. </summary>
        public virtual DeploymentClient GetDeploymentClient()
        {
            return new DeploymentClient(_subscriptionId, _host, _tokenCredential, _options);
        }
    }
}
