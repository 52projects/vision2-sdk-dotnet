using Vision2.Api.Model;
using RestSharp;

namespace Vision2.Api.Extensions {
    public static class RestSharpExtensions {
        public static IVision2RestResponse ToVision2Response(this IRestResponse restResponse) {
            var response = new Vision2RestResponse();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;

            if (restResponse.StatusCode != System.Net.HttpStatusCode.OK) {
                response.ErrorMessage = restResponse.ErrorMessage;
            }

            return response;
        }

        public static IVision2RestResponse<S> ToVision2Response<S>(this IRestResponse<S> restResponse) where S : new() {
            var response = new Vision2RestResponse<S>();

            response.StatusCode = restResponse.StatusCode;
            response.JsonResponse = restResponse.Content;
            response.Data = restResponse.Data;

            return response;
        }

        public static IVision2RestResponse<S> ToVision2Response<S>(this IRestResponse<S> restResponse, string requestInput) where S : new() {
            var response = restResponse.ToVision2Response();
            response.RequestValue = requestInput;
            return response;
        }
    }
}
