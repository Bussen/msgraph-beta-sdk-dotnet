// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeliveryOptimizationBandwidthPercentage.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeliveryOptimizationBandwidthPercentage : DeliveryOptimizationBandwidth
    {
        public DeliveryOptimizationBandwidthPercentage()
        {
            this.ODataType = "microsoft.graph.deliveryOptimizationBandwidthPercentage";
        }
        /// <summary>
        /// Gets or sets maximumBackgroundBandwidthPercentage.
        /// The default value 0 (zero) means that Delivery Optimization dynamically adjusts to use the available bandwidth for background downloads. Valid values 0 to 100
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumBackgroundBandwidthPercentage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaximumBackgroundBandwidthPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets maximumForegroundBandwidthPercentage.
        /// The default value 0 (zero) means that Delivery Optimization dynamically adjusts to use the available bandwidth for foreground downloads. Valid values 0 to 100
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumForegroundBandwidthPercentage", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaximumForegroundBandwidthPercentage { get; set; }
    
    }
}