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
    /// The type AppLogCollectionDownloadDetails.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AppLogCollectionDownloadDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppLogCollectionDownloadDetails"/> class.
        /// </summary>
        public AppLogCollectionDownloadDetails()
        {
            this.ODataType = "microsoft.graph.appLogCollectionDownloadDetails";
        }

        /// <summary>
        /// Gets or sets downloadUrl.
        /// Download SAS Url for completed AppLogUploadRequest
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "downloadUrl", Required = Newtonsoft.Json.Required.Default)]
        public string DownloadUrl { get; set; }
    
        /// <summary>
        /// Gets or sets decryptionKey.
        /// DecryptionKey as string
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "decryptionKey", Required = Newtonsoft.Json.Required.Default)]
        public string DecryptionKey { get; set; }
    
        /// <summary>
        /// Gets or sets appLogDecryptionAlgorithm.
        /// DecryptionAlgorithm for Content
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appLogDecryptionAlgorithm", Required = Newtonsoft.Json.Required.Default)]
        public AppLogDecryptionAlgorithm? AppLogDecryptionAlgorithm { get; set; }
    
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