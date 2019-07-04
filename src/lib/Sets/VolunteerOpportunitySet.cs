using Vision2.Api.Model;

namespace Vision2.Api.Sets {
    public class VolunteerOpportunitySet : BaseApiSet<VolunteerOpportunity> {
        private const string _searchUrl = "/search/volunteeropportunity/";
        private const string _getUrl = "/volunteeropportunity/{0}";
        private const string _listUrl = "/volunteeropportunity/";

        public VolunteerOpportunitySet(Vision2Token token, string apiUrl) : base(token, apiUrl) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        protected override string ListUrl => _listUrl;

        protected override string CreateUrl => _listUrl;
    }
}