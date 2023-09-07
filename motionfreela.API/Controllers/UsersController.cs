using Microsoft.AspNetCore.Mvc;
using motionfreela.API.Models;

namespace motionfreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            // return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserModel createUser)
        {
            // return BadRequest();

            return CreatedAtAction(nameof(CreateUser), new { id = createUser.Id }, createUser);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromBody] UpdateUserModel updateUser)
        {
            // return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            // return NotFound();

            return NoContent();
        }

        [HttpPut("{id}/login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
