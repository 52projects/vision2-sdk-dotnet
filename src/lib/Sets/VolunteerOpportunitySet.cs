using Vision2.Api.Model;

namespace Vision2.Api.Sets {
    public class VolunteerOpportunitySet : BaseApiSet<dynamic> {
        private const string _searchUrl = "/search/volunteeropportunity/";
        private const string _getUrl = "/volunteeropportunity/{0}";
        private const string _listUrl = "/volunteeropportunity/";

        public VolunteerOpportunitySet(Vision2Token token, bool isStaging) : base(token, isStaging) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        protected override string ListUrl => _listUrl;
    }
}