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

        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string RoleTitle { get; set; }
        public string About { get; set; }
    }
}
