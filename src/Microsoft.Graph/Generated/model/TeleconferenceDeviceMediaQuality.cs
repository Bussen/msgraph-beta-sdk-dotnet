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
    /// The type TeleconferenceDeviceMediaQuality.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public abstract partial class TeleconferenceDeviceMediaQuality
    {

        /// <summary>
        /// Gets or sets channelIndex.
        /// The channel index of media. Indexing begins with 1.  If a media session contains 3 video modalities, channel indexes will be 1, 2, and 3.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "channelIndex", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ChannelIndex { get; set; }
    
        /// <summary>
        /// Gets or sets mediaDuration.
        /// The total modality duration. If the media enabled and disabled multiple times, MediaDuration will the summation of all of the durations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaDuration", Required = Newtonsoft.Json.Required.Default)]
        public Duration MediaDuration { get; set; }
    
        /// <summary>
        /// Gets or sets networkLinkSpeedInBytes.
        /// The network link speed in bytes
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkLinkSpeedInBytes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? NetworkLinkSpeedInBytes { get; set; }
    
        /// <summary>
        /// Gets or sets localIPAddress.
        /// the local IP address for the media session.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localIPAddress", Required = Newtonsoft.Json.Required.Default)]
        public string LocalIPAddress { get; set; }
    
        /// <summary>
        /// Gets or sets localPort.
        /// The local media port.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "localPort", Required = Newtonsoft.Json.Required.Default)]
        public Int32? LocalPort { get; set; }
    
        /// <summary>
        /// Gets or sets remoteIPAddress.
        /// The remote IP address for the media session.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remoteIPAddress", Required = Newtonsoft.Json.Required.Default)]
        public string RemoteIPAddress { get; set; }
    
        /// <summary>
        /// Gets or sets remotePort.
        /// The remote media port.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remotePort", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemotePort { get; set; }
    
        /// <summary>
        /// Gets or sets inboundPackets.
        /// The total number of the inbound packets.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inboundPackets", Required = Newtonsoft.Json.Required.Default)]
        public Int64? InboundPackets { get; set; }
    
        /// <summary>
        /// Gets or sets outboundPackets.
        /// The total number of the outbound packets.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outboundPackets", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OutboundPackets { get; set; }
    
        /// <summary>
        /// Gets or sets averageInboundPacketLossRateInPercentage.
        /// The average inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageInboundPacketLossRateInPercentage", Required = Newtonsoft.Json.Required.Default)]
        public double? AverageInboundPacketLossRateInPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets averageOutboundPacketLossRateInPercentage.
        /// The average outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageOutboundPacketLossRateInPercentage", Required = Newtonsoft.Json.Required.Default)]
        public double? AverageOutboundPacketLossRateInPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets maximumInboundPacketLossRateInPercentage.
        /// The maximum inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumInboundPacketLossRateInPercentage", Required = Newtonsoft.Json.Required.Default)]
        public double? MaximumInboundPacketLossRateInPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets maximumOutboundPacketLossRateInPercentage.
        /// The maximum outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumOutboundPacketLossRateInPercentage", Required = Newtonsoft.Json.Required.Default)]
        public double? MaximumOutboundPacketLossRateInPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets averageInboundRoundTripDelay.
        /// The average inbound stream network round trip delay.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageInboundRoundTripDelay", Required = Newtonsoft.Json.Required.Default)]
        public Duration AverageInboundRoundTripDelay { get; set; }
    
        /// <summary>
        /// Gets or sets averageOutboundRoundTripDelay.
        /// The average outbound stream network round trip delay.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageOutboundRoundTripDelay", Required = Newtonsoft.Json.Required.Default)]
        public Duration AverageOutboundRoundTripDelay { get; set; }
    
        /// <summary>
        /// Gets or sets maximumInboundRoundTripDelay.
        /// The maximum inbound stream network round trip delay.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumInboundRoundTripDelay", Required = Newtonsoft.Json.Required.Default)]
        public Duration MaximumInboundRoundTripDelay { get; set; }
    
        /// <summary>
        /// Gets or sets maximumOutboundRoundTripDelay.
        /// The maximum outbound stream network round trip delay.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumOutboundRoundTripDelay", Required = Newtonsoft.Json.Required.Default)]
        public Duration MaximumOutboundRoundTripDelay { get; set; }
    
        /// <summary>
        /// Gets or sets averageInboundJitter.
        /// The average inbound stream network jitter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageInboundJitter", Required = Newtonsoft.Json.Required.Default)]
        public Duration AverageInboundJitter { get; set; }
    
        /// <summary>
        /// Gets or sets averageOutboundJitter.
        /// The average outbound stream network jitter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageOutboundJitter", Required = Newtonsoft.Json.Required.Default)]
        public Duration AverageOutboundJitter { get; set; }
    
        /// <summary>
        /// Gets or sets maximumInboundJitter.
        /// The maximum inbound stream network jitter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumInboundJitter", Required = Newtonsoft.Json.Required.Default)]
        public Duration MaximumInboundJitter { get; set; }
    
        /// <summary>
        /// Gets or sets maximumOutboundJitter.
        /// The maximum outbound stream network jitter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximumOutboundJitter", Required = Newtonsoft.Json.Required.Default)]
        public Duration MaximumOutboundJitter { get; set; }
    
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
