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
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// IntegrationAccountMapsOperations operations.
    /// </summary>
    public partial interface IIntegrationAccountMapsOperations
    {
        /// <summary>
        /// Gets a list of integration account maps.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IntegrationAccountMap>>> ListWithHttpMessagesAsync(string resourceGroupName, string integrationAccountName, ODataQuery<IntegrationAccountMapFilter> odataQuery = default(ODataQuery<IntegrationAccountMapFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets an integration account map.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='mapName'>
        /// The integration account map name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IntegrationAccountMap>> GetWithHttpMessagesAsync(string resourceGroupName, string integrationAccountName, string mapName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates an integration account map.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='mapName'>
        /// The integration account map name.
        /// </param>
        /// <param name='map'>
        /// The integration account map.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IntegrationAccountMap>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string integrationAccountName, string mapName, IntegrationAccountMap map, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an integration account map.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='integrationAccountName'>
        /// The integration account name.
        /// </param>
        /// <param name='mapName'>
        /// The integration account map name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string integrationAccountName, string mapName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of integration account maps.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<IntegrationAccountMap>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
