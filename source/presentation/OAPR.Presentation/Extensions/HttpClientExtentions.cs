using OAPR.Presentation.Configurations;

using Polly;

namespace OAPR.Presentation.Extensions
{
    public static class HttpClientExtentions
    {
         public static void AddHttpClientOrderIntegrationService(this IServiceCollection services, IConfiguration configuration)
        {
            var timeoutPolicy = Policy.TimeoutAsync<HttpResponseMessage>(10);
            services.AddHttpClient("OrderIntegrationService", (c) =>
            {
                c.BaseAddress = new Uri(configuration.GetValue<String>("ApiProdutos:UrlBase"));
                c.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }).AddPolicyHandler(ResilienceConfig.GetRetryPolicy()).AddPolicyHandler(timeoutPolicy);
        }
    }
}