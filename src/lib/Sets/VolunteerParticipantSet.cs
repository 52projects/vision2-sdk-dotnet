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
    public class VolunteerParticipantSet : BaseApiSet<VolunteerParticipant> {
        private const string _searchUrl = "/search/volunteerparticipant";
        private const string _getUrl = "/volunteerparticipant/{0}";
        private const string _createUrl = "/volunteerparticipant";

        public VolunteerParticipantSet(Vision2Token token, string apiUrl) : base(token, apiUrl) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        protected override string CreateUrl => _createUrl;

        public IVision2RestResponse<Vision2PagedResponse<SearchVolunteerParticipant>> Find(VolunteerParticipantQO qo) {
            return Search<SearchVolunteerParticipant>(qo);
        }
    }
}
