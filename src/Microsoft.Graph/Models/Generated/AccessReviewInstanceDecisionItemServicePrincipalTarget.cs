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
    /// The type AccessReviewInstanceDecisionItemServicePrincipalTarget.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessReviewInstanceDecisionItemServicePrincipalTarget : AccessReviewInstanceDecisionItemTarget
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewInstanceDecisionItemServicePrincipalTarget"/> class.
        /// </summary>
        public AccessReviewInstanceDecisionItemServicePrincipalTarget()
        {
            this.ODataType = "microsoft.graph.accessReviewInstanceDecisionItemServicePrincipalTarget";
        }

        /// <summary>
        /// Gets or sets servicePrincipalId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePrincipalId", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets servicePrincipalDisplayName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePrincipalDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePrincipalDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets appId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
    }
}
