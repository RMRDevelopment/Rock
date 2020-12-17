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
    /// Base client model for StepType that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class StepTypeEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public bool AllowManualEditing { get; set; } = true;

        /// <summary />
        public bool AllowMultiple { get; set; } = true;

        /// <summary />
        public int? AudienceDataViewId { get; set; }

        /// <summary />
        public int? AutoCompleteDataViewId { get; set; }

        /// <summary />
        public string CardLavaTemplate { get; set; } = @"<div class=""card-top"">
    <h3 class=""step-name"">{{ StepType.Name }}</h3>
</div>
<div class=""card-middle"">
    {% if StepType.HighlightColor == '' or IsComplete == false %}
        <i class=""{{ StepType.IconCssClass }} fa-4x""></i>
    {% else %}
        <i class=""{{ StepType.IconCssClass }} fa-4x"" style=""color: {{ StepType.HighlightColor }};""></i>
    {% endif %}
</div>
<div class=""card-bottom"">
    <p class=""step-status"">
        {% if LatestStepStatus %}
            <span class=""label"" style=""background-color: {{ LatestStepStatus.StatusColor }};"">{{ LatestStepStatus.Name }}</span>
        {% endif %}
        {% if ShowCampus and LatestStep and LatestStep.Campus != '' %}
            <span class=""label label-campus"">{{ LatestStep.Campus.Name }}</span>
        {% endif %}
        {% if LatestStep and LatestStep.CompletedDateTime != '' %}
            <br />
            <small>{{ LatestStep.CompletedDateTime | Date:'M/d/yyyy' }}</small>
        {% endif %}
    </p>
    {% if StepCount > 1 %}
        <span class=""badge"">{{ StepCount }}</span>
    {% endif %}
</div>
";

        /// <summary />
        public string Description { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public bool HasEndDate { get; set; }

        /// <summary />
        public string HighlightColor { get; set; }

        /// <summary />
        public string IconCssClass { get; set; }

        /// <summary />
        public bool IsActive { get; set; } = true;

        /// <summary />
        public string MergeTemplateDescriptor { get; set; }

        /// <summary />
        public int? MergeTemplateId { get; set; }

        /// <summary>
        /// If the ModifiedByPersonAliasId is being set manually and should not be overwritten with current user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public string Name { get; set; }

        /// <summary />
        public int Order { get; set; }

        /// <summary />
        public bool ShowCountOnBadge { get; set; } = true;

        /// <summary />
        public int StepProgramId { get; set; }

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
        /// Copies the base properties from a source StepType object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( StepType source )
        {
            this.Id = source.Id;
            this.AllowManualEditing = source.AllowManualEditing;
            this.AllowMultiple = source.AllowMultiple;
            this.AudienceDataViewId = source.AudienceDataViewId;
            this.AutoCompleteDataViewId = source.AutoCompleteDataViewId;
            this.CardLavaTemplate = source.CardLavaTemplate;
            this.Description = source.Description;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.HasEndDate = source.HasEndDate;
            this.HighlightColor = source.HighlightColor;
            this.IconCssClass = source.IconCssClass;
            this.IsActive = source.IsActive;
            this.MergeTemplateDescriptor = source.MergeTemplateDescriptor;
            this.MergeTemplateId = source.MergeTemplateId;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.Name = source.Name;
            this.Order = source.Order;
            this.ShowCountOnBadge = source.ShowCountOnBadge;
            this.StepProgramId = source.StepProgramId;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for StepType that includes all the fields that are available for GETs. Use this for GETs (use StepTypeEntity for POST/PUTs)
    /// </summary>
    public partial class StepType : StepTypeEntity
    {
        /// <summary />
        public ICollection<AchievementType> AchievementTypes { get; set; }

        /// <summary />
        public DataView AudienceDataView { get; set; }

        /// <summary />
        public DataView AutoCompleteDataView { get; set; }

        /// <summary />
        public MergeTemplate MergeTemplate { get; set; }

        /// <summary />
        public StepProgram StepProgram { get; set; }

        /// <summary />
        public ICollection<Step> Steps { get; set; }

        /// <summary />
        public ICollection<StepTypePrerequisite> StepTypeDependencies { get; set; }

        /// <summary />
        public ICollection<StepTypePrerequisite> StepTypePrerequisites { get; set; }

        /// <summary />
        public ICollection<StepWorkflowTrigger> StepWorkflowTriggers { get; set; }

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
