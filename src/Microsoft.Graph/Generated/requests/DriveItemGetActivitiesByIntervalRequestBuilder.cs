// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DriveItemGetActivitiesByIntervalRequestBuilder.
    /// </summary>
    public partial class DriveItemGetActivitiesByIntervalRequestBuilder : BaseFunctionMethodRequestBuilder<IDriveItemGetActivitiesByIntervalRequest>, IDriveItemGetActivitiesByIntervalRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DriveItemGetActivitiesByIntervalRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="startDateTime">A startDateTime parameter for the OData method call.</param>
        /// <param name="endDateTime">A endDateTime parameter for the OData method call.</param>
        /// <param name="interval">A interval parameter for the OData method call.</param>
        public DriveItemGetActivitiesByIntervalRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string startDateTime,
            string endDateTime,
            string interval)
            : base(requestUrl, client)
        {
            this.SetParameter("startDateTime", startDateTime, true);
            this.SetParameter("endDateTime", endDateTime, true);
            this.SetParameter("interval", interval, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDriveItemGetActivitiesByIntervalRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DriveItemGetActivitiesByIntervalRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
