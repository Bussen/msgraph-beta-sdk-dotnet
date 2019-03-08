// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DirectoryObjectGetUserOwnedObjectsRequestBuilder.
    /// </summary>
    public partial class DirectoryObjectGetUserOwnedObjectsRequestBuilder : BaseActionMethodRequestBuilder<IDirectoryObjectGetUserOwnedObjectsRequest>, IDirectoryObjectGetUserOwnedObjectsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DirectoryObjectGetUserOwnedObjectsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="userId">A userId parameter for the OData method call.</param>
        /// <param name="type">A type parameter for the OData method call.</param>
        public DirectoryObjectGetUserOwnedObjectsRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string userId,
            string type)
            : base(requestUrl, client)
        {
            this.SetParameter("userId", userId, true);
            this.SetParameter("type", type, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDirectoryObjectGetUserOwnedObjectsRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DirectoryObjectGetUserOwnedObjectsRequest(functionUrl, this.Client, options);

            if (this.HasParameter("userId"))
            {
                request.RequestBody.UserId = this.GetParameter<string>("userId");
            }

            if (this.HasParameter("type"))
            {
                request.RequestBody.Type = this.GetParameter<string>("type");
            }

            return request;
        }
    }
}