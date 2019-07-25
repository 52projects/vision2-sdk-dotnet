using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Designation {
        public int FundableId { get; set; }
        public string FundableName { get; set; }
        public string Description { get; set; }
        public string FundableTerm { get; set; }
        public int FundableReferenceType { get; set; }
        public string DesignationCode { get; set; }
        public int OrganizationFundId { get; set; }
        public List<ExternalKey> ExternalKeys { get; set; }
    }
}
