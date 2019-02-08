using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Enum {
    public enum VolunteerParticipantStatus {
        PendingReview = 0,
        WaitingList = 1,
        Accepted = 2,
        Removed = 3,  //Accepted and subsequently removed
        Declined = 4
    }
}
