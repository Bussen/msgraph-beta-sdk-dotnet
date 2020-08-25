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
    /// The type CompanySalesInvoicesCollectionRequestBuilder.
    /// </summary>
    public partial class CompanySalesInvoicesCollectionRequestBuilder : BaseRequestBuilder, ICompanySalesInvoicesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanySalesInvoicesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanySalesInvoicesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanySalesInvoicesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanySalesInvoicesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanySalesInvoicesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISalesInvoiceRequestBuilder"/> for the specified CompanySalesInvoice.
        /// </summary>
        /// <param name="id">The ID for the CompanySalesInvoice.</param>
        /// <returns>The <see cref="ISalesInvoiceRequestBuilder"/>.</returns>
        public ISalesInvoiceRequestBuilder this[string id]
        {
            get
            {
                return new SalesInvoiceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}