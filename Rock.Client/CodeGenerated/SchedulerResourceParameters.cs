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
    /// Use this as the Content of a ~/api/Attendances/GetSchedulerResources POST
    /// </summary>
    public partial class SchedulerResourceParametersEntity
    {
        /// <summary />
        public int AttendanceOccurrenceGroupId { get; set; }

        /// <summary />
        // Made Obsolete in Rock "1.12"
        [Obsolete( "Use AttendanceOccurrenceScheduleIds instead", false )]
        public int AttendanceOccurrenceScheduleId { get; set; }

        /// <summary />
        public Int32[] AttendanceOccurrenceScheduleIds { get; set; }

        /// <summary />
        public DateTime AttendanceOccurrenceSundayDate { get; set; }

        /// <summary />
        public Rock.Client.Enums.SchedulerResourceGroupMemberFilterType? GroupMemberFilterType { get; set; }

        /// <summary />
        public int? LimitToPersonId { get; set; }

        /// <summary />
        public List<int> ResourceAdditionalPersonIds { get; set; }

        /// <summary />
        public int? ResourceDataViewId { get; set; }

        /// <summary />
        public int? ResourceGroupId { get; set; }

        /// <summary>
        /// Copies the base properties from a source SchedulerResourceParameters object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( SchedulerResourceParameters source )
        {
            this.AttendanceOccurrenceGroupId = source.AttendanceOccurrenceGroupId;
            #pragma warning disable 612, 618
            this.AttendanceOccurrenceScheduleId = source.AttendanceOccurrenceScheduleId;
            #pragma warning restore 612, 618
            this.AttendanceOccurrenceScheduleIds = source.AttendanceOccurrenceScheduleIds;
            this.AttendanceOccurrenceSundayDate = source.AttendanceOccurrenceSundayDate;
            this.GroupMemberFilterType = source.GroupMemberFilterType;
            this.LimitToPersonId = source.LimitToPersonId;
            this.ResourceAdditionalPersonIds = source.ResourceAdditionalPersonIds;
            this.ResourceDataViewId = source.ResourceDataViewId;
            this.ResourceGroupId = source.ResourceGroupId;

        }
    }

    /// <summary>
    /// Use this as the Content of a ~/api/Attendances/GetSchedulerResources POST
    /// </summary>
    public partial class SchedulerResourceParameters : SchedulerResourceParametersEntity
    {
    }
}