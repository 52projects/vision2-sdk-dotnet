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
    public class MissionSet : BaseApiSet<Mission> {
        private const string _searchUrl = "/search/missiontrip";
        private const string _getUrl = "/missiontrip/{0}";

        public MissionSet(Vision2Token token, bool isStaging) : base(token, isStaging) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        public IVision2RestResponse<Vision2PagedResponse<Mission>> Find(MissionQO qo) {
            return Search<Mission>(qo);
        }
    }
}
