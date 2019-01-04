using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision2.Api.Model;
using NUnit.Framework;
using Vision2.Api.Model;
using Vision2.Api.QueryObject;
using Shouldly;

namespace Vision2.Api.Tests {
    [TestFixture]
    public class MissionsTests : BaseTest {
        private Vision2Token _token;
        private Vision2Client _client;

        [OneTimeSetUp]
        public async Task Setup() {
            var response = await Vision2Client.RequestAccessTokenAsync(Options);
            _token = response.Data;
            _client = new Vision2Client(Options, _token);
        }

        [Test]
        public async Task integration_missions_search_missions() {
            var qo = new MissionQO {
                PageNumber = 0,
                RecordsPerPage = 20,
            };

            var response = _client.Missions.Find(qo);
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.Result.PageData.Count().ShouldBeGreaterThan(0);
        }

        [Test]
        public async Task integration_missions_get_mission() {
            var response = _client.Missions.Get("250902");
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.ShouldNotBe(null);
        }
    }
}
