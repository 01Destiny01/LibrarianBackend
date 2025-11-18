using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Librarian.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {       
        [HttpGet(Name = "TestMethod")]
        public async Task<ActionResult> TestMethod()
        {
            return Ok();
        }
    }
}
