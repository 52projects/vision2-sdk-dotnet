using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision2.Api.Enum;

namespace Vision2.Api.Model {
    public class Phone {
        public int? Id { get; set; }

        public int? IndividualProfileId { get; set; }

        public bool IsPrimary { get; set; }

        public string Number { get; set; }

        public bool IsSMSCapable { get; set; }

        public PhoneType PhoneType { get; set; }

        public int? RowStatus { get; set; }
    }
}
