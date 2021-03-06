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
    /// The type Device Compliance Script Run Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceComplianceScriptRunSummary : Entity
    {
    
		///<summary>
		/// The DeviceComplianceScriptRunSummary constructor
		///</summary>
        public DeviceComplianceScriptRunSummary()
        {
            this.ODataType = "microsoft.graph.deviceComplianceScriptRunSummary";
        }
	
        /// <summary>
        /// Gets or sets no issue detected device count.
        /// Number of devices for which the detection script did not find an issue and the device is healthy. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "noIssueDetectedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NoIssueDetectedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets issue detected device count.
        /// Number of devices for which the detection script found an issue. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issueDetectedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? IssueDetectedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets detection script error device count.
        /// Number of devices on which the detection script execution encountered an error and did not complete. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionScriptErrorDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DetectionScriptErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets detection script pending device count.
        /// Number of devices which have not yet run the latest version of the device compliance script. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionScriptPendingDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DetectionScriptPendingDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets last script run date time.
        /// Last run time for the script across all devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastScriptRunDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastScriptRunDateTime { get; set; }
    
    }
}

