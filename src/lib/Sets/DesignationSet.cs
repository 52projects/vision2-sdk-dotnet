using Vision2.Api.Model;
using Vision2.Api.QueryObject;

namespace Vision2.Api.Sets {
    public class DesignationSet : BaseApiSet<Designation> {
        private const string _searchUrl = "/search/desingation";
        private const string _getUrl = "/designation/{0}";

        public DesignationSet(Vision2Token token, string apiUrl) : base(token, apiUrl) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        public IVision2RestResponse<Vision2PagedResponse<Designation>> Find(DesignationQO qo) {
            return Search<Designation>(qo);
        }
    }
}