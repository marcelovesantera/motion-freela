using Microsoft.AspNetCore.Mvc;
using motionfreela.API.Models;
using motionfreela.Application.InputModels;
using motionfreela.Application.Services.Interfaces;

namespace motionfreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers(string query)
        {
            var users = _userService.GetUsers(query);

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserInputModel createUser)
        {
            var userId = _userService.CreateUser(createUser);

            return CreatedAtAction(nameof(GetUserById), new { id = userId }, createUser);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UpdateUserViewModel updateUser)
        {
            if(updateUser.About.Length > 200)
            {
                return BadRequest();
            }

            _userService.UpdateUser(updateUser);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var userId = GetUserById(id);

            if (userId == null)
            {
                return NotFound();
            }

            _userService.DeleteUser(id);

            return NoContent();
        }

        [HttpPut("{id}/login")]
        public IActionResult Login([FromBody] LoginInputModel login)
        {
            return NoContent();
        }
    }
}
