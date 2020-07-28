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
    /// The type AgreementFileLocalizationsCollectionRequestBuilder.
    /// </summary>
    public partial class AgreementFileLocalizationsCollectionRequestBuilder : BaseRequestBuilder, IAgreementFileLocalizationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AgreementFileLocalizationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AgreementFileLocalizationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAgreementFileLocalizationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAgreementFileLocalizationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AgreementFileLocalizationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAgreementFileLocalizationRequestBuilder"/> for the specified AgreementFileAgreementFileLocalization.
        /// </summary>
        /// <param name="id">The ID for the AgreementFileAgreementFileLocalization.</param>
        /// <returns>The <see cref="IAgreementFileLocalizationRequestBuilder"/>.</returns>
        public IAgreementFileLocalizationRequestBuilder this[string id]
        {
            get
            {
                return new AgreementFileLocalizationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
