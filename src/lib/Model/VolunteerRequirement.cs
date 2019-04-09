using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class VolunteerRequirement {
        public int Id { get; set; }

        public int RequirementId { get; set; }

        public DateTime Duration { get; set; }

        public int RequirementType { get; set; }

        public string Name { get; set; }

        public bool IsRequired { get; set; }

        public string Value { get; set; }
    }
}
