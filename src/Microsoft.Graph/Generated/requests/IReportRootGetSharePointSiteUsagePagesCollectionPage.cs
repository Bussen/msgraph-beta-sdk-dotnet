// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IReportRootGetSharePointSiteUsagePagesCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<ReportRootGetSharePointSiteUsagePagesCollectionPage>))]
    public interface IReportRootGetSharePointSiteUsagePagesCollectionPage : ICollectionPage<SharePointSiteUsagePages>
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootGetSharePointSiteUsagePagesRequest"/> instance.
        /// </summary>
        IReportRootGetSharePointSiteUsagePagesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
