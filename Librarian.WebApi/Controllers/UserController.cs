using Librarian.Application.Interfaces;
using Librarian.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Librarian.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //[HttpGet(Name = "TestMethod")]
        //public async Task<ActionResult> TestMethod()
        //{
        //    return Ok();
        //}

        [HttpGet(Name = "GetUsers")]
        //[Route(nameof(GetUsers))]
        public async Task<ActionResult> GetUsers()
        {
            List<User> users = await _userService.GetUsers();
            return Ok();
        }
    }
}
