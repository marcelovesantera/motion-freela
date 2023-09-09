using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using motionfreela.API.Models;
using motionfreela.Application.InputModels;
using motionfreela.Application.Services.Interfaces;

namespace motionfreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public IActionResult GetProjects(string query)
        {
            var projects = _projectService.GetProjects(query);

            return Ok(projects);
        }

        [HttpGet("{id}")]
        public IActionResult GetProjectById(int id)
        {
            var project = _projectService.GetProjectById(id);

            if(project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpPost]
        public IActionResult CreateProject([FromBody] CreateProjectInputModel createProject)
        {
            if(createProject.Description.Length > 200)
            {
                return BadRequest();
            }
            
            var projectId = _projectService.CreateProject(createProject);

            return CreatedAtAction(nameof(GetProjectById), new { id = projectId }, createProject);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProject(int id, [FromBody] UpdateProjectInputModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            _projectService.UpdateProject(updateProject);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProject(int id)
        {
            _projectService.DeleteProject(id);

            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult StartProject(int id)
        {
            _projectService.StartProject(id);

            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult FinishProject(int id)
        {
            _projectService.FinishProject(id);

            return NoContent();
        }
    }
}
