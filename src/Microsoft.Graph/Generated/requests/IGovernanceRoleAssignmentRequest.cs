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
    /// The interface IGovernanceRoleAssignmentRequest.
    /// </summary>
    public partial interface IGovernanceRoleAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GovernanceRoleAssignment using POST.
        /// </summary>
        /// <param name="governanceRoleAssignmentToCreate">The GovernanceRoleAssignment to create.</param>
        /// <returns>The created GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> CreateAsync(GovernanceRoleAssignment governanceRoleAssignmentToCreate);        /// <summary>
        /// Creates the specified GovernanceRoleAssignment using POST.
        /// </summary>
        /// <param name="governanceRoleAssignmentToCreate">The GovernanceRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> CreateAsync(GovernanceRoleAssignment governanceRoleAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GovernanceRoleAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GovernanceRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GovernanceRoleAssignment.
        /// </summary>
        /// <returns>The GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> GetAsync();

        /// <summary>
        /// Gets the specified GovernanceRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GovernanceRoleAssignment using PATCH.
        /// </summary>
        /// <param name="governanceRoleAssignmentToUpdate">The GovernanceRoleAssignment to update.</param>
        /// <returns>The updated GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> UpdateAsync(GovernanceRoleAssignment governanceRoleAssignmentToUpdate);

        /// <summary>
        /// Updates the specified GovernanceRoleAssignment using PATCH.
        /// </summary>
        /// <param name="governanceRoleAssignmentToUpdate">The GovernanceRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernanceRoleAssignment.</returns>
        System.Threading.Tasks.Task<GovernanceRoleAssignment> UpdateAsync(GovernanceRoleAssignment governanceRoleAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentRequest Expand(Expression<Func<GovernanceRoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceRoleAssignmentRequest Select(Expression<Func<GovernanceRoleAssignment, object>> selectExpression);

    }
}