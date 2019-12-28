using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Vision2ResponseData {
        public string ErrorMessage { get; set; }

        public string ValidationMessages { get; set; }

        public int Status { get; set; }

        public string TrackingKey { get; set; }

        public Vision2ResponseAdditionalInformation AdditionalInfo { get; set; }
    }
}
