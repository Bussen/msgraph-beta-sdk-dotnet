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
    /// The type Identity Governance.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IdentityGovernance : Entity
    {
    
		///<summary>
		/// The IdentityGovernance constructor
		///</summary>
        public IdentityGovernance()
        {
            this.ODataType = "microsoft.graph.identityGovernance";
        }
	
        /// <summary>
        /// Gets or sets entitlement management.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "entitlementManagement", Required = Newtonsoft.Json.Required.Default)]
        public EntitlementManagement EntitlementManagement { get; set; }
    
        /// <summary>
        /// Gets or sets access reviews.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessReviews", Required = Newtonsoft.Json.Required.Default)]
        public AccessReviewSet AccessReviews { get; set; }
    
        /// <summary>
        /// Gets or sets terms of use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsOfUse", Required = Newtonsoft.Json.Required.Default)]
        public TermsOfUseContainer TermsOfUse { get; set; }
    
    }
}

