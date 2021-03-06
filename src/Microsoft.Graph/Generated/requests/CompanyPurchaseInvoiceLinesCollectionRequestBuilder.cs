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
    /// The type CompanyPurchaseInvoiceLinesCollectionRequestBuilder.
    /// </summary>
    public partial class CompanyPurchaseInvoiceLinesCollectionRequestBuilder : BaseRequestBuilder, ICompanyPurchaseInvoiceLinesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanyPurchaseInvoiceLinesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanyPurchaseInvoiceLinesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanyPurchaseInvoiceLinesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanyPurchaseInvoiceLinesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanyPurchaseInvoiceLinesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPurchaseInvoiceLineRequestBuilder"/> for the specified CompanyPurchaseInvoiceLine.
        /// </summary>
        /// <param name="id">The ID for the CompanyPurchaseInvoiceLine.</param>
        /// <returns>The <see cref="IPurchaseInvoiceLineRequestBuilder"/>.</returns>
        public IPurchaseInvoiceLineRequestBuilder this[string id]
        {
            get
            {
                return new PurchaseInvoiceLineRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
