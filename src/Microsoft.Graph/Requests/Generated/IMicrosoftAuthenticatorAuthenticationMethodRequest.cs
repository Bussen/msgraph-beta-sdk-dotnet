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
    /// The interface IMicrosoftAuthenticatorAuthenticationMethodRequest.
    /// </summary>
    public partial interface IMicrosoftAuthenticatorAuthenticationMethodRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MicrosoftAuthenticatorAuthenticationMethod using POST.
        /// </summary>
        /// <param name="microsoftAuthenticatorAuthenticationMethodToCreate">The MicrosoftAuthenticatorAuthenticationMethod to create.</param>
        /// <returns>The created MicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethod> CreateAsync(MicrosoftAuthenticatorAuthenticationMethod microsoftAuthenticatorAuthenticationMethodToCreate);        /// <summary>
        /// Creates the specified MicrosoftAuthenticatorAuthenticationMethod using POST.
        /// </summary>
        /// <param name="microsoftAuthenticatorAuthenticationMethodToCreate">The MicrosoftAuthenticatorAuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethod> CreateAsync(MicrosoftAuthenticatorAuthenticationMethod microsoftAuthenticatorAuthenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <returns>The MicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethod> GetAsync();

        /// <summary>
        /// Gets the specified MicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethod> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MicrosoftAuthenticatorAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="microsoftAuthenticatorAuthenticationMethodToUpdate">The MicrosoftAuthenticatorAuthenticationMethod to update.</param>
        /// <returns>The updated MicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethod> UpdateAsync(MicrosoftAuthenticatorAuthenticationMethod microsoftAuthenticatorAuthenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified MicrosoftAuthenticatorAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="microsoftAuthenticatorAuthenticationMethodToUpdate">The MicrosoftAuthenticatorAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftAuthenticatorAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<MicrosoftAuthenticatorAuthenticationMethod> UpdateAsync(MicrosoftAuthenticatorAuthenticationMethod microsoftAuthenticatorAuthenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftAuthenticatorAuthenticationMethodRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftAuthenticatorAuthenticationMethodRequest Expand(Expression<Func<MicrosoftAuthenticatorAuthenticationMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftAuthenticatorAuthenticationMethodRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMicrosoftAuthenticatorAuthenticationMethodRequest Select(Expression<Func<MicrosoftAuthenticatorAuthenticationMethod, object>> selectExpression);

    }
}
