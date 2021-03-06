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
    /// The type DeviceComplianceScriptAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceComplianceScriptAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IDeviceComplianceScriptAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceComplianceScriptAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceComplianceScriptAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceComplianceScriptAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceComplianceScriptAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceComplianceScriptAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceHealthScriptAssignmentRequestBuilder"/> for the specified DeviceComplianceScriptDeviceHealthScriptAssignment.
        /// </summary>
        /// <param name="id">The ID for the DeviceComplianceScriptDeviceHealthScriptAssignment.</param>
        /// <returns>The <see cref="IDeviceHealthScriptAssignmentRequestBuilder"/>.</returns>
        public IDeviceHealthScriptAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new DeviceHealthScriptAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
