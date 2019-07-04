using Vision2.Api.Model;
using Vision2.Api.QueryObject;

namespace Vision2.Api.Sets {
    public class FundSet : BaseApiSet<Fund> {
        private const string _searchUrl = "/search/fund";
        private const string _getUrl = "/fund/{0}";

        public FundSet(Vision2Token token, string apiUrl) : base(token, apiUrl) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        public IVision2RestResponse<Vision2PagedResponse<Fund>> Find(FundQO qo) {
            return Search<Fund>(qo);
        }
    }
}
