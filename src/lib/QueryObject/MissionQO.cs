using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Vision2.Api.Attributes;
using Vision2.Api.Enum;

namespace Vision2.Api.QueryObject {
    public class MissionQO : BaseQO {
        [QO("FromStartDate")]
        public DateTime? FromStartDate { get; set; }

        [QO("ToStartDate")]
        public DateTime? ToStartDate { get; set; }

        [QO("FromEndDate")]
        public DateTime? FromEndDate { get; set; }

        [QO("ToEndDate")]
        public DateTime? ToEndDate { get; set; }

        [QO("QueryTerm")]
        public string QueryTerm { get; set; }

        [QO("FundableReferenceType")]
        public int? FundableReferenceType { get; set; }

        [QO("IsActive")]
        public bool? IsActive { get; set; }

        [QO("IsArchived")]
        public bool? IsArchived { get; set; }

        [QO("IsHiddenFromDonors")]
        public bool? IsHiddenFromDonors { get; set; }

        [QO("ProjectStatusType")]
        public ProjectStatusType? ProjectStatusType { get; set; }

        [QO("DesignationCode")]
        public string DesignationCode { get; set; }
    }
}
