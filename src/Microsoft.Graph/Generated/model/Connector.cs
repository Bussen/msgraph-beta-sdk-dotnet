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
    /// The type Connector.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Connector : Entity
    {
    
		///<summary>
		/// The Connector constructor
		///</summary>
        public Connector()
        {
            this.ODataType = "microsoft.graph.connector";
        }
	
        /// <summary>
        /// Gets or sets machine name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "machineName", Required = Newtonsoft.Json.Required.Default)]
        public string MachineName { get; set; }
    
        /// <summary>
        /// Gets or sets external ip.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalIp", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalIp { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public ConnectorStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberOf", Required = Newtonsoft.Json.Required.Default)]
        public IConnectorMemberOfCollectionWithReferencesPage MemberOf { get; set; }
    
    }
}

