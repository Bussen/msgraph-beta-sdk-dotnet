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
    /// The type VendorPictureCollectionRequestBuilder.
    /// </summary>
    public partial class VendorPictureCollectionRequestBuilder : BaseRequestBuilder, IVendorPictureCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new VendorPictureCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public VendorPictureCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IVendorPictureCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IVendorPictureCollectionRequest Request(IEnumerable<Option> options)
        {
            return new VendorPictureCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPictureRequestBuilder"/> for the specified VendorPicture.
        /// </summary>
        /// <param name="id">The ID for the VendorPicture.</param>
        /// <returns>The <see cref="IPictureRequestBuilder"/>.</returns>
        public IPictureRequestBuilder this[string id]
        {
            get
            {
                return new PictureRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
