using Microsoft.Extensions.DependencyInjection;
using OAPR.Application.Interfaces;
using OAPR.Infra.BackOfficeIntegration.Services;

namespace OAPR.Infra.BackOfficeIntegration.IoC
{
    public static class ServiceRegistration
    {
        public static void AddIntegrationInfra(this IServiceCollection services)
        {
            services.AddTransient<IOrderIntegrationService, OrderIntegrationService>();
        }
    }
}