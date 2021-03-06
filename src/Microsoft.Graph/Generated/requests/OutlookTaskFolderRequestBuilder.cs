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
    /// The type OutlookTaskFolderRequestBuilder.
    /// </summary>
    public partial class OutlookTaskFolderRequestBuilder : EntityRequestBuilder, IOutlookTaskFolderRequestBuilder
    {

        /// <summary>
        /// Constructs a new OutlookTaskFolderRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OutlookTaskFolderRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOutlookTaskFolderRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOutlookTaskFolderRequest Request(IEnumerable<Option> options)
        {
            return new OutlookTaskFolderRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskFolderTasksCollectionRequestBuilder"/>.</returns>
        public IOutlookTaskFolderTasksCollectionRequestBuilder Tasks
        {
            get
            {
                return new OutlookTaskFolderTasksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskFolderSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IOutlookTaskFolderSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties
        {
            get
            {
                return new OutlookTaskFolderSingleValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("singleValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IOutlookTaskFolderMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IOutlookTaskFolderMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties
        {
            get
            {
                return new OutlookTaskFolderMultiValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("multiValueExtendedProperties"), this.Client);
            }
        }
    
    }
}
