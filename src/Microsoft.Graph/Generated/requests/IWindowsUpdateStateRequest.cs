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
    /// The interface IWindowsUpdateStateRequest.
    /// </summary>
    public partial interface IWindowsUpdateStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsUpdateState using POST.
        /// </summary>
        /// <param name="windowsUpdateStateToCreate">The WindowsUpdateState to create.</param>
        /// <returns>The created WindowsUpdateState.</returns>
        System.Threading.Tasks.Task<WindowsUpdateState> CreateAsync(WindowsUpdateState windowsUpdateStateToCreate);        /// <summary>
        /// Creates the specified WindowsUpdateState using POST.
        /// </summary>
        /// <param name="windowsUpdateStateToCreate">The WindowsUpdateState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsUpdateState.</returns>
        System.Threading.Tasks.Task<WindowsUpdateState> CreateAsync(WindowsUpdateState windowsUpdateStateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsUpdateState.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsUpdateState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsUpdateState.
        /// </summary>
        /// <returns>The WindowsUpdateState.</returns>
        System.Threading.Tasks.Task<WindowsUpdateState> GetAsync();

        /// <summary>
        /// Gets the specified WindowsUpdateState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsUpdateState.</returns>
        System.Threading.Tasks.Task<WindowsUpdateState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsUpdateState using PATCH.
        /// </summary>
        /// <param name="windowsUpdateStateToUpdate">The WindowsUpdateState to update.</param>
        /// <returns>The updated WindowsUpdateState.</returns>
        System.Threading.Tasks.Task<WindowsUpdateState> UpdateAsync(WindowsUpdateState windowsUpdateStateToUpdate);

        /// <summary>
        /// Updates the specified WindowsUpdateState using PATCH.
        /// </summary>
        /// <param name="windowsUpdateStateToUpdate">The WindowsUpdateState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsUpdateState.</returns>
        System.Threading.Tasks.Task<WindowsUpdateState> UpdateAsync(WindowsUpdateState windowsUpdateStateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateStateRequest Expand(Expression<Func<WindowsUpdateState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateStateRequest Select(Expression<Func<WindowsUpdateState, object>> selectExpression);

    }
}
