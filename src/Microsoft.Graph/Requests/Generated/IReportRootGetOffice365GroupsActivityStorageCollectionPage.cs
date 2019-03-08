// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IReportRootGetOffice365GroupsActivityStorageCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<ReportRootGetOffice365GroupsActivityStorageCollectionPage>))]
    public interface IReportRootGetOffice365GroupsActivityStorageCollectionPage : ICollectionPage<Office365GroupsActivityStorage>
    {
        /// <summary>
        /// Gets the next page <see cref="IReportRootGetOffice365GroupsActivityStorageRequest"/> instance.
        /// </summary>
        IReportRootGetOffice365GroupsActivityStorageRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}