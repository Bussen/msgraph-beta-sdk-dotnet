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
    /// The type WindowsAutopilotDeploymentProfileRequestBuilder.
    /// </summary>
    public partial class WindowsAutopilotDeploymentProfileRequestBuilder : EntityRequestBuilder, IWindowsAutopilotDeploymentProfileRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsAutopilotDeploymentProfileRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsAutopilotDeploymentProfileRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWindowsAutopilotDeploymentProfileRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWindowsAutopilotDeploymentProfileRequest Request(IEnumerable<Option> options)
        {
            return new WindowsAutopilotDeploymentProfileRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AssignedDevices.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileAssignedDevicesCollectionRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeploymentProfileAssignedDevicesCollectionRequestBuilder AssignedDevices
        {
            get
            {
                return new WindowsAutopilotDeploymentProfileAssignedDevicesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignedDevices"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new WindowsAutopilotDeploymentProfileAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeploymentProfileAssign.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileAssignRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeploymentProfileAssignRequestBuilder Assign(
            IEnumerable<string> deviceIds = null)
        {
            return new WindowsAutopilotDeploymentProfileAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                deviceIds);
        }
    
    }
}
