using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class VolunteerRole {
        public VolunteerRole() {
            Requirements = new List<VolunteerRequirement>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<VolunteerRequirement> Requirements { get; set; }
    }
}
