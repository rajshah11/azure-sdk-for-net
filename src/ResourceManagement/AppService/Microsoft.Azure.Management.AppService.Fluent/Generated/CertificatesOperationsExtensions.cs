// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for CertificatesOperations.
    /// </summary>
    public static partial class CertificatesOperationsExtensions
    {
            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CertificateInner> List(this ICertificatesOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).ListAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CertificateInner>> ListAsync(this ICertificatesOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CertificateInner> ListByResourceGroup(this ICertificatesOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CertificateInner>> ListByResourceGroupAsync(this ICertificatesOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a certificate.
            /// </summary>
            /// <remarks>
            /// Get a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            public static CertificateInner Get(this ICertificatesOperations operations, string resourceGroupName, string name)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).GetAsync(resourceGroupName, name), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a certificate.
            /// </summary>
            /// <remarks>
            /// Get a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CertificateInner> GetAsync(this ICertificatesOperations operations, string resourceGroupName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            public static CertificateInner CreateOrUpdate(this ICertificatesOperations operations, string resourceGroupName, string name, CertificateInner certificateEnvelope)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).CreateOrUpdateAsync(resourceGroupName, name, certificateEnvelope), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CertificateInner> CreateOrUpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CertificateInner certificateEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, certificateEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a certificate.
            /// </summary>
            /// <remarks>
            /// Delete a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            public static void Delete(this ICertificatesOperations operations, string resourceGroupName, string name)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).DeleteAsync(resourceGroupName, name), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a certificate.
            /// </summary>
            /// <remarks>
            /// Delete a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this ICertificatesOperations operations, string resourceGroupName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            public static CertificateInner Update(this ICertificatesOperations operations, string resourceGroupName, string name, CertificateInner certificateEnvelope)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).UpdateAsync(resourceGroupName, name, certificateEnvelope), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate.
            /// </param>
            /// <param name='certificateEnvelope'>
            /// Details of certificate, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CertificateInner> UpdateAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CertificateInner certificateEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, name, certificateEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificate signing requests in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificate signing requests in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CsrInner> ListSigningRequestByResourceGroup(this ICertificatesOperations operations, string resourceGroupName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).ListSigningRequestByResourceGroupAsync(resourceGroupName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificate signing requests in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificate signing requests in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CsrInner>> ListSigningRequestByResourceGroupAsync(this ICertificatesOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListSigningRequestByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a certificate signing request.
            /// </summary>
            /// <remarks>
            /// Get a certificate signing request.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate signing request.
            /// </param>
            public static CsrInner GetSigningRequest(this ICertificatesOperations operations, string resourceGroupName, string name)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).GetSigningRequestAsync(resourceGroupName, name), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a certificate signing request.
            /// </summary>
            /// <remarks>
            /// Get a certificate signing request.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate signing request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CsrInner> GetSigningRequestAsync(this ICertificatesOperations operations, string resourceGroupName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetSigningRequestWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a certificate signing request.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate signing request.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate signing request.
            /// </param>
            /// <param name='csrEnvelope'>
            /// Details of certificate signing request, if it exists already.
            /// </param>
            public static CsrInner CreateOrUpdateSigningRequest(this ICertificatesOperations operations, string resourceGroupName, string name, CsrInner csrEnvelope)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).CreateOrUpdateSigningRequestAsync(resourceGroupName, name, csrEnvelope), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate signing request.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate signing request.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate signing request.
            /// </param>
            /// <param name='csrEnvelope'>
            /// Details of certificate signing request, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CsrInner> CreateOrUpdateSigningRequestAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CsrInner csrEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateSigningRequestWithHttpMessagesAsync(resourceGroupName, name, csrEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a certificate signing request.
            /// </summary>
            /// <remarks>
            /// Delete a certificate signing request.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate signing request.
            /// </param>
            public static void DeleteSigningRequest(this ICertificatesOperations operations, string resourceGroupName, string name)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).DeleteSigningRequestAsync(resourceGroupName, name), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a certificate signing request.
            /// </summary>
            /// <remarks>
            /// Delete a certificate signing request.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate signing request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteSigningRequestAsync(this ICertificatesOperations operations, string resourceGroupName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteSigningRequestWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Create or update a certificate signing request.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate signing request.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate signing request.
            /// </param>
            /// <param name='csrEnvelope'>
            /// Details of certificate signing request, if it exists already.
            /// </param>
            public static CsrInner UpdateSigningRequest(this ICertificatesOperations operations, string resourceGroupName, string name, CsrInner csrEnvelope)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).UpdateSigningRequestAsync(resourceGroupName, name, csrEnvelope), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a certificate signing request.
            /// </summary>
            /// <remarks>
            /// Create or update a certificate signing request.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='name'>
            /// Name of the certificate signing request.
            /// </param>
            /// <param name='csrEnvelope'>
            /// Details of certificate signing request, if it exists already.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CsrInner> UpdateSigningRequestAsync(this ICertificatesOperations operations, string resourceGroupName, string name, CsrInner csrEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateSigningRequestWithHttpMessagesAsync(resourceGroupName, name, csrEnvelope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CertificateInner> ListNext(this ICertificatesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates for a subscription.
            /// </summary>
            /// <remarks>
            /// Get all certificates for a subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CertificateInner>> ListNextAsync(this ICertificatesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CertificateInner> ListByResourceGroupNext(this ICertificatesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificates in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificates in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CertificateInner>> ListByResourceGroupNextAsync(this ICertificatesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all certificate signing requests in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificate signing requests in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CsrInner> ListSigningRequestByResourceGroupNext(this ICertificatesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICertificatesOperations)s).ListSigningRequestByResourceGroupNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all certificate signing requests in a resource group.
            /// </summary>
            /// <remarks>
            /// Get all certificate signing requests in a resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<CsrInner>> ListSigningRequestByResourceGroupNextAsync(this ICertificatesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListSigningRequestByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}