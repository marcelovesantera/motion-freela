using motionfreela.Application.ViewModels;

namespace motionfreela.Application.Services.Interfaces
{
    public interface ISkillService
    {
        List<SkillViewModel> GetSkills();
    }
}
