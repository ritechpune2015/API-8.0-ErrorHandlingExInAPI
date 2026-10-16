using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErrorHandlingEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorAPIController : ControllerBase
    {

        public IActionResult ShowError()
        {
            return Problem("We are facing some problem, please try after some time!");
        }
    }
}
