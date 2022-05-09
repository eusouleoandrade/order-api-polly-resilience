using Microsoft.Extensions.DependencyInjection;
using OAPR.Application.Interfaces;
using OAPR.Infra.BackOfficeIntegration.Services;

namespace OAPR.Infra.BackOfficeIntegration.IoC
{
    public static class ServiceRegistration
    {
        public static void AddIntegrationInfraLayer(this IServiceCollection services)
        {
            // Integration services
            services.AddTransient<IOrderIntegrationService, OrderIntegrationService>();
        }
    }
}