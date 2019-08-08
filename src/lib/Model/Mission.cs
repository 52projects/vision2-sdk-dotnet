using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Mission { 
        public Mission() {

        }
        public int Id { get; set; }
        public int MinimumNumberOfParticipants { get; set; }
        public int MaximumNumberOfParticipants { get; set; }
        public decimal TargetPerPartcipant { get; set; }
        public int NameDisplay { get; set; }
        public int NumberOfActiveParticipants { get; set; }
        public int FundraisingCampaignId { get; set; }
        public string FundraisingCampaignName { get; set; }
        public int VolunteerCampaignId { get; set; }
        public string VolunteerCampaignName { get; set; }
        public string BasketCategory { get; set; }
        public string Tags { get; set; }
        public int SortKey { get; set; }
        public bool IsFundraiserContentApprovalRequired { get; set; }
        public bool IsShowOnlineIfGoalMet { get; set; }
        public string Name { get; set; }
        public Enum.ProjectStatusType Status { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string MobileDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int OrganizationFundId { get; set; }
        public int WebPhotoId { get; set; }
        public int MobilePhotoId { get; set; }
        public int CarouselPhotoId { get; set; }
        public bool IsHiddenFromDonors { get; set; }
        public string DesignationCode { get; set; }
        public bool EnableExpiringRecurringGiftEvents { get; set; }
        public bool EnableRecurringGiftPaymentFailure { get; set; }
        public bool EnableScheduledPaymentNotifications { get; set; }
        public string AccountSegment { get; set; }
        public int DefaultGivingLinkId { get; set; }
        public string DefaultGivingLinkName { get; set; }
        public int DefaultConnectLinkId { get; set; }
        public string DefaultConnectLinkName { get; set; }
        public int DefaultCommitmentLinkId { get; set; }
        public string DefaultCommitmentLinkName { get; set; }
        public bool EnableFirstGiftNotifications { get; set; }
        public bool EnableLastGiftNotifications { get; set; }
        public int ExpiringRecurringGiftTriggerId { get; set; }
        public int RecurringGiftPaymentFailureTriggerId { get; set; }
        public int ScheduledCommitmentPaymentTriggerId { get; set; }
        public int FirstGiftTriggerId { get; set; }
        public int LastGiftTriggerId { get; set; }
        public int DepartmentId { get; set; }
        public decimal GoalAmount { get; set; }
        public bool IncludePledgesInGoalProgress { get; set; }
        public bool IsArchived { get; set; }
        public bool IsTithe { get; set; }
        public int NonCharitableOrganizationFundId { get; set; }
        public bool IsCharitable { get; set; }
    }
}
