// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for IntegrationAccountCertificatesOperations.
    /// </summary>
    public static partial class IntegrationAccountCertificatesOperationsExtensions
    {
            /// <summary>
            /// Gets a list of integration account certificates.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            public static IPage<IntegrationAccountCertificate> List(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, int? top = default(int?))
            {
                return Task.Factory.StartNew(s => ((IIntegrationAccountCertificatesOperations)s).ListAsync(resourceGroupName, integrationAccountName, top), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration account certificates.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='top'>
            /// The number of items to be included in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccountCertificate>> ListAsync(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, integrationAccountName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an integration account certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='certificateName'>
            /// The integration account certificate name.
            /// </param>
            public static IntegrationAccountCertificate Get(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName)
            {
                return Task.Factory.StartNew(s => ((IIntegrationAccountCertificatesOperations)s).GetAsync(resourceGroupName, integrationAccountName, certificateName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an integration account certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='certificateName'>
            /// The integration account certificate name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccountCertificate> GetAsync(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, integrationAccountName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an integration account certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='certificateName'>
            /// The integration account certificate name.
            /// </param>
            /// <param name='certificate'>
            /// The integration account certificate.
            /// </param>
            public static IntegrationAccountCertificate CreateOrUpdate(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName, IntegrationAccountCertificate certificate)
            {
                return Task.Factory.StartNew(s => ((IIntegrationAccountCertificatesOperations)s).CreateOrUpdateAsync(resourceGroupName, integrationAccountName, certificateName, certificate), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an integration account certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='certificateName'>
            /// The integration account certificate name.
            /// </param>
            /// <param name='certificate'>
            /// The integration account certificate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccountCertificate> CreateOrUpdateAsync(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName, IntegrationAccountCertificate certificate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, integrationAccountName, certificateName, certificate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an integration account certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='certificateName'>
            /// The integration account certificate name.
            /// </param>
            public static void Delete(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName)
            {
                Task.Factory.StartNew(s => ((IIntegrationAccountCertificatesOperations)s).DeleteAsync(resourceGroupName, integrationAccountName, certificateName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an integration account certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='certificateName'>
            /// The integration account certificate name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIntegrationAccountCertificatesOperations operations, string resourceGroupName, string integrationAccountName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, integrationAccountName, certificateName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a list of integration account certificates.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IntegrationAccountCertificate> ListNext(this IIntegrationAccountCertificatesOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IIntegrationAccountCertificatesOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration account certificates.
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
            public static async Task<IPage<IntegrationAccountCertificate>> ListNextAsync(this IIntegrationAccountCertificatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
