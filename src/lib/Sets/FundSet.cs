using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision2.Api.Model;
using Vision2.Api;
using System.Collections.Generic;
using Vision2.Api.QueryObject;

namespace Vision2.Api.Sets {
    public class FundSet : BaseApiSet<Fund> {
        private const string _searchUrl = "/search/fund";
        private const string _getUrl = "/fund/{0}";

        public FundSet(Vision2Token token, bool isStaging) : base(token, isStaging) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        public IVision2RestResponse<Vision2PagedResponse<Fund>> Find(FundQO qo) {
            return Search<Fund>(qo);
        }
    }
}
