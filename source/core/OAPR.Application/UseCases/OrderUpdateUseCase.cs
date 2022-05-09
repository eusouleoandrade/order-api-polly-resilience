using AutoMapper;
using OAPR.Application.Dtos.Requests;
using OAPR.Application.Interfaces;
using OAPR.Application.Interfaces.UseCases;
using OAPR.Domain.Entities;
using OAPR.Infra.Notification.Abstractions;

namespace OAPR.Application.UseCases
{
    public class OrderUpdateUseCase : Notifiable, IOrderUpdateUseCase
    {
        private readonly IOrderIntegrationService _orderIntegrationService;

        private readonly IMapper _mapper;

        public OrderUpdateUseCase(IOrderIntegrationService orderIntegrationService, IMapper mapper)
        {
            _orderIntegrationService = orderIntegrationService;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(OrderUpdateUseCaseRequest request)
        {
            if (request.HasErrorNotification)
            {
                AddErrorNotification(request.ErrorNotifications);
                return;
            }

            var serviceRequest = _mapper.Map<Order>(request);
            
            await _orderIntegrationService.UpdateOrderAsync(serviceRequest);

            if (_orderIntegrationService.HasErrorNotification)
            {
                AddErrorNotification(_orderIntegrationService.ErrorNotifications);
                return;
            }
        }
    }
}