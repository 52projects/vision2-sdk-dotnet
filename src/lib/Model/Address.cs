using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision2.Api.Enum;

namespace Vision2.Api.Model {
    public class Address {
        public int? Id { get; set; }

        public int? IndividualProfileId { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public bool IsPrimary { get; set; }

        public AddressType AddressType { get; set; }

        public DateTime? InactiveAsOf { get; set; }

        public string StandardizedAddress { get; set; }

        public CountryTypeCode Country { get; set; }
    }
}
