using System;
using Vision2.Api.Model;
using Vision2.Api.QueryObject;
using System.Collections.Generic;

namespace Vision2.Api.Sets {
    public class PaymentSet : BaseApiSet<Payment> {
        private const string _getUrl = "/payment/{0}";
        private const string _searchUrl = "/search/appliedpaymentdetails";

        public PaymentSet(Vision2Token token, string apiUrl) : base(token, apiUrl) {

        }
        
        protected override string GetUrl => _getUrl;

        protected override string SearchUrl => _searchUrl;

        public IVision2RestResponse<Vision2Response<PaymentAdjustment>> MakePaymentAdjustments(PaymentAdjustment adjustments) {
            return Create(adjustments, "/payment/adjust");
        }

        public IVision2RestResponse<Vision2PagedResponse<Payment>> Find(PaymentQO qo) {
            return Search<Payment>(qo);
        }
    }
}
