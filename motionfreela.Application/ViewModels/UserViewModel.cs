using motionfreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motionfreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string name, string lastName, string userName, string email)
        {
            Name = name;
            LastName = lastName;
            UserName = userName;
            Email = email;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
    }
}
