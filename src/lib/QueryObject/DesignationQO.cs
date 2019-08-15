using Vision2.Api.Attributes;
using Vision2.Api.Enum;

namespace Vision2.Api.QueryObject {
    public class DesignationQO : BaseQO {
        [QO("QueryTerm")]
        public string QueryTerm { get; set; }
    }
}
