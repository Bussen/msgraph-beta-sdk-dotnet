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
    /// The type Managed EBook Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedEBookAssignment : Entity
    {
    
		///<summary>
		/// The ManagedEBookAssignment constructor
		///</summary>
        public ManagedEBookAssignment()
        {
            this.ODataType = "microsoft.graph.managedEBookAssignment";
        }
	
        /// <summary>
        /// Gets or sets target.
        /// The assignment target for eBook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target", Required = Newtonsoft.Json.Required.Default)]
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
    
        /// <summary>
        /// Gets or sets install intent.
        /// The install intent for eBook. Possible values are: available, required, uninstall, availableWithoutEnrollment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "installIntent", Required = Newtonsoft.Json.Required.Default)]
        public InstallIntent? InstallIntent { get; set; }
    
    }
}

