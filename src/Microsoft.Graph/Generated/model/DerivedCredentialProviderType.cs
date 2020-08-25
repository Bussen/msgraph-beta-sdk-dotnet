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
    /// The enum DerivedCredentialProviderType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DerivedCredentialProviderType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Entrust Data Card
        /// </summary>
        EntrustDataCard = 1,
	
        /// <summary>
        /// Purebred
        /// </summary>
        Purebred = 2,
	
        /// <summary>
        /// XTec
        /// </summary>
        XTec = 3,
	
        /// <summary>
        /// Intercede
        /// </summary>
        Intercede = 4,
	
    }
}