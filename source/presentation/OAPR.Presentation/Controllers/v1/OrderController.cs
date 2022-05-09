using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OAPR.Application.Dtos.Requests;
using OAPR.Application.Dtos.Wrappers;
using OAPR.Application.Interfaces.UseCases;
using OAPR.Presentation.Controllers.Common;

namespace OAPR.Presentation.Controllers.v1
{
    [ApiVersion("1.0")]
    public class OrderController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly IOrderUpdateUseCase _orderUpdateUseCase;

        public OrderController(IMapper mapper, IOrderUpdateUseCase orderUpdateUseCase)
        {
            _mapper = mapper;
            _orderUpdateUseCase = orderUpdateUseCase;
        }

        [HttpPut("{clientId}")]
        public async Task<ActionResult<Response>> Put(int clientId, [FromBody] OrderUpdateRequest request)
        {
            var useCaseRequest = _mapper.Map<OrderUpdateUseCaseRequest>(request, opt => opt.AfterMap((src, dest) => dest.ClientId = clientId));

            await _orderUpdateUseCase.ExecuteAsync(useCaseRequest);

            if (_orderUpdateUseCase.HasErrorNotification)
                return BadRequest(new Response(succeeded: false, errors: _orderUpdateUseCase.ErrorNotifications.Select(s => s.Message)));

            await Task.CompletedTask;
            return Ok(new Response(succeeded: true));
        }
    }
}