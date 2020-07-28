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
    /// The interface IApplicationRequestBuilder.
    /// </summary>
    public partial interface IApplicationRequestBuilder : IDirectoryObjectRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IApplicationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IApplicationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ExtensionProperties.
        /// </summary>
        /// <returns>The <see cref="IApplicationExtensionPropertiesCollectionRequestBuilder"/>.</returns>
        IApplicationExtensionPropertiesCollectionRequestBuilder ExtensionProperties { get; }

        /// <summary>
        /// Gets the request builder for CreatedOnBehalfOf.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder CreatedOnBehalfOf { get; }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="IApplicationOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        IApplicationOwnersCollectionWithReferencesRequestBuilder Owners { get; }

        /// <summary>
        /// Gets the request builder for HomeRealmDiscoveryPolicies.
        /// </summary>
        /// <returns>The <see cref="IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        IApplicationHomeRealmDiscoveryPoliciesCollectionWithReferencesRequestBuilder HomeRealmDiscoveryPolicies { get; }

        /// <summary>
        /// Gets the request builder for TokenIssuancePolicies.
        /// </summary>
        /// <returns>The <see cref="IApplicationTokenIssuancePoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        IApplicationTokenIssuancePoliciesCollectionWithReferencesRequestBuilder TokenIssuancePolicies { get; }

        /// <summary>
        /// Gets the request builder for TokenLifetimePolicies.
        /// </summary>
        /// <returns>The <see cref="IApplicationTokenLifetimePoliciesCollectionWithReferencesRequestBuilder"/>.</returns>
        IApplicationTokenLifetimePoliciesCollectionWithReferencesRequestBuilder TokenLifetimePolicies { get; }

        /// <summary>
        /// Gets the request builder for ConnectorGroup.
        /// </summary>
        /// <returns>The <see cref="IConnectorGroupWithReferenceRequestBuilder"/>.</returns>
        IConnectorGroupWithReferenceRequestBuilder ConnectorGroup { get; }

        /// <summary>
        /// Gets the request builder for Synchronization.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationRequestBuilder"/>.</returns>
        ISynchronizationRequestBuilder Synchronization { get; }
    
        /// <summary>
        /// Gets the request builder for Logo.
        /// </summary>
        /// <returns>The <see cref="IApplicationLogoRequestBuilder"/>.</returns>
        IApplicationLogoRequestBuilder Logo { get; }
    
        /// <summary>
        /// Gets the request builder for ApplicationAddKey.
        /// </summary>
        /// <returns>The <see cref="IApplicationAddKeyRequestBuilder"/>.</returns>
        IApplicationAddKeyRequestBuilder AddKey(
            KeyCredential keyCredential,
            string proof,
            PasswordCredential passwordCredential = null);

        /// <summary>
        /// Gets the request builder for ApplicationAddPassword.
        /// </summary>
        /// <returns>The <see cref="IApplicationAddPasswordRequestBuilder"/>.</returns>
        IApplicationAddPasswordRequestBuilder AddPassword(
            PasswordCredential passwordCredential = null);

        /// <summary>
        /// Gets the request builder for ApplicationRemoveKey.
        /// </summary>
        /// <returns>The <see cref="IApplicationRemoveKeyRequestBuilder"/>.</returns>
        IApplicationRemoveKeyRequestBuilder RemoveKey(
            Guid keyId,
            string proof);

        /// <summary>
        /// Gets the request builder for ApplicationRemovePassword.
        /// </summary>
        /// <returns>The <see cref="IApplicationRemovePasswordRequestBuilder"/>.</returns>
        IApplicationRemovePasswordRequestBuilder RemovePassword(
            Guid keyId);
    
    }
}
