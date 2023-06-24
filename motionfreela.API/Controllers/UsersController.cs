﻿using Microsoft.AspNetCore.Mvc;
using motionfreela.API.Models;

namespace motionfreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
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
        public IActionResult UpdateUser(int id, [FromBody] UpdateUserModel updateUser)
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
    }
}
