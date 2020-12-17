//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for InteractionChannel that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class InteractionChannelEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public string ChannelData { get; set; }

        /// <summary />
        public string ChannelDetailTemplate { get; set; }

        /// <summary />
        public int? ChannelEntityId { get; set; }

        /// <summary />
        public string ChannelListTemplate { get; set; }

        /// <summary />
        public int? ChannelTypeMediumValueId { get; set; }

        /// <summary />
        public int? ComponentCacheDuration { get; set; }

        /// <summary />
        public string ComponentCustom1Label { get; set; }

        /// <summary />
        public string ComponentCustom2Label { get; set; }

        /// <summary />
        public string ComponentCustomIndexed1Label { get; set; }

        /// <summary />
        public string ComponentDetailTemplate { get; set; }

        /// <summary />
        public int? ComponentEntityTypeId { get; set; }

        /// <summary />
        public string ComponentListTemplate { get; set; }

        /// <summary />
        public int? EngagementStrength { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string InteractionCustom1Label { get; set; }

        /// <summary />
        public string InteractionCustom2Label { get; set; }

        /// <summary />
        public string InteractionCustomIndexed1Label { get; set; }

        /// <summary />
        public string InteractionDetailTemplate { get; set; }

        /// <summary />
        public int? InteractionEntityTypeId { get; set; }

        /// <summary />
        public string InteractionListTemplate { get; set; }

        /// <summary />
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// If the ModifiedByPersonAliasId is being set manually and should not be overwritten with current user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public string Name { get; set; }

        /// <summary />
        public int? RetentionDuration { get; set; }

        /// <summary />
        public string SessionDetailTemplate { get; set; }

        /// <summary />
        public string SessionListTemplate { get; set; }

        /// <summary />
        public bool UsesSession { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// This does not need to be set or changed. Rock will always set this to the current date/time when saved to the database.
        /// </summary>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// If you need to set this manually, set ModifiedAuditValuesAlreadyUpdated=True to prevent Rock from setting it
        /// </summary>
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source InteractionChannel object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( InteractionChannel source )
        {
            this.Id = source.Id;
            this.ChannelData = source.ChannelData;
            this.ChannelDetailTemplate = source.ChannelDetailTemplate;
            this.ChannelEntityId = source.ChannelEntityId;
            this.ChannelListTemplate = source.ChannelListTemplate;
            this.ChannelTypeMediumValueId = source.ChannelTypeMediumValueId;
            this.ComponentCacheDuration = source.ComponentCacheDuration;
            this.ComponentCustom1Label = source.ComponentCustom1Label;
            this.ComponentCustom2Label = source.ComponentCustom2Label;
            this.ComponentCustomIndexed1Label = source.ComponentCustomIndexed1Label;
            this.ComponentDetailTemplate = source.ComponentDetailTemplate;
            this.ComponentEntityTypeId = source.ComponentEntityTypeId;
            this.ComponentListTemplate = source.ComponentListTemplate;
            this.EngagementStrength = source.EngagementStrength;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.InteractionCustom1Label = source.InteractionCustom1Label;
            this.InteractionCustom2Label = source.InteractionCustom2Label;
            this.InteractionCustomIndexed1Label = source.InteractionCustomIndexed1Label;
            this.InteractionDetailTemplate = source.InteractionDetailTemplate;
            this.InteractionEntityTypeId = source.InteractionEntityTypeId;
            this.InteractionListTemplate = source.InteractionListTemplate;
            this.IsActive = source.IsActive;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.Name = source.Name;
            this.RetentionDuration = source.RetentionDuration;
            this.SessionDetailTemplate = source.SessionDetailTemplate;
            this.SessionListTemplate = source.SessionListTemplate;
            this.UsesSession = source.UsesSession;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for InteractionChannel that includes all the fields that are available for GETs. Use this for GETs (use InteractionChannelEntity for POST/PUTs)
    /// </summary>
    public partial class InteractionChannel : InteractionChannelEntity
    {
        /// <summary />
        public DefinedValue ChannelTypeMediumValue { get; set; }

        /// <summary />
        public EntityType ComponentEntityType { get; set; }

        /// <summary />
        public EntityType InteractionEntityType { get; set; }

        /// <summary>
        /// NOTE: Attributes are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }

        /// <summary>
        /// NOTE: AttributeValues are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }
    }
}