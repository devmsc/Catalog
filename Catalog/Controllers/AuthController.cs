using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Me()
        {
            return Ok(HttpContext?.User?.Identity?.Name);
        }
    }
}