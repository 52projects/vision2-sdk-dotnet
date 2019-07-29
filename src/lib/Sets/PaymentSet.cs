using System;
using Vision2.Api.Model;
using Vision2.Api.QueryObject;
using System.Collections.Generic;

namespace Vision2.Api.Sets {
    public class PaymentSet : BaseApiSet<Payment> {
        private const string _getUrl = "/payment/{0}";

        public PaymentSet(Vision2Token token, string apiUrl) : base(token, apiUrl) {

        }
        
        protected override string GetUrl => _getUrl;

        public IVision2RestResponse<Vision2Response<PaymentAdjustment>> MakePaymentAdjustments(PaymentAdjustment adjustments) {
            return Create(adjustments, "/payment/adjust");
        }
    }
}
