using Microsoft.AspNetCore.Mvc;

namespace OAPR.Presentation.Controllers.Common
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
    }
}