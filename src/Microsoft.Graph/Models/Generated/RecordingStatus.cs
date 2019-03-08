// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RecordingStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RecordingStatus
    {
    
        /// <summary>
        /// Recording Capable
        /// </summary>
        RecordingCapable = 0,
	
        /// <summary>
        /// Not Recording
        /// </summary>
        NotRecording = 1,
	
        /// <summary>
        /// Started Recording
        /// </summary>
        StartedRecording = 2,
	
    }
}