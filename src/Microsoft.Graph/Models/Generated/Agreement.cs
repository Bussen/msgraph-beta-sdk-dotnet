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
    /// The type Agreement.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Agreement : Entity
    {
    
		///<summary>
		/// The Agreement constructor
		///</summary>
        public Agreement()
        {
            this.ODataType = "microsoft.graph.agreement";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets terms expiration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsExpiration", Required = Newtonsoft.Json.Required.Default)]
        public TermsExpiration TermsExpiration { get; set; }
    
        /// <summary>
        /// Gets or sets user reaccept required frequency.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userReacceptRequiredFrequency", Required = Newtonsoft.Json.Required.Default)]
        public Duration UserReacceptRequiredFrequency { get; set; }
    
        /// <summary>
        /// Gets or sets is viewing before acceptance required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isViewingBeforeAcceptanceRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsViewingBeforeAcceptanceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets is per device acceptance required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isPerDeviceAcceptanceRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsPerDeviceAcceptanceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "file", Required = Newtonsoft.Json.Required.Default)]
        public AgreementFile File { get; set; }
    
        /// <summary>
        /// Gets or sets files.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "files", Required = Newtonsoft.Json.Required.Default)]
        public IAgreementFilesCollectionPage Files { get; set; }
    
        /// <summary>
        /// Gets or sets acceptances.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "acceptances", Required = Newtonsoft.Json.Required.Default)]
        public IAgreementAcceptancesCollectionPage Acceptances { get; set; }
    
    }
}

