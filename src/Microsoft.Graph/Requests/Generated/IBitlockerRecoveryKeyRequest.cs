// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IBitlockerRecoveryKeyRequest.
    /// </summary>
    public partial interface IBitlockerRecoveryKeyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BitlockerRecoveryKey using POST.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToCreate">The BitlockerRecoveryKey to create.</param>
        /// <returns>The created BitlockerRecoveryKey.</returns>
        System.Threading.Tasks.Task<BitlockerRecoveryKey> CreateAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToCreate);        /// <summary>
        /// Creates the specified BitlockerRecoveryKey using POST.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToCreate">The BitlockerRecoveryKey to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BitlockerRecoveryKey.</returns>
        System.Threading.Tasks.Task<BitlockerRecoveryKey> CreateAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified BitlockerRecoveryKey.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified BitlockerRecoveryKey.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BitlockerRecoveryKey.
        /// </summary>
        /// <returns>The BitlockerRecoveryKey.</returns>
        System.Threading.Tasks.Task<BitlockerRecoveryKey> GetAsync();

        /// <summary>
        /// Gets the specified BitlockerRecoveryKey.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BitlockerRecoveryKey.</returns>
        System.Threading.Tasks.Task<BitlockerRecoveryKey> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BitlockerRecoveryKey using PATCH.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToUpdate">The BitlockerRecoveryKey to update.</param>
        /// <returns>The updated BitlockerRecoveryKey.</returns>
        System.Threading.Tasks.Task<BitlockerRecoveryKey> UpdateAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToUpdate);

        /// <summary>
        /// Updates the specified BitlockerRecoveryKey using PATCH.
        /// </summary>
        /// <param name="bitlockerRecoveryKeyToUpdate">The BitlockerRecoveryKey to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BitlockerRecoveryKey.</returns>
        System.Threading.Tasks.Task<BitlockerRecoveryKey> UpdateAsync(BitlockerRecoveryKey bitlockerRecoveryKeyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBitlockerRecoveryKeyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBitlockerRecoveryKeyRequest Expand(Expression<Func<BitlockerRecoveryKey, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBitlockerRecoveryKeyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBitlockerRecoveryKeyRequest Select(Expression<Func<BitlockerRecoveryKey, object>> selectExpression);

    }
}
