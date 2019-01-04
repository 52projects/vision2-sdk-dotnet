using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Tests {
    public class BaseTest {
        internal Vision2Options Options;

        public BaseTest() {
            Options = new Vision2Options {
                IsStaging = true,
                TenantCode = "prodmgmt3",
                Username = "chadmeyer@52projectsllc.com",
                Password = "Pa$$w0rd"
            };
        }
    }
}
