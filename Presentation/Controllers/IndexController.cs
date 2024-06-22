using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api")]
    [ApiController]

    public class IndexController : ControllerBase
    {
        [HttpGet]
        [Route("status")]
        [Authorize (Policy = "RequireCommonRole")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult Get()
        {
            return Ok("Api Online!");
        }

        [HttpGet("public")]
        [Authorize(Policy = "RequireAdministratorRole")]
        public IActionResult GetPublic()
        {
            return Ok("Public endpoint!");
        }
    }
}
