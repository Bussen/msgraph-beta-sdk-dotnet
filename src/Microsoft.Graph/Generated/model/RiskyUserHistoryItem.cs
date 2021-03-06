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
    /// The type Risky User History Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RiskyUserHistoryItem : RiskyUser
    {
    
		///<summary>
		/// The RiskyUserHistoryItem constructor
		///</summary>
        public RiskyUserHistoryItem()
        {
            this.ODataType = "microsoft.graph.riskyUserHistoryItem";
        }
	
        /// <summary>
        /// Gets or sets user id.
        /// The id of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets initiated by.
        /// The id of actor that does the operation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initiatedBy", Required = Newtonsoft.Json.Required.Default)]
        public string InitiatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets activity.
        /// The activity related to user risk level change.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activity", Required = Newtonsoft.Json.Required.Default)]
        public RiskUserActivity Activity { get; set; }
    
    }
}

