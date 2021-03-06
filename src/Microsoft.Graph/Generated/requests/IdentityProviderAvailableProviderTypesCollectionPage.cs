// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type IdentityProviderAvailableProviderTypesCollectionPage.
    /// </summary>
    public partial class IdentityProviderAvailableProviderTypesCollectionPage : CollectionPage<string>, IIdentityProviderAvailableProviderTypesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IIdentityProviderAvailableProviderTypesRequest"/> instance.
        /// </summary>
        public IIdentityProviderAvailableProviderTypesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new IdentityProviderAvailableProviderTypesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
