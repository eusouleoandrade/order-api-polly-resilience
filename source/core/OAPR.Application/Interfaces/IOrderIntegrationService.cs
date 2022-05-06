using OAPR.Domain.Entities;
using OAPR.Infra.Notification.Interfaces;

namespace OAPR.Application.Interfaces
{
    public interface IOrderIntegrationService : INotifiable
    {
         Task UpdateOrderAsync(Order entity);
    }
}