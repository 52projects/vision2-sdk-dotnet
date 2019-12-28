using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Vision2PagedResponse<T> : Vision2ResponseData where T : new() {
        public Vision2PagedResult<T> Result { get; set; }
    }
}
