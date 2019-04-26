﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Vision2.Api.Extensions;
using Vision2.Api.Model;
using Vision2.Api.Sets;

namespace Vision2.Api {
    public class Vision2Client {
        private readonly MissionSet _missionSet;
        private readonly FundSet _fundSet;
        private readonly IndividualSet _individualSet;
        private readonly VolunteerParticipantSet _volunteerParticipantSet;
        private readonly VolunteerOpportunitySet _volunteerOpportunitySet;
        private readonly VolunteerRoleSet _volunteerRoleSet;

        public Vision2Client(Vision2Options options, Vision2Token token) {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11;

            _missionSet = new MissionSet(token, options.IsStaging);
            _fundSet = new FundSet(token, options.IsStaging);
            _individualSet = new IndividualSet(token, options.IsStaging);
            _volunteerParticipantSet = new VolunteerParticipantSet(token, options.IsStaging);
            _volunteerOpportunitySet = new VolunteerOpportunitySet(token, options.IsStaging);
            _volunteerRoleSet = new VolunteerRoleSet(token, options.IsStaging);
        }

        public MissionSet Missions => _missionSet;

        public FundSet Funds => _fundSet;

        public IndividualSet Individuals => _individualSet;

        public VolunteerParticipantSet VolunteerParticipants => _volunteerParticipantSet;

        public VolunteerOpportunitySet VolunteerOpportunities => _volunteerOpportunitySet;

        public VolunteerRoleSet VolunteerRoles => _volunteerRoleSet;

        /// <summary>
        /// Request an access token from Vision2
        /// </summary>
        /// <param name="options">Options for the Vision2 Client</param>
        /// <param name="username">The username to authenticate</param>
        /// <param name="password">The password to authenticate
        /// <returns>An OAuth Token object to use for subsequent requests</returns>
        public static async Task<IVision2RestResponse<Vision2Token>> RequestAccessTokenAsync(Vision2Options options) {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11;
            using (var httpClient = new HttpClient()) {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", options.Username),
                    new KeyValuePair<string, string>("password", options.Password),
                });

                var url = new Uri(options.IsStaging ? $"https://{options.TenantCode}.v2sqa.com" : $"https://{options.TenantCode}.vision2systems.com");

                var response = await httpClient.PostAsync($"{url}/token", content);
                var responseContent = await response.Content.ReadAsStringAsync();

                var v2Response = new Vision2RestResponse<Vision2Token> {
                    StatusCode = response.StatusCode,
                    RequestValue = Newtonsoft.Json.JsonConvert.SerializeObject(content)
                };

                if (!string.IsNullOrEmpty(responseContent) && responseContent.Contains("error")) {
                    var responseError = responseContent.FromJson<dynamic>();
                    v2Response.ErrorMessage = responseError.error_message;
                }
                else if (responseContent.Replace("\"", "") == "null") {
                    v2Response.ErrorMessage = "Bad username / password";
                    v2Response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                }
                else {
                    v2Response.Data = responseContent.FromJson<Vision2Token>();
                }

                return v2Response;
            }
        }

        public static async Task<IVision2RestResponse<Vision2Token>> RefreshAccessTokenAsync(Vision2Options options, string refreshToken) {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11;
            using (var httpClient = new HttpClient()) {
                try {
                    var content = new FormUrlEncodedContent(new[]
                    {
                    new KeyValuePair<string, string>("grant_type", "refresh_token"),
                    new KeyValuePair<string, string>("refresh_token", refreshToken),
                });

                    var url = new Uri(options.IsStaging ? $"https://{options.TenantCode}.v2sqa.com" : $"https://{options.TenantCode}.vision2systems.com");

                    var response = await httpClient.PostAsync($"{url}/token", content);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    var v2Response = new Vision2RestResponse<Vision2Token> {
                        StatusCode = response.StatusCode,
                        RequestValue = Newtonsoft.Json.JsonConvert.SerializeObject(content)
                    };

                    if (!string.IsNullOrEmpty(responseContent) && responseContent.Contains("error")) {
                        var responseError = responseContent.FromJson<dynamic>();
                        v2Response.ErrorMessage = responseError.error_message;
                    }
                    else {
                        v2Response.Data = responseContent.FromJson<Vision2Token>();
                    }

                    return v2Response;
                }
                catch (Exception e) {
                    return null;
                }
            }
        }
    }

    public enum ContentType {
        XML = 1,
        JSON = 2
    }
}