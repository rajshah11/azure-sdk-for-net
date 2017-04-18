// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for PolicyDefinitionsOperations.
    /// </summary>
    public static partial class PolicyDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Create or update a policy definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The policy definition name.
            /// </param>
            /// <param name='parameters'>
            /// The policy definition properties.
            /// </param>
            public static PolicyDefinition CreateOrUpdate(this IPolicyDefinitionsOperations operations, string policyDefinitionName, PolicyDefinition parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyDefinitionsOperations)s).CreateOrUpdateAsync(policyDefinitionName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a policy definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The policy definition name.
            /// </param>
            /// <param name='parameters'>
            /// The policy definition properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PolicyDefinition> CreateOrUpdateAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, PolicyDefinition parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(policyDefinitionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the policy definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The policy definition name.
            /// </param>
            public static void Delete(this IPolicyDefinitionsOperations operations, string policyDefinitionName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyDefinitionsOperations)s).DeleteAsync(policyDefinitionName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the policy definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The policy definition name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(policyDefinitionName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the policy definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The policy definition name.
            /// </param>
            public static PolicyDefinition Get(this IPolicyDefinitionsOperations operations, string policyDefinitionName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyDefinitionsOperations)s).GetAsync(policyDefinitionName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the policy definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The policy definition name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PolicyDefinition> GetAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(policyDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the policy definitions of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PolicyDefinition> List(this IPolicyDefinitionsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<PolicyDefinition> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<PolicyDefinition>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyDefinitionsOperations)s).ListAsync(odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the policy definitions of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PolicyDefinition>> ListAsync(this IPolicyDefinitionsOperations operations, Microsoft.Rest.Azure.OData.ODataQuery<PolicyDefinition> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<PolicyDefinition>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the policy definitions of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PolicyDefinition> ListNext(this IPolicyDefinitionsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPolicyDefinitionsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the policy definitions of a subscription.
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
            public static async Task<Microsoft.Rest.Azure.IPage<PolicyDefinition>> ListNextAsync(this IPolicyDefinitionsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}