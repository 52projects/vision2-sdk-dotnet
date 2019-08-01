using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Adjustment {
        public Adjustment() {
        }

        public int AppliedPaymentDetailId { get; set; }
        public int FundableId { get; set; }
        public int PackageId { get; set; }

        public int? MarketingCommunicationId { get; set; }
    }
}
