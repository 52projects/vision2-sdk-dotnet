using Vision2.Api.Model;


namespace Vision2.Api.Sets {
    public class VolunteerRoleSet : BaseApiSet<VolunteerRole> {
        private const string _searchUrl = "/search/volunteerrole/";
        private const string _getUrl = "/volunteerrole/{0}";
        private const string _listUrl = "/volunteerrole/";

        public VolunteerRoleSet(Vision2Token token, string apiUrl) : base(token, apiUrl) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        protected override string ListUrl => _listUrl;

        protected override string CreateUrl => _listUrl;
    }
}
