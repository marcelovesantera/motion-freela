using motionfreela.Application.InputModels;
using motionfreela.Application.Services.Interfaces;
using motionfreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motionfreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        public int CreateUser(CreateUserInputModel inputModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserDetailsViewModel GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserViewModel> GetUsers(string query)
        {
            throw new NotImplementedException();
        }

        public void Login(LoginInputModel inputModel)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UpdateUserViewModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
