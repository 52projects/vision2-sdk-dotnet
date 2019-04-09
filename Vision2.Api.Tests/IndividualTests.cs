using NUnit.Framework;
using Shouldly;
using System.Linq;
using System.Threading.Tasks;
using Vision2.Api.Model;
using Vision2.Api.QueryObject;

namespace Vision2.Api.Tests {
    [TestFixture]
    public class IndividualTests : BaseTest {
        private Vision2Token _token;
        private Vision2Client _client;

        [OneTimeSetUp]
        public async Task Setup() {
            var response = await Vision2Client.RequestAccessTokenAsync(Options);
            _token = response.Data;
            _client = new Vision2Client(Options, _token);
        }

        [Test]
        public async Task integration_individuals_search_individuals() {
            var qo = new IndividualQO {
                PageNumber = 0,
                RecordsPerPage = 20,
                //OrganizationID = 246101,
                FirstName = "Ch",
                LastName = "Me",
                //EmailAddress = "haleyb07"
            };

            var response = _client.Individuals.Find(qo);
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.Result.PageData.Count().ShouldBeGreaterThan(0);
        }

        [Test]
        public async Task integration_individuals_get_individual() {
            var response = _client.Individuals.Get(987701.ToString());
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.ShouldNotBe(null);
            response.Data.Result.IndividualProfileId.ShouldBe(987701);
        }

        [Test]
        public async Task integration_individuals_create_individual() {
            var individual = new Individual {
                Names = new System.Collections.Generic.List<Name> {
                    new Name {
                        FirstName = "Haley",
                        LastName = "Meyer",
                    },
                },
                BirthDate = new System.DateTime(1984, 11, 26),
                GenderType = Enum.GenderType.Female,
                Emails = new System.Collections.Generic.List<Email> {
                    new Email {
                        EmailAddress = "haleyb07@me.com",
                        IsPrimary = true,
                        IsOptOut = true
                    }
                }
            };

            var response = _client.Individuals.Create(individual);
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
            response.Data.Result.IndividualProfileId.Value.ShouldBeGreaterThan(0);
        }
    }
}