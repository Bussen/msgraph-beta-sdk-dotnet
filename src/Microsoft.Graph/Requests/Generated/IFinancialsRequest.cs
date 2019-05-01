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
    /// The interface IFinancialsRequest.
    /// </summary>
    public partial interface IFinancialsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Financials using PUT.
        /// </summary>
        /// <param name="financialsToCreate">The Financials to create.</param>
        /// <returns>The created Financials.</returns>
        System.Threading.Tasks.Task<Financials> CreateAsync(Financials financialsToCreate);        /// <summary>
        /// Creates the specified Financials using PUT.
        /// </summary>
        /// <param name="financialsToCreate">The Financials to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Financials.</returns>
        System.Threading.Tasks.Task<Financials> CreateAsync(Financials financialsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Financials.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Financials.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Financials.
        /// </summary>
        /// <returns>The Financials.</returns>
        System.Threading.Tasks.Task<Financials> GetAsync();

        /// <summary>
        /// Gets the specified Financials.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Financials.</returns>
        System.Threading.Tasks.Task<Financials> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Financials using PATCH.
        /// </summary>
        /// <param name="financialsToUpdate">The Financials to update.</param>
        /// <returns>The updated Financials.</returns>
        System.Threading.Tasks.Task<Financials> UpdateAsync(Financials financialsToUpdate);

        /// <summary>
        /// Updates the specified Financials using PATCH.
        /// </summary>
        /// <param name="financialsToUpdate">The Financials to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Financials.</returns>
        System.Threading.Tasks.Task<Financials> UpdateAsync(Financials financialsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFinancialsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFinancialsRequest Expand(Expression<Func<Financials, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFinancialsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFinancialsRequest Select(Expression<Func<Financials, object>> selectExpression);

    }
}