using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using OAPR.Application.Interfaces.UseCases;
using OAPR.Application.UseCases;

namespace OAPR.Application.IoC
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            // Assembly 
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // UseCases
            services.AddTransient<IOrderUpdateUseCase, OrderUpdateUseCase>();
        }
    }
}