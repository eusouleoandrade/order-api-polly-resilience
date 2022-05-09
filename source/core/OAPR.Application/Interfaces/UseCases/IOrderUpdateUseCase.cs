using OAPR.Application.Dtos.Requests;
using OAPR.Infra.Notification.Interfaces;

namespace OAPR.Application.Interfaces.UseCases
{
    public interface IOrderUpdateUseCase : INotifiable, IUseCase<OrderUpdateUseCaseRequest>
    {
    }
}