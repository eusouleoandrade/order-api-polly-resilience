using Newtonsoft.Json;

namespace OAPR.Application.Dtos.Wrappers
{
    public class Response<T>
    {
        public bool Succeeded { get; private set; }

        public string? Message { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string>? Errors { get; private set; }

        public T Data { get; private set; }

        public Response(bool succeeded, T data, string? message, IEnumerable<string>? errors)
        {
            Succeeded = succeeded;
            Errors = errors;
            Data = data;

            if (String.IsNullOrEmpty(message) || String.IsNullOrWhiteSpace(message))
                Message = succeeded ? "Request processed" : "Failed to process request";
            else
                Message = message;

            if (errors is null)
                Errors = new List<string>();
            else
                Errors = errors;
        }
    }

    public class Response
    {
        public bool Succeeded { get; set; }

        public string? Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string>? Errors { get; set; }

        public Response(bool succeeded, string? message = null, IEnumerable<string>? errors = null)
        {
            Succeeded = succeeded;
            
            if (String.IsNullOrEmpty(message) || String.IsNullOrWhiteSpace(message))
                Message = succeeded ? "Request processed" : "Failed to process request";
            else
                Message = message;

            if (errors is null)
                Errors = new List<string>();
            else
                Errors = errors;
        }
    }
}