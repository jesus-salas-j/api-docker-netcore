using System;
using Microsoft.AspNetCore.Mvc;

namespace api_docker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<String> Get()
        {
            return "Hello from test controller!";
        }
    }
}
