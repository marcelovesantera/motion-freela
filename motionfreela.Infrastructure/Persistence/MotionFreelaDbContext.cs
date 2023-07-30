using motionfreela.Core.Entities;

namespace motionfreela.Infrastructure.Persistence
{
    public class MotionFreelaDbContext
    {
        public MotionFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project(1, "Frame-by-frame project.", "My first project description."),
                new Project(2, "Flat animation project.", "My second project description."),
                new Project(3, "3D animation project.", "My third project description."),
            };

            Users = new List<User>
            {
                new User("Mark", "Topnick", "MarkImTop", "mark.topnick@email.com", "123456"),
                new User("Julie", "Henderson", "JulieHen", "julie.henderson@email.com", "123456"),
                new User("Sophie", "Johnson", "SoSophie", "sophie.johnson@email.com", "123456"),
            };

            Skills = new List<Skill>
            {
                new Skill("After Effects"),
                new Skill("Blender 3D"),
                new Skill("Illustrator"),
                new Skill("Final Cut"),
                new Skill("Premiere Pro"),
                new Skill("Photoshop"),
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
