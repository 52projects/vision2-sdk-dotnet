using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Fundraiser {
        public int Id { get; set; }
        public int VolunteerOpportunityId { get; set; }
        public Individual Individual { get; set; }
        public List<Name> Names { get; set; }
        public int SelectedDisplayName { get; set; }
        public int PackageId { get; set; }
        public Designation Designation { get; set; }
        public int PhotoApprovalStatus { get; set; }
        public int StatementApprovalStatus { get; set; }
        public bool IsGoalOverridenForVolunteer { get; set; }
        public bool IsGoalRoleBased { get; set; }
        public bool IsGoalDesignationBased { get; set; }
        public int VolunteerSubmittedPhotoId { get; set; }
        public string VolunteerSubmittedStatement { get; set; }
        public int ApprovedPhotoId { get; set; }
        public string ApprovedStatement { get; set; }
        public int VolunteerGivingGoal { get; set; }
        public int VolunterParticipantId { get; set; }
        public int VolunterRoleId { get; set; }
        public int VolunterOpportunityId { get; set; }
        public string VolunteerRoleName { get; set; }
        public string VolunteerOpportunityName { get; set; }
        public int MissionTripId { get; set; }
        public bool IsActive { get; set; }
    }
}





