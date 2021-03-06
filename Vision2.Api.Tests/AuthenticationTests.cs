﻿using NUnit.Framework;
using Vision2.Api;
using System.Threading.Tasks;
using Shouldly;

namespace Vision2.Api.Tests {
    [TestFixture]
    public class AuthenticationTests : BaseTest {

        [SetUp]
        public void Setup() {

        }

        [Test]
        public async Task integration_authentication_login_with_creds() {
           var token = await Vision2Client.RequestAccessTokenAsync(Options);
            token.Data.ShouldNotBe(null);
            token.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
        }
    }
}
