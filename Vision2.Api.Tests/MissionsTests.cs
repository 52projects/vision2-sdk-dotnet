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
            var qo = new MissionQO {
                PageNumber = 0,
                RecordsPerPage = 20,
            };

            var response = _client.Missions.Find(qo);

            var missionResponse = _client.Missions.Get(response.Data.Result.PageData[0].FundableId.ToString());
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.ShouldNotBe(null);
        }

        [Test]
        public async Task integration_missions_create_mission() {
            var mission = new Mission {
                AccountSegment = "fmtest2019",
                DesignationCode = "FMTEST2019",
                EndDate = DateTime.UtcNow.AddDays(30),
                StartDate = DateTime.UtcNow,
                OrganizationFundId = 293803,
                IncludePledgesInGoalProgress = true,
                IsActive = true,
                OrganizationType = 1,
                LongDescription = "Mission trip description",
                MobileDescription = "Mobile Trip Description",
                ShortDescription = "Trip Description",
                Status = Enum.ProjectStatusType.Pending,
                Name = "Focus Test",
                MinimumNumberOfParticipants = 2,
                MaximumNumberOfParticipants = 20,
                TargetPerPartcipant = 1200,
                OrganizationId = 246101
            };

            var results = _client.Missions.Create(mission);
            results.Data.ShouldNotBe(null);
        }
    }
}
