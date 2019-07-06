using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Vision2.Api.Attributes;

namespace Vision2.Api.QueryObject {
    public class VolunteerRoleQO : BaseQO {
        [QO("SearchTerm")]
        public string SearchTerm { get; set; }
    }
}
