// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionPage.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;

    /// <summary>
    /// The type TermRelationsCollectionPage.
    /// </summary>
    public partial class TermRelationsCollectionPage : Microsoft.Graph.CollectionPage<Relation>, ITermRelationsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="ITermRelationsCollectionRequest"/> instance.
        /// </summary>
        public ITermRelationsCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new TermRelationsCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
