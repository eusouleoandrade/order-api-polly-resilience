using OAPR.Domain.Entities;

namespace OAPR.Application.Interfaces
{
    public interface IOrderIntegrationService
    {
         Task UpdateOrderAsync(Order entity);
    }
}