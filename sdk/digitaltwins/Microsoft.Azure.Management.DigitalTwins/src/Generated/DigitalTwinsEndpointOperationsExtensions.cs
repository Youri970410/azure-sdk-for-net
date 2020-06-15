// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DigitalTwinsEndpointOperations.
    /// </summary>
    public static partial class DigitalTwinsEndpointOperationsExtensions
    {
            /// <summary>
            /// Get DigitalTwinsInstance Endpoints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            public static IPage<DigitalTwinsEndpointResource> List(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.ListAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get DigitalTwinsInstance Endpoints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DigitalTwinsEndpointResource>> ListAsync(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get DigitalTwinsInstances Endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            public static DigitalTwinsEndpointResource Get(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName)
            {
                return operations.GetAsync(resourceGroupName, resourceName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get DigitalTwinsInstances Endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsEndpointResource> GetAsync(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update DigitalTwinsInstance endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            /// <param name='properties'>
            /// DigitalTwinsInstance endpoint resource properties.
            /// </param>
            public static DigitalTwinsEndpointResource CreateOrUpdate(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName, DigitalTwinsEndpointResourceProperties properties = default(DigitalTwinsEndpointResourceProperties))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, resourceName, endpointName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update DigitalTwinsInstance endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            /// <param name='properties'>
            /// DigitalTwinsInstance endpoint resource properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsEndpointResource> CreateOrUpdateAsync(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName, DigitalTwinsEndpointResourceProperties properties = default(DigitalTwinsEndpointResourceProperties), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, endpointName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a DigitalTwinsInstance endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            public static DigitalTwinsEndpointResource Delete(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName)
            {
                return operations.DeleteAsync(resourceGroupName, resourceName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a DigitalTwinsInstance endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsEndpointResource> DeleteAsync(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update DigitalTwinsInstance endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            /// <param name='properties'>
            /// DigitalTwinsInstance endpoint resource properties.
            /// </param>
            public static DigitalTwinsEndpointResource BeginCreateOrUpdate(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName, DigitalTwinsEndpointResourceProperties properties = default(DigitalTwinsEndpointResourceProperties))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, resourceName, endpointName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update DigitalTwinsInstance endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            /// <param name='properties'>
            /// DigitalTwinsInstance endpoint resource properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsEndpointResource> BeginCreateOrUpdateAsync(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName, DigitalTwinsEndpointResourceProperties properties = default(DigitalTwinsEndpointResourceProperties), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, endpointName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a DigitalTwinsInstance endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            public static DigitalTwinsEndpointResource BeginDelete(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, resourceName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a DigitalTwinsInstance endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='endpointName'>
            /// Name of Endpoint Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DigitalTwinsEndpointResource> BeginDeleteAsync(this IDigitalTwinsEndpointOperations operations, string resourceGroupName, string resourceName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get DigitalTwinsInstance Endpoints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DigitalTwinsEndpointResource> ListNext(this IDigitalTwinsEndpointOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get DigitalTwinsInstance Endpoints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DigitalTwinsEndpointResource>> ListNextAsync(this IDigitalTwinsEndpointOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
