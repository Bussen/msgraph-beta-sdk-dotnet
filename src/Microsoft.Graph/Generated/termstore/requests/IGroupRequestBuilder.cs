// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IGroupRequestBuilder.
    /// </summary>
    public partial interface IGroupRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IGroupRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IGroupRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for Sets.
        /// </summary>
        /// <returns>The <see cref="IGroupSetsCollectionRequestBuilder"/>.</returns>
        IGroupSetsCollectionRequestBuilder Sets { get; }
    
    }
}