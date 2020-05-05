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
    /// The type PrinterShareAllowedGroupsCollectionRequestBuilder.
    /// </summary>
    public partial class PrinterShareAllowedGroupsCollectionRequestBuilder : BaseRequestBuilder, IPrinterShareAllowedGroupsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PrinterShareAllowedGroupsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrinterShareAllowedGroupsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPrinterShareAllowedGroupsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPrinterShareAllowedGroupsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PrinterShareAllowedGroupsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPrintIdentityRequestBuilder"/> for the specified PrinterSharePrintIdentity.
        /// </summary>
        /// <param name="id">The ID for the PrinterSharePrintIdentity.</param>
        /// <returns>The <see cref="IPrintIdentityRequestBuilder"/>.</returns>
        public IPrintIdentityRequestBuilder this[string id]
        {
            get
            {
                return new PrintIdentityRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}