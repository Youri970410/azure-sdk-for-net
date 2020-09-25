// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedHsmsOperations.
    /// </summary>
    public static partial class ManagedHsmsOperationsExtensions
    {
            /// <summary>
            /// Create or update a managed HSM Pool in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// Name of the managed HSM Pool
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the managed HSM Pool
            /// </param>
            public static ManagedHsm CreateOrUpdate(this IManagedHsmsOperations operations, string resourceGroupName, string name, ManagedHsm parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, name, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a managed HSM Pool in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// Name of the managed HSM Pool
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the managed HSM Pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedHsm> CreateOrUpdateAsync(this IManagedHsmsOperations operations, string resourceGroupName, string name, ManagedHsm parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a managed HSM Pool in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// Name of the managed HSM Pool
            /// </param>
            /// <param name='parameters'>
            /// Parameters to patch the managed HSM Pool
            /// </param>
            public static ManagedHsm Update(this IManagedHsmsOperations operations, string resourceGroupName, string name, ManagedHsm parameters)
            {
                return operations.UpdateAsync(resourceGroupName, name, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a managed HSM Pool in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// Name of the managed HSM Pool
            /// </param>
            /// <param name='parameters'>
            /// Parameters to patch the managed HSM Pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedHsm> UpdateAsync(this IManagedHsmsOperations operations, string resourceGroupName, string name, ManagedHsm parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified managed HSM Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// The name of the managed HSM Pool to delete
            /// </param>
            public static void Delete(this IManagedHsmsOperations operations, string resourceGroupName, string name)
            {
                operations.DeleteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified managed HSM Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// The name of the managed HSM Pool to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManagedHsmsOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified managed HSM Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// The name of the managed HSM Pool.
            /// </param>
            public static ManagedHsm Get(this IManagedHsmsOperations operations, string resourceGroupName, string name)
            {
                return operations.GetAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified managed HSM Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// The name of the managed HSM Pool.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedHsm> GetAsync(this IManagedHsmsOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the managed HSM Pools associated
            /// with the subscription and within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            public static IPage<ManagedHsm> ListByResourceGroup(this IManagedHsmsOperations operations, string resourceGroupName, int? top = default(int?))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the managed HSM Pools associated
            /// with the subscription and within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedHsm>> ListByResourceGroupAsync(this IManagedHsmsOperations operations, string resourceGroupName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the managed HSM Pools associated
            /// with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            public static IPage<ManagedHsm> ListBySubscription(this IManagedHsmsOperations operations, int? top = default(int?))
            {
                return operations.ListBySubscriptionAsync(top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the managed HSM Pools associated
            /// with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// Maximum number of results to return.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedHsm>> ListBySubscriptionAsync(this IManagedHsmsOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a managed HSM Pool in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// Name of the managed HSM Pool
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the managed HSM Pool
            /// </param>
            public static ManagedHsm BeginCreateOrUpdate(this IManagedHsmsOperations operations, string resourceGroupName, string name, ManagedHsm parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, name, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a managed HSM Pool in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// Name of the managed HSM Pool
            /// </param>
            /// <param name='parameters'>
            /// Parameters to create or update the managed HSM Pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedHsm> BeginCreateOrUpdateAsync(this IManagedHsmsOperations operations, string resourceGroupName, string name, ManagedHsm parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a managed HSM Pool in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// Name of the managed HSM Pool
            /// </param>
            /// <param name='parameters'>
            /// Parameters to patch the managed HSM Pool
            /// </param>
            public static ManagedHsm BeginUpdate(this IManagedHsmsOperations operations, string resourceGroupName, string name, ManagedHsm parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, name, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a managed HSM Pool in the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// Name of the managed HSM Pool
            /// </param>
            /// <param name='parameters'>
            /// Parameters to patch the managed HSM Pool
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedHsm> BeginUpdateAsync(this IManagedHsmsOperations operations, string resourceGroupName, string name, ManagedHsm parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified managed HSM Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// The name of the managed HSM Pool to delete
            /// </param>
            public static void BeginDelete(this IManagedHsmsOperations operations, string resourceGroupName, string name)
            {
                operations.BeginDeleteAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified managed HSM Pool.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the managed HSM pool.
            /// </param>
            /// <param name='name'>
            /// The name of the managed HSM Pool to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IManagedHsmsOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The List operation gets information about the managed HSM Pools associated
            /// with the subscription and within the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedHsm> ListByResourceGroupNext(this IManagedHsmsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the managed HSM Pools associated
            /// with the subscription and within the specified resource group.
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
            public static async Task<IPage<ManagedHsm>> ListByResourceGroupNextAsync(this IManagedHsmsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The List operation gets information about the managed HSM Pools associated
            /// with the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedHsm> ListBySubscriptionNext(this IManagedHsmsOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The List operation gets information about the managed HSM Pools associated
            /// with the subscription.
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
            public static async Task<IPage<ManagedHsm>> ListBySubscriptionNextAsync(this IManagedHsmsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
