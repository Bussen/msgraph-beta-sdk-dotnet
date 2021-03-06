// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type TermChildrenCollectionRequestBuilder.
    /// </summary>
    public partial class TermChildrenCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ITermChildrenCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TermChildrenCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public TermChildrenCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITermChildrenCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITermChildrenCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new TermChildrenCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITermRequestBuilder"/> for the specified TermTerm.
        /// </summary>
        /// <param name="id">The ID for the TermTerm.</param>
        /// <returns>The <see cref="ITermRequestBuilder"/>.</returns>
        public ITermRequestBuilder this[string id]
        {
            get
            {
                return new TermRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
