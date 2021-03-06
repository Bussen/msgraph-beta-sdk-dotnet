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
    /// The type RegionalFormatOverrides.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class RegionalFormatOverrides
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalFormatOverrides"/> class.
        /// </summary>
        public RegionalFormatOverrides()
        {
            this.ODataType = "microsoft.graph.regionalFormatOverrides";
        }

        /// <summary>
        /// Gets or sets calendar.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendar", Required = Newtonsoft.Json.Required.Default)]
        public string Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets firstDayOfWeek.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firstDayOfWeek", Required = Newtonsoft.Json.Required.Default)]
        public string FirstDayOfWeek { get; set; }
    
        /// <summary>
        /// Gets or sets shortDateFormat.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shortDateFormat", Required = Newtonsoft.Json.Required.Default)]
        public string ShortDateFormat { get; set; }
    
        /// <summary>
        /// Gets or sets longDateFormat.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "longDateFormat", Required = Newtonsoft.Json.Required.Default)]
        public string LongDateFormat { get; set; }
    
        /// <summary>
        /// Gets or sets shortTimeFormat.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shortTimeFormat", Required = Newtonsoft.Json.Required.Default)]
        public string ShortTimeFormat { get; set; }
    
        /// <summary>
        /// Gets or sets longTimeFormat.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "longTimeFormat", Required = Newtonsoft.Json.Required.Default)]
        public string LongTimeFormat { get; set; }
    
        /// <summary>
        /// Gets or sets timeZone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeZone", Required = Newtonsoft.Json.Required.Default)]
        public string TimeZone { get; set; }
    
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
