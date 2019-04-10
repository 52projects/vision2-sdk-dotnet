using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class VolunteerOpportunity {
        public int Id { get; set; }

        public int? VolunteerRoleId { get; set; }

        public string VolunteerRoleName { get; set; }

        public int? NumberDesired { get; set; }

        public int? NumberPending { get; set; }

        public int? NumberAccepted { get; set; }

        public int? NumberWaitListed { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsFundraisingRequired { get; set; }

        public int FundableId { get; set; }

        public bool IsActive { get; set; }

        public bool IsGoalOpportunitySpecific { get; set; }

        public decimal OpportunityGoal { get; set; }
    }
}