// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SetRequestBuilder.
    /// </summary>
    public partial class SetRequestBuilder : Microsoft.Graph.EntityRequestBuilder, ISetRequestBuilder
    {

        /// <summary>
        /// Constructs a new SetRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public SetRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISetRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISetRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new SetRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ParentGroup.
        /// </summary>
        /// <returns>The <see cref="IGroupRequestBuilder"/>.</returns>
        public IGroupRequestBuilder ParentGroup
        {
            get
            {
                return new GroupRequestBuilder(this.AppendSegmentToRequestUrl("parentGroup"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Terms.
        /// </summary>
        /// <returns>The <see cref="ISetTermsCollectionRequestBuilder"/>.</returns>
        public ISetTermsCollectionRequestBuilder Terms
        {
            get
            {
                return new SetTermsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("terms"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Relations.
        /// </summary>
        /// <returns>The <see cref="ISetRelationsCollectionRequestBuilder"/>.</returns>
        public ISetRelationsCollectionRequestBuilder Relations
        {
            get
            {
                return new SetRelationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("relations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Children.
        /// </summary>
        /// <returns>The <see cref="ISetChildrenCollectionRequestBuilder"/>.</returns>
        public ISetChildrenCollectionRequestBuilder Children
        {
            get
            {
                return new SetChildrenCollectionRequestBuilder(this.AppendSegmentToRequestUrl("children"), this.Client);
            }
        }
    
    }
}
