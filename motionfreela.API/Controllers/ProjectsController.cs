using Microsoft.AspNetCore.Mvc;
using motionfreela.API.Models;

namespace motionfreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProjects()
        {
            return Ok();
        }

        [HttpGet("{id")]
        public IActionResult GetProjectById(int id)
        {
            // return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult CreateProject([FromBody] CreateProjectModel createProject)
        {
            // return BadRequest();

            return CreatedAtAction(nameof(GetProjectById), new { id = createProject.Id }, createProject);
        }

        [HttpPut]
        public IActionResult UpdateProject(int id, [FromBody] UpdateProjectModel updateProject)
        {
            // return BadRequest();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProject(int id)
        {
            // return NotFound();

            return NoContent();
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
