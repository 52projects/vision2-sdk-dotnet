using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class ExternalKey {
        public int SystemId { get; set; }
        public string KeyValue { get; set; }
        public string KeyValidation { get; set; }
        public string SystemName { get; set; }
        public DateTime DateUpdated { get; set; }
        public int VersionNumber { get; set; }
    }
}
