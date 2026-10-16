using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ErrorHandlingEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {

        [HttpGet("{a}/{b}")]
        public int doDivision(int a, int b)
        {
            return a / b;
        }
    }
}
