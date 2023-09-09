using motionfreela.Application.InputModels;
using motionfreela.Application.ViewModels;

namespace motionfreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> GetUsers(string query);
        UserDetailsViewModel GetUserById(int id);
        int CreateUser(CreateUserInputModel inputModel);
        void UpdateUser(UpdateUserViewModel inputModel);
        void DeleteUser(int id);
        void Login(LoginInputModel inputModel);
    }
}
