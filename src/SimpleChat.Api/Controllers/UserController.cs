namespace SimpleChat.Api.Controllers
{
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;

    using SimpleChat.Services.Interfaces;
    using SimpleChat.Models.User;

    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();

            return users;
        }
    }
}
