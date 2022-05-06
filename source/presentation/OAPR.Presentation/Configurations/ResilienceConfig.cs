using Polly;
using Polly.Extensions.Http;
using Polly.Timeout;

namespace OAPR.Presentation.Configurations
{
    public static class ResilienceConfig
    {
        public static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
                .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                .Or<TimeoutRejectedException>()
                .WaitAndRetryAsync(5, retryAttempt => TimeSpan.FromSeconds(Math.Pow(1, retryAttempt)));
        }
    }
}