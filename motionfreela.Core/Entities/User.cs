namespace motionfreela.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string lastName, string userName, string email, string password)
        {
            Name = name;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Password = password;
            Skills = new List<Skill>();
            Projects = new List<Project>();
            CreatedAt = DateTime.Now;
            IsActive = true;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string RoleTitle { get; private set; }
        public string About { get; private set; }
        public List<Skill> Skills { get; private set; }
        public List<Project> Projects { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
