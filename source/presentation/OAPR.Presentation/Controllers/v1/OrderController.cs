using Microsoft.AspNetCore.Mvc;
using OAPR.Application.Dtos.Requests;
using OAPR.Application.Dtos.Responses;
using OAPR.Application.Dtos.Wrappers;
using OAPR.Presentation.Controllers.Common;

namespace OAPR.Presentation.Controllers.v1
{
    [ApiVersion("1.0")]
    public class OrderController : BaseApiController
    {
        public OrderController()
        {
        }

        [HttpPut]
        public async Task<ActionResult<Response>> Put([FromBody] OrderUpdateRequest request)
        {
            // var requestModel = _mapper.Map<CreateTransactionUseCaseRequestModel>(request);
            // var responseModel = await _createTransactionUseCase.Handler(requestModel);

            // if (_createTransactionUseCase.HasErrorNotification)
            //     return BadRequest(new Response(_createTransactionUseCase.ErrorNotificationResult.Select(s => s.Message)));

            // var response = _mapper.Map<CreateTransactionQuery>(responseModel);
            await Task.CompletedTask;
            return Ok(new Response(succeeded: true));
        }
    }
}