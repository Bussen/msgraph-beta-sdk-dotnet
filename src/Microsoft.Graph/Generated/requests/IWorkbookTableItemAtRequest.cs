// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookTableItemAtRequest.
    /// </summary>
    public partial interface IWorkbookTableItemAtRequest : IBaseRequest
    {


        /// <summary>
        /// Issues the GET request.
        /// </summary>
        System.Threading.Tasks.Task<WorkbookTable> GetAsync();

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookTable> GetAsync(
            CancellationToken cancellationToken);



        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbooktable">The WorkbookTable object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookTable> PatchAsync(WorkbookTable workbooktable);

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbooktable">The WorkbookTable object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookTable> PatchAsync(WorkbookTable workbooktable, 
            CancellationToken cancellationToken);


        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbooktable">The WorkbookTable object to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookTable> PutAsync(WorkbookTable workbooktable);

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbooktable">The WorkbookTable object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<WorkbookTable> PutAsync(WorkbookTable workbooktable, 
            CancellationToken cancellationToken);




        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableItemAtRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableItemAtRequest Select(string value);
    }
}
