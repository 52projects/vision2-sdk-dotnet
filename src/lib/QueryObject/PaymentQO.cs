using Vision2.Api.Attributes;
using Vision2.Api.Enum;


namespace Vision2.Api.QueryObject {
    public class PaymentQO : BaseQO {
        [QO("PackageID")]
        public int? PackageID { get; set; }
    }
}
