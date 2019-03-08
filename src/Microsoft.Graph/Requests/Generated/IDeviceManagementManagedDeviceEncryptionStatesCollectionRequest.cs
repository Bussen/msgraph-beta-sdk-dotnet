// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest.
    /// </summary>
    public partial interface IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified ManagedDeviceEncryptionState to the collection via POST.
        /// </summary>
        /// <param name="managedDeviceEncryptionState">The ManagedDeviceEncryptionState to add.</param>
        /// <returns>The created ManagedDeviceEncryptionState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceEncryptionState> AddAsync(ManagedDeviceEncryptionState managedDeviceEncryptionState);

        /// <summary>
        /// Adds the specified ManagedDeviceEncryptionState to the collection via POST.
        /// </summary>
        /// <param name="managedDeviceEncryptionState">The ManagedDeviceEncryptionState to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceEncryptionState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceEncryptionState> AddAsync(ManagedDeviceEncryptionState managedDeviceEncryptionState, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementManagedDeviceEncryptionStatesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IDeviceManagementManagedDeviceEncryptionStatesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest Expand(Expression<Func<ManagedDeviceEncryptionState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest Select(Expression<Func<ManagedDeviceEncryptionState, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementManagedDeviceEncryptionStatesCollectionRequest OrderBy(string value);
    }
}