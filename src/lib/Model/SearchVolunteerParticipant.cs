using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class SearchVolunteerParticipant {
        public int VolunteerParticipantStatus { get; set; }
        public SearchIndividual Individual { get; set; }
        public int FundableId { get; set; }
        public VolunteerParticipantRole Role { get; set; }
        public int VolunteerOpportunityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFundraisingRequired { get; set; }
        public Package Package { get; set; }
        public int Id { get; set; }
    }
}
