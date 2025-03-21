using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/protected")]
    [ApiController]
    public class ProtectedController : ControllerBase
    {
        [Authorize]
        [HttpGet("secure-data")]
        public IActionResult GetSecureData()
        {
            return Ok(new { message = "Secure Data" });
        }
    }
}
