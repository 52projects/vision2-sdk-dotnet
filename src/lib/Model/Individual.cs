using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision2.Api.Enum;

namespace Vision2.Api.Model {
    public class Individual {
        public Individual() {
            Names = new List<Name>();
            Emails = new List<Email>();
            Addresses = new List<Address>();
            Phones = new List<Phone>();
        }

        public Individual(SearchIndividual searchIndividual) {
            IndividualProfileId = searchIndividual.Id;
            GenderType = searchIndividual.GenderType;
            BirthDate = searchIndividual.BirthDate;
            DeceasedAsOf = searchIndividual.DeceasedAsOf;
            IsStaff = searchIndividual.IsStaff;
            SiteId = searchIndividual.SiteId;
            IsSuspect = searchIndividual.IsSuspect;
            Names = searchIndividual.Names;
            Addresses = searchIndividual.Addresses;
            Phones = searchIndividual.PhoneNumbers;
            Emails = searchIndividual.EmailAddresses;
        }

        public int? IndividualProfileId { get; set; }

        public GenderType? GenderType { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? DeceasedAsOf { get; set; }

        public bool IsStaff { get; set; }

        public int? SiteId { get; set; }

        public bool IsSuspect { get; set; }

        public bool AllowNoContactInformation { get; set; }

        public List<Name> Names { get; set; }

        public List<Address> Addresses { get; set; }

        public List<Phone> Phones { get; set; }

        public List<Email> Emails { get; set; }
    }
}
