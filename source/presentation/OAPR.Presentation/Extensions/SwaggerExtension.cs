using Microsoft.OpenApi.Models;

namespace OAPR.Presentation.Extensions
{
    public static class SwaggerExtension
    {
        public static void AddSwaggerExtension(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "OAPR",
                    Description = "Order Api Polly Resilience"
                });
            });
        }

        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "OAPR - Order Api Polly Resilience - V1");
                c.RoutePrefix = string.Empty;
                c.InjectStylesheet("/swagger-ui/SwaggerDark.css");
            });
        }
    }
}