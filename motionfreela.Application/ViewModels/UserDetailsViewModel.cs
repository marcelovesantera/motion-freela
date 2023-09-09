using motionfreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motionfreela.Application.ViewModels
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(string name, string lastName, string userName, string email, string? roleTitle, string? about)
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
        public string? RoleTitle { get; private set; }
        public string? About { get; private set; }
    }
}
