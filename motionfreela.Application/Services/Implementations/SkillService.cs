using motionfreela.Application.Services.Interfaces;
using motionfreela.Application.ViewModels;
using motionfreela.Infrastructure.Persistence;

namespace motionfreela.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        private readonly MotionFreelaDbContext _dbContext;
        public SkillService(MotionFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SkillViewModel> GetSkills()
        {
            var skills = _dbContext.Skills;
            
            var skillsViewModel = skills
                .Select(s => new SkillViewModel(s.SkillName))
                .ToList();
            
            return skillsViewModel;
        }
    }
}
