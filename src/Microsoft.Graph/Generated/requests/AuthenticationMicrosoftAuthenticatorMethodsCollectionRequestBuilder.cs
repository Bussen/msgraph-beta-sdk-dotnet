// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AuthenticationMicrosoftAuthenticatorMethodsCollectionRequestBuilder.
    /// </summary>
    public partial class AuthenticationMicrosoftAuthenticatorMethodsCollectionRequestBuilder : BaseRequestBuilder, IAuthenticationMicrosoftAuthenticatorMethodsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuthenticationMicrosoftAuthenticatorMethodsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuthenticationMicrosoftAuthenticatorMethodsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuthenticationMicrosoftAuthenticatorMethodsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuthenticationMicrosoftAuthenticatorMethodsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuthenticationMicrosoftAuthenticatorMethodsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMicrosoftAuthenticatorAuthenticationMethodRequestBuilder"/> for the specified AuthenticationMicrosoftAuthenticatorAuthenticationMethod.
        /// </summary>
        /// <param name="id">The ID for the AuthenticationMicrosoftAuthenticatorAuthenticationMethod.</param>
        /// <returns>The <see cref="IMicrosoftAuthenticatorAuthenticationMethodRequestBuilder"/>.</returns>
        public IMicrosoftAuthenticatorAuthenticationMethodRequestBuilder this[string id]
        {
            get
            {
                return new MicrosoftAuthenticatorAuthenticationMethodRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
