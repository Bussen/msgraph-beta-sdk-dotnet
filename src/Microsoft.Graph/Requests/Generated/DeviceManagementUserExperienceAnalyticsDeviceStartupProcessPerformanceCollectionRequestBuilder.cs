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
    /// The type DeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformanceCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformanceCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformanceCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformanceCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformanceCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformanceCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformanceCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformanceCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder"/> for the specified DeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformance.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementUserExperienceAnalyticsDeviceStartupProcessPerformance.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsDeviceStartupProcessPerformanceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}