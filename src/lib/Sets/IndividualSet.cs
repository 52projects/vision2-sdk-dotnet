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
    public class IndividualSet : BaseApiSet<Individual> {
        private const string _searchUrl = "/search/individual";
        private const string _getUrl = "/individual/{0}";
        private const string _createUrl = "/individual";

        public IndividualSet(Vision2Token token, bool isStaging) : base(token, isStaging) {

        }

        protected override string SearchUrl => _searchUrl;

        protected override string GetUrl => _getUrl;

        protected override string CreateUrl => _createUrl;

        public IVision2RestResponse<Vision2PagedResponse<Individual>> Find(IndividualQO qo) {
            qo.UseComplex = true;
            return Search<Individual>(qo);
        }
    }
}
