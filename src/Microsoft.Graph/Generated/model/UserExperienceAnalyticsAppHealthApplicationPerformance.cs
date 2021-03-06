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
    /// The type User Experience Analytics App Health Application Performance.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserExperienceAnalyticsAppHealthApplicationPerformance : Entity
    {
    
		///<summary>
		/// The UserExperienceAnalyticsAppHealthApplicationPerformance constructor
		///</summary>
        public UserExperienceAnalyticsAppHealthApplicationPerformance()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsAppHealthApplicationPerformance";
        }
	
        /// <summary>
        /// Gets or sets app name.
        /// The name of the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appName", Required = Newtonsoft.Json.Required.Default)]
        public string AppName { get; set; }
    
        /// <summary>
        /// Gets or sets app friendly name.
        /// The friendly name of the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appFriendlyName", Required = Newtonsoft.Json.Required.Default)]
        public string AppFriendlyName { get; set; }
    
        /// <summary>
        /// Gets or sets app publisher.
        /// The publisher of the application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appPublisher", Required = Newtonsoft.Json.Required.Default)]
        public string AppPublisher { get; set; }
    
        /// <summary>
        /// Gets or sets active devices.
        /// The number of devices where the app has been active. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeDevices", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ActiveDevices { get; set; }
    
        /// <summary>
        /// Gets or sets total app usage duration.
        /// The total usage time of the application in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalAppUsageDuration", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalAppUsageDuration { get; set; }
    
        /// <summary>
        /// Gets or sets total app crashes.
        /// The number of crashes for the app. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalAppCrashes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalAppCrashes { get; set; }
    
        /// <summary>
        /// Gets or sets total app hangs.
        /// The number of hangs for the app. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalAppHangs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalAppHangs { get; set; }
    
        /// <summary>
        /// Gets or sets mean time to failure.
        /// The mean time to failure for the app in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meanTimeToFailure", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MeanTimeToFailure { get; set; }
    
        /// <summary>
        /// Gets or sets app health score.
        /// The health score of the app. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appHealthScore", Required = Newtonsoft.Json.Required.Default)]
        public double? AppHealthScore { get; set; }
    
        /// <summary>
        /// Gets or sets app health status.
        /// The overall health status of the app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appHealthStatus", Required = Newtonsoft.Json.Required.Default)]
        public string AppHealthStatus { get; set; }
    
        /// <summary>
        /// Gets or sets all orgs health score.
        /// The median health score of the application across all organizations. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allOrgsHealthScore", Required = Newtonsoft.Json.Required.Default)]
        public double? AllOrgsHealthScore { get; set; }
    
        /// <summary>
        /// Gets or sets all orgs mean time to failure.
        /// The median mean time to failure across all orgs for the app in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allOrgsMeanTimeToFailure", Required = Newtonsoft.Json.Required.Default)]
        public Int32? AllOrgsMeanTimeToFailure { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// The id of the tenant associated with this app object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantId", Required = Newtonsoft.Json.Required.Default)]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets mema time generated.
        /// The time when aggregation was performed in MEMA.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memaTimeGenerated", Required = Newtonsoft.Json.Required.Default)]
        public string MemaTimeGenerated { get; set; }
    
    }
}

