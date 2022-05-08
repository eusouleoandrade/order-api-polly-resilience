using OAPR.Application.Dtos.Requests;
using OAPR.Application.Dtos.Responses;
using OAPR.Application.Interfaces.UseCases;

namespace OAPR.Application.UseCases
{
    public class OrderUpdateUseCase : IOrderUpdateUseCase
    {
        public Task<OrderUpdateUseCaseResponse> ExecuteAsync(OrderUpdateUseCaseRequest request)
        {
            throw new NotImplementedException();
        }
    }
}