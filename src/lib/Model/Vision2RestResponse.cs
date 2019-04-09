using System.Net;

namespace Vision2.Api.Model {
    public interface IVision2RestResponse {
        string RequestValue { get; set; }

        string JsonResponse { get; set; }

        HttpStatusCode StatusCode { get; set; }

        string ErrorMessage { get; set; }

        bool IsSuccessful { get; }
    }
    
    public interface IVision2RestResponse<T> : IVision2RestResponse {
        T Data { get; set; }
    }

    public class Vision2RestResponse : IVision2RestResponse {
        public string RequestValue { get; set; }

        public string JsonResponse { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string ErrorMessage { get; set; }

        public bool IsSuccessful {
            get {
                return (int)StatusCode >= 200 && (int)StatusCode < 300;
            }
        }
    }

    public class Vision2RestResponse<T> : Vision2RestResponse, IVision2RestResponse<T> where T : new() {
        public T Data { get; set; }
    }
}
