using motionfreela.Application.InputModels;
using motionfreela.Application.Services.Interfaces;
using motionfreela.Application.ViewModels;
using motionfreela.Core.Entities;
using motionfreela.Infrastructure.Persistence;

namespace motionfreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly MotionFreelaDbContext _dbContext;
        public ProjectService(MotionFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateProject(CreateProjectInputModel inputModel)
        {
            var newProject = new Project(
                inputModel.OwnerId,
                inputModel.Title,
                inputModel.Description
                );

            _dbContext.Projects.Add(newProject);

            return newProject.Id;
        }

        public void DeleteProject(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            project.Cancel();
        }

        public void FinishProject(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            project.Finish();
        }

        public ProjectDetailsViewModel GetProjectById(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            var projectDetailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.CreatedAt,
                project.UpdatedAt,
                project.StartDate,
                project.DeadlineDate,
                project.StartedAt,
                project.FinisehdAt,
                project.Status
                );

            return projectDetailsViewModel;
        }

        public List<ProjectViewModel> GetProjects(string query)
        {
            var projects = _dbContext.Projects;

            var projectsViewModel = projects.Select(p => new ProjectViewModel(
                p.Id,
                p.Title,
                p.Description
                )).ToList();

            return projectsViewModel;
        }

        public void StartProject(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            project.Start();
        }

        public void UpdateProject(UpdateProjectInputModel inputModel)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == inputModel.Id);

            project.Update(inputModel.Title, inputModel.Description, inputModel.StartDate, inputModel.DeadlineDate);
        }
    }
}
