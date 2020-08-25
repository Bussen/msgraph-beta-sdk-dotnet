// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISetWithReferenceRequest.
    /// </summary>
    public partial interface ISetWithReferenceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Gets the specified Set.
        /// </summary>
        /// <returns>The Set.</returns>
        System.Threading.Tasks.Task<Set> GetAsync();

        /// <summary>
        /// Gets the specified Set.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Set.</returns>
        System.Threading.Tasks.Task<Set> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified Set using POST.
        /// </summary>
        /// <param name="setToCreate">The Set to create.</param>
        /// <returns>The created Set.</returns>
        System.Threading.Tasks.Task<Set> CreateAsync(Set setToCreate);        /// <summary>
        /// Creates the specified Set using POST.
        /// </summary>
        /// <param name="setToCreate">The Set to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Set.</returns>
        System.Threading.Tasks.Task<Set> CreateAsync(Set setToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified Set using PATCH.
        /// </summary>
        /// <param name="setToUpdate">The Set to update.</param>
        /// <returns>The updated Set.</returns>
        System.Threading.Tasks.Task<Set> UpdateAsync(Set setToUpdate);

        /// <summary>
        /// Updates the specified Set using PATCH.
        /// </summary>
        /// <param name="setToUpdate">The Set to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Set.</returns>
        System.Threading.Tasks.Task<Set> UpdateAsync(Set setToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified Set.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Set.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISetWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISetWithReferenceRequest Expand(Expression<Func<Set, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISetWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISetWithReferenceRequest Select(Expression<Func<Set, object>> selectExpression);

    }
}