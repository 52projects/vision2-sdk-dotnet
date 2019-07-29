using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class PaymentAdjustment {
        public PaymentAdjustment() {
            Details = new List<Adjustment>();
        }

        public int PaymentId { get; set; }

        public List<Adjustment> Details { get; set; }
    }
}
