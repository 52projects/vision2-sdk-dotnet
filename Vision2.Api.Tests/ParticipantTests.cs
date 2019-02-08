using NUnit.Framework;
using Shouldly;
using System.Linq;
using System.Threading.Tasks;
using Vision2.Api.Model;
using Vision2.Api.QueryObject;

namespace Vision2.Api.Tests {
    [TestFixture]
    public class ParticipantTests : BaseTest {
        private Vision2Token _token;
        private Vision2Client _client;

        [OneTimeSetUp]
        public async Task Setup() {
            var response = await Vision2Client.RequestAccessTokenAsync(Options);
            _token = response.Data;
            _client = new Vision2Client(Options, _token);
        }

        [Test]
        public async Task integration_participants_create() {
            var participant = new VolunteerParticipant {
                IndividualProfileId = 1,
                ParticipantStauts = Enum.VolunteerParticipantStatus.PendingReview,
                VolunteerOpportunityId = 1
            };


            var response = _client.VolunteerParticipants.Create(participant);
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.ShouldNotBe(null);
        }

        [Test]
        public async Task integration_volunteer_opportunities() {
            var response = _client.VolunteerOpportunities.Search<dynamic>(new VolunteerOpportunityQO {
                 RecordsPerPage = 20,
                 PageNumber = 0
            });
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.ShouldNotBe(null);
        }
    }
}
