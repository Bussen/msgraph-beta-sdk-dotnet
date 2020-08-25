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
    /// The type Group Policy Migration Report.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicyMigrationReport : Entity
    {
    
		///<summary>
		/// The GroupPolicyMigrationReport constructor
		///</summary>
        public GroupPolicyMigrationReport()
        {
            this.ODataType = "microsoft.graph.groupPolicyMigrationReport";
        }
	
        /// <summary>
        /// Gets or sets group policy object id.
        /// The Group Policy Object GUID from GPO Xml content
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyObjectId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? GroupPolicyObjectId { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of Group Policy Object from the GPO Xml Content
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets ou distinguished name.
        /// The distinguished name of the OU.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ouDistinguishedName", Required = Newtonsoft.Json.Required.Default)]
        public string OuDistinguishedName { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time at which the GroupPolicyMigrationReport was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time at which the GroupPolicyMigrationReport was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets group policy created date time.
        /// The date and time at which the GroupPolicyMigrationReport was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyCreatedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? GroupPolicyCreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets group policy last modified date time.
        /// The date and time at which the GroupPolicyMigrationReport was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicyLastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? GroupPolicyLastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets migration readiness.
        /// The Intune coverage for the associated Group Policy Object file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "migrationReadiness", Required = Newtonsoft.Json.Required.Default)]
        public GroupPolicyMigrationReadiness? MigrationReadiness { get; set; }
    
        /// <summary>
        /// Gets or sets targeted in active directory.
        /// The Targeted in AD property from GPO Xml Content
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedInActiveDirectory", Required = Newtonsoft.Json.Required.Default)]
        public bool? TargetedInActiveDirectory { get; set; }
    
        /// <summary>
        /// Gets or sets total settings count.
        /// The total number of Group Policy Settings from GPO file.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalSettingsCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalSettingsCount { get; set; }
    
        /// <summary>
        /// Gets or sets supported settings count.
        /// The number of Group Policy Settings supported by Intune.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportedSettingsCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SupportedSettingsCount { get; set; }
    
        /// <summary>
        /// Gets or sets supported settings percent.
        /// The Percentage of Group Policy Settings supported by Intune.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportedSettingsPercent", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SupportedSettingsPercent { get; set; }
    
        /// <summary>
        /// Gets or sets group policy setting mappings.
        /// A list of group policy settings to MDM/Intune mappings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupPolicySettingMappings", Required = Newtonsoft.Json.Required.Default)]
        public IGroupPolicyMigrationReportGroupPolicySettingMappingsCollectionPage GroupPolicySettingMappings { get; set; }
    
        /// <summary>
        /// Gets or sets unsupported group policy extensions.
        /// A list of unsupported group policy extensions inside the Group Policy Object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unsupportedGroupPolicyExtensions", Required = Newtonsoft.Json.Required.Default)]
        public IGroupPolicyMigrationReportUnsupportedGroupPolicyExtensionsCollectionPage UnsupportedGroupPolicyExtensions { get; set; }
    
    }
}
