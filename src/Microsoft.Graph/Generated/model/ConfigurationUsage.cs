// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ConfigurationUsage.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ConfigurationUsage
    {
    
        /// <summary>
        /// Blocked
        /// </summary>
        Blocked = 0,
	
        /// <summary>
        /// Required
        /// </summary>
        Required = 1,
	
        /// <summary>
        /// Allowed
        /// </summary>
        Allowed = 2,
	
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 3,
	
    }
}