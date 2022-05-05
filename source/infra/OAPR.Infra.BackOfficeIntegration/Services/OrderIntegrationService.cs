using OAPR.Application.Interfaces;
using OAPR.Domain.Entities;

namespace OAPR.Infra.BackOfficeIntegration.Services
{
    public class OrderIntegrationService : IOrderIntegrationService
    {
        public async Task UpdateOrderAsync(Order entity)
        {
            await Task.CompletedTask;
        }
    }
}