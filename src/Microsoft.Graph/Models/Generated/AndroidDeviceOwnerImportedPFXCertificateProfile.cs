// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Android Device Owner Imported PFXCertificate Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidDeviceOwnerImportedPFXCertificateProfile : AndroidDeviceOwnerCertificateProfileBase
    {
    
		///<summary>
		/// The AndroidDeviceOwnerImportedPFXCertificateProfile constructor
		///</summary>
        public AndroidDeviceOwnerImportedPFXCertificateProfile()
        {
            this.ODataType = "microsoft.graph.androidDeviceOwnerImportedPFXCertificateProfile";
        }
	
        /// <summary>
        /// Gets or sets intended purpose.
        /// Intended Purpose of the Certificate Profile - which could be Unassigned, SmimeEncryption, SmimeSigning etc.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intendedPurpose", Required = Newtonsoft.Json.Required.Default)]
        public IntendedPurpose? IntendedPurpose { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// Certificate state for devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceCertificateStates", Required = Newtonsoft.Json.Required.Default)]
        public IAndroidDeviceOwnerImportedPFXCertificateProfileManagedDeviceCertificateStatesCollectionPage ManagedDeviceCertificateStates { get; set; }
    
    }
}
