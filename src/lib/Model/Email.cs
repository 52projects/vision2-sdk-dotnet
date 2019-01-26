using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Email {
        public int? Id { get; set; }

        public int? IndividualProfileId { get; set; }

        public bool IsPrimary { get; set; }

        public string EmailAddress { get; set; }

        public bool IsOptOut { get; set; }

        public int? RowStatus { get; set; }
    }
}
