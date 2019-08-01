using Vision2.Api.Model;
using Vision2.Api.QueryObject;
using System.Collections.Generic;

namespace Vision2.Api.Sets {
    public class MissionSet : BaseApiSet<Mission> {
        private const string _searchUrl = "/search/missiontrip";
        private const string _getUrl = "/missiontrip/{0}";
        private const string _createUrl = "/missiontrip";

        public MissionSet(Vision2Token token, string apiUrl) : base(token, apiUrl) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        protected override string CreateUrl => _createUrl;

        protected override string EditUrl => _getUrl;

        public IVision2RestResponse<Vision2PagedResponse<SearchMission>> Find(MissionQO qo) {
            return Search<SearchMission>(qo);
        }

        public IVision2RestResponse<Vision2Response<List<VolunteerOpportunity>>> FindVolunteerOpportunities(int fundableId) {
            return ListBySuffixUrl<VolunteerOpportunity>("/volunteeropportunity/getbydesignationid/" + fundableId);
        }
    }
}
