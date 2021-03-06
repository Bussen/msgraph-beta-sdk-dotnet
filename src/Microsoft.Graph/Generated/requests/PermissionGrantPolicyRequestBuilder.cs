// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type PermissionGrantPolicyRequestBuilder.
    /// </summary>
    public partial class PermissionGrantPolicyRequestBuilder : PolicyBaseRequestBuilder, IPermissionGrantPolicyRequestBuilder
    {

        /// <summary>
        /// Constructs a new PermissionGrantPolicyRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PermissionGrantPolicyRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPermissionGrantPolicyRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPermissionGrantPolicyRequest Request(IEnumerable<Option> options)
        {
            return new PermissionGrantPolicyRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Includes.
        /// </summary>
        /// <returns>The <see cref="IPermissionGrantPolicyIncludesCollectionRequestBuilder"/>.</returns>
        public IPermissionGrantPolicyIncludesCollectionRequestBuilder Includes
        {
            get
            {
                return new PermissionGrantPolicyIncludesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("includes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Excludes.
        /// </summary>
        /// <returns>The <see cref="IPermissionGrantPolicyExcludesCollectionRequestBuilder"/>.</returns>
        public IPermissionGrantPolicyExcludesCollectionRequestBuilder Excludes
        {
            get
            {
                return new PermissionGrantPolicyExcludesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("excludes"), this.Client);
            }
        }
    
    }
}
