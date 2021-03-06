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
    /// The type PrintJobRequestBuilder.
    /// </summary>
    public partial class PrintJobRequestBuilder : EntityRequestBuilder, IPrintJobRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrintJobRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrintJobRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPrintJobRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPrintJobRequest Request(IEnumerable<Option> options)
        {
            return new PrintJobRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Documents.
        /// </summary>
        /// <returns>The <see cref="IPrintJobDocumentsCollectionRequestBuilder"/>.</returns>
        public IPrintJobDocumentsCollectionRequestBuilder Documents
        {
            get
            {
                return new PrintJobDocumentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("documents"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IPrintJobTasksCollectionRequestBuilder"/>.</returns>
        public IPrintJobTasksCollectionRequestBuilder Tasks
        {
            get
            {
                return new PrintJobTasksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for PrintJobCancelPrintJob.
        /// </summary>
        /// <returns>The <see cref="IPrintJobCancelPrintJobRequestBuilder"/>.</returns>
        public IPrintJobCancelPrintJobRequestBuilder CancelPrintJob()
        {
            return new PrintJobCancelPrintJobRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.cancelPrintJob"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for PrintJobStartPrintJob.
        /// </summary>
        /// <returns>The <see cref="IPrintJobStartPrintJobRequestBuilder"/>.</returns>
        public IPrintJobStartPrintJobRequestBuilder StartPrintJob()
        {
            return new PrintJobStartPrintJobRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.startPrintJob"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for PrintJobRedirect.
        /// </summary>
        /// <returns>The <see cref="IPrintJobRedirectRequestBuilder"/>.</returns>
        public IPrintJobRedirectRequestBuilder Redirect(
            string destinationPrinterId = null)
        {
            return new PrintJobRedirectRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.redirect"),
                this.Client,
                destinationPrinterId);
        }
    
    }
}
