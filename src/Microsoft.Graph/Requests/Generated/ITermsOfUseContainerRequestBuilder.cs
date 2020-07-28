// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ITermsOfUseContainerRequestBuilder.
    /// </summary>
    public partial interface ITermsOfUseContainerRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ITermsOfUseContainerRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ITermsOfUseContainerRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Agreements.
        /// </summary>
        /// <returns>The <see cref="ITermsOfUseContainerAgreementsCollectionRequestBuilder"/>.</returns>
        ITermsOfUseContainerAgreementsCollectionRequestBuilder Agreements { get; }

        /// <summary>
        /// Gets the request builder for AgreementAcceptances.
        /// </summary>
        /// <returns>The <see cref="ITermsOfUseContainerAgreementAcceptancesCollectionRequestBuilder"/>.</returns>
        ITermsOfUseContainerAgreementAcceptancesCollectionRequestBuilder AgreementAcceptances { get; }
    
    }
}
