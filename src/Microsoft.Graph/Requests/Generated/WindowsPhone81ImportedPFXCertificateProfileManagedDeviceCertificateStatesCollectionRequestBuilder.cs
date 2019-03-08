// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder.
    /// </summary>
    public partial class WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder : BaseRequestBuilder, IWindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedDeviceCertificateStateRequestBuilder"/> for the specified WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateState.
        /// </summary>
        /// <param name="id">The ID for the WindowsPhone81ImportedPFXCertificateProfileManagedDeviceCertificateState.</param>
        /// <returns>The <see cref="IManagedDeviceCertificateStateRequestBuilder"/>.</returns>
        public IManagedDeviceCertificateStateRequestBuilder this[string id]
        {
            get
            {
                return new ManagedDeviceCertificateStateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}