using OAPR.Application.Dtos.Requests;
using OAPR.Application.Dtos.Responses;

namespace OAPR.Application.Interfaces.UseCases
{
    public interface IOrderUpdateUseCase : IUseCase<OrderUpdateUseCaseRequest, OrderUpdateUseCaseResponse>
    {
    }
}