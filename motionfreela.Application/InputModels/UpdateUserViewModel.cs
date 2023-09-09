namespace motionfreela.Application.InputModels
{
    public class UpdateUserViewModel : BaseInputModel
    {
        public UpdateUserViewModel(string name, string lastName, string userName, string email, string roleTitle, string about)
        {
            Name = name;
            LastName = lastName;
            UserName = userName;
            Email = email;
            RoleTitle = roleTitle;
            About = about;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string RoleTitle { get; private set; }
        public string About { get; private set; }
    }
}
