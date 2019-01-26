using NUnit.Framework;
using Shouldly;
using System.Linq;
using System.Threading.Tasks;
using Vision2.Api.Model;
using Vision2.Api.QueryObject;

namespace Vision2.Api.Tests {
    [TestFixture]
    public class FundsTests : BaseTest {
        private Vision2Token _token;
        private Vision2Client _client;

        [OneTimeSetUp]
        public async Task Setup() {
            var response = await Vision2Client.RequestAccessTokenAsync(Options);
            _token = response.Data;
            _client = new Vision2Client(Options, _token);
        }

        [Test]
        public async Task integration_funds_search_funds() {
            var qo = new FundQO {
                PageNumber = 0,
                RecordsPerPage = 20,
            };

            var response = _client.Funds.Find(qo);
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.Result.PageData.Count().ShouldBeGreaterThan(0);
        }
    }
}
