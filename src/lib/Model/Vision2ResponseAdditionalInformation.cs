using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Vision2ResponseAdditionalInformation {
        public Vision2ResponseAdditionalInformation() {
            DuplicateIndividualProfiles = new List<SearchIndividual>();
            DuplicateOrganizationProfiles = new List<dynamic>();
        }

        public List<SearchIndividual> DuplicateIndividualProfiles { get; set; }

        public List<dynamic> DuplicateOrganizationProfiles { get; set; }
    }
}
