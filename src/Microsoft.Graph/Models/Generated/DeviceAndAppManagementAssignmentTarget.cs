// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceAndAppManagementAssignmentTarget.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public abstract partial class DeviceAndAppManagementAssignmentTarget
    {

        /// <summary>
        /// Gets or sets deviceAndAppManagementAssignmentFilterId.
        /// The Id of the filter for the target assignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceAndAppManagementAssignmentFilterId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceAndAppManagementAssignmentFilterId { get; set; }
    
        /// <summary>
        /// Gets or sets deviceAndAppManagementAssignmentFilterType.
        /// The type of filter of the target assignment i.e. Exclude or Include.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceAndAppManagementAssignmentFilterType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceAndAppManagementAssignmentFilterType? DeviceAndAppManagementAssignmentFilterType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
