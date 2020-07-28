// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDriveItemRequestBuilder.
    /// </summary>
    public partial interface IDriveItemRequestBuilder : IBaseItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDriveItemRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDriveItemRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Workbook.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRequestBuilder"/>.</returns>
        IWorkbookRequestBuilder Workbook { get; }

        /// <summary>
        /// Gets the request builder for Activities.
        /// </summary>
        /// <returns>The <see cref="IDriveItemActivitiesCollectionRequestBuilder"/>.</returns>
        IDriveItemActivitiesCollectionRequestBuilder Activities { get; }

        /// <summary>
        /// Gets the request builder for Analytics.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsWithReferenceRequestBuilder"/>.</returns>
        IItemAnalyticsWithReferenceRequestBuilder Analytics { get; }

        /// <summary>
        /// Gets the request builder for Children.
        /// </summary>
        /// <returns>The <see cref="IDriveItemChildrenCollectionRequestBuilder"/>.</returns>
        IDriveItemChildrenCollectionRequestBuilder Children { get; }

        /// <summary>
        /// Gets the request builder for ListItem.
        /// </summary>
        /// <returns>The <see cref="IListItemRequestBuilder"/>.</returns>
        IListItemRequestBuilder ListItem { get; }

        /// <summary>
        /// Gets the request builder for Permissions.
        /// </summary>
        /// <returns>The <see cref="IDriveItemPermissionsCollectionRequestBuilder"/>.</returns>
        IDriveItemPermissionsCollectionRequestBuilder Permissions { get; }

        /// <summary>
        /// Gets the request builder for Subscriptions.
        /// </summary>
        /// <returns>The <see cref="IDriveItemSubscriptionsCollectionRequestBuilder"/>.</returns>
        IDriveItemSubscriptionsCollectionRequestBuilder Subscriptions { get; }

        /// <summary>
        /// Gets the request builder for Thumbnails.
        /// </summary>
        /// <returns>The <see cref="IDriveItemThumbnailsCollectionRequestBuilder"/>.</returns>
        IDriveItemThumbnailsCollectionRequestBuilder Thumbnails { get; }

        /// <summary>
        /// Gets the request builder for Versions.
        /// </summary>
        /// <returns>The <see cref="IDriveItemVersionsCollectionRequestBuilder"/>.</returns>
        IDriveItemVersionsCollectionRequestBuilder Versions { get; }
    
        /// <summary>
        /// Gets the request builder for Content.
        /// </summary>
        /// <returns>The <see cref="IDriveItemContentRequestBuilder"/>.</returns>
        IDriveItemContentRequestBuilder Content { get; }
    
        /// <summary>
        /// Gets the request builder for DriveItemCheckin.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCheckinRequestBuilder"/>.</returns>
        IDriveItemCheckinRequestBuilder Checkin(
            string checkInAs = null,
            string comment = null);

        /// <summary>
        /// Gets the request builder for DriveItemCheckout.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCheckoutRequestBuilder"/>.</returns>
        IDriveItemCheckoutRequestBuilder Checkout();

        /// <summary>
        /// Gets the request builder for DriveItemCopy.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCopyRequestBuilder"/>.</returns>
        IDriveItemCopyRequestBuilder Copy(
            string name = null,
            ItemReference parentReference = null);

        /// <summary>
        /// Gets the request builder for DriveItemCreateLink.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCreateLinkRequestBuilder"/>.</returns>
        IDriveItemCreateLinkRequestBuilder CreateLink(
            string type,
            string scope = null,
            DateTimeOffset? expirationDateTime = null,
            string password = null,
            string message = null,
            IEnumerable<DriveRecipient> recipients = null);

        /// <summary>
        /// Gets the request builder for DriveItemCreateUploadSession.
        /// </summary>
        /// <returns>The <see cref="IDriveItemCreateUploadSessionRequestBuilder"/>.</returns>
        IDriveItemCreateUploadSessionRequestBuilder CreateUploadSession(
            DriveItemUploadableProperties item = null);

        /// <summary>
        /// Gets the request builder for DriveItemFollow.
        /// </summary>
        /// <returns>The <see cref="IDriveItemFollowRequestBuilder"/>.</returns>
        IDriveItemFollowRequestBuilder Follow();

        /// <summary>
        /// Gets the request builder for DriveItemUnfollow.
        /// </summary>
        /// <returns>The <see cref="IDriveItemUnfollowRequestBuilder"/>.</returns>
        IDriveItemUnfollowRequestBuilder Unfollow();

        /// <summary>
        /// Gets the request builder for DriveItemInvite.
        /// </summary>
        /// <returns>The <see cref="IDriveItemInviteRequestBuilder"/>.</returns>
        IDriveItemInviteRequestBuilder Invite(
            IEnumerable<DriveRecipient> recipients,
            bool? requireSignIn = null,
            IEnumerable<string> roles = null,
            bool? sendInvitation = null,
            string message = null,
            string expirationDateTime = null,
            string password = null);

        /// <summary>
        /// Gets the request builder for DriveItemPreview.
        /// </summary>
        /// <returns>The <see cref="IDriveItemPreviewRequestBuilder"/>.</returns>
        IDriveItemPreviewRequestBuilder Preview(
            string viewer = null,
            bool? chromeless = null,
            bool? allowEdit = null,
            string page = null,
            double? zoom = null);

        /// <summary>
        /// Gets the request builder for DriveItemRestore.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRestoreRequestBuilder"/>.</returns>
        IDriveItemRestoreRequestBuilder Restore(
            ItemReference parentReference = null,
            string name = null);

        /// <summary>
        /// Gets the request builder for DriveItemValidatePermission.
        /// </summary>
        /// <returns>The <see cref="IDriveItemValidatePermissionRequestBuilder"/>.</returns>
        IDriveItemValidatePermissionRequestBuilder ValidatePermission(
            string password,
            string challengeToken = null);

        /// <summary>
        /// Gets the request builder for DriveItemDelta.
        /// </summary>
        /// <returns>The <see cref="IDriveItemDeltaRequestBuilder"/>.</returns>
        IDriveItemDeltaRequestBuilder Delta(
            string token = null);

        /// <summary>
        /// Gets the request builder for DriveItemDelta.
        /// </summary>
        /// <returns>The <see cref="IDriveItemDeltaRequestBuilder"/>.</returns>
        IDriveItemDeltaRequestBuilder Delta();

        /// <summary>
        /// Gets the request builder for DriveItemGetActivitiesByInterval.
        /// </summary>
        /// <returns>The <see cref="IDriveItemGetActivitiesByIntervalRequestBuilder"/>.</returns>
        IDriveItemGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval(
            string startDateTime = null,
            string endDateTime = null,
            string interval = null);

        /// <summary>
        /// Gets the request builder for DriveItemSearch.
        /// </summary>
        /// <returns>The <see cref="IDriveItemSearchRequestBuilder"/>.</returns>
        IDriveItemSearchRequestBuilder Search(
            string q = null);
    
    }
}
