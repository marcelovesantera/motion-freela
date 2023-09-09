using motionfreela.Application.InputModels;
using motionfreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motionfreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetProjects(string query);
        ProjectDetailsViewModel GetProjectById(int id);
        int CreateProject(CreateProjectInputModel inputModel);
        void UpdateProject(UpdateProjectInputModel inputModel);
        void DeleteProject(int id);
        void StartProject(int id);
        void FinishProject(int id);
    }
}
