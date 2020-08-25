// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ConnectorMemberOfCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ConnectorMemberOfCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IConnectorMemberOfCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ConnectorMemberOfCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ConnectorMemberOfCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IConnectorMemberOfCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IConnectorMemberOfCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ConnectorMemberOfCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IConnectorGroupWithReferenceRequestBuilder"/> for the specified ConnectorConnectorGroup.
        /// </summary>
        /// <param name="id">The ID for the ConnectorConnectorGroup.</param>
        /// <returns>The <see cref="IConnectorGroupWithReferenceRequestBuilder"/>.</returns>
        public IConnectorGroupWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new ConnectorGroupWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IConnectorMemberOfCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IConnectorMemberOfCollectionReferencesRequestBuilder"/>.</returns>
        public IConnectorMemberOfCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ConnectorMemberOfCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}