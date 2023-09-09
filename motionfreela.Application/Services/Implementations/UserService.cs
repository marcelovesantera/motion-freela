using motionfreela.Application.InputModels;
using motionfreela.Application.Services.Interfaces;
using motionfreela.Application.ViewModels;
using motionfreela.Core.Entities;
using motionfreela.Infrastructure.Persistence;

namespace motionfreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly MotionFreelaDbContext _dbContext;
        public UserService(MotionFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateUser(CreateUserInputModel inputModel)
        {
            var newUser = new User(
                inputModel.Name,
                inputModel.LastName,
                inputModel.UserName,
                inputModel.Email,
                inputModel.Password
                );

            _dbContext.Users.Add(newUser);

            return newUser.Id;
        }
        public void DeleteUser(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            user?.Deactivate();
        }
        public UserDetailsViewModel GetUserById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            var userDetailsViewModel = new UserDetailsViewModel(
                user.Name,
                user.LastName,
                user.UserName,
                user.Email,
                user.RoleTitle,
                user.About
                );

            return userDetailsViewModel;
        }
        public List<UserViewModel> GetUsers(string query)
        {
            var users = _dbContext.Users;

            var usersViewModel = users
                .Select(u => new UserViewModel(
                    u.Name,
                    u.LastName,
                    u.UserName,
                    u.Email
                    ))
                .ToList();

            return usersViewModel;
        }
        public void UpdateUser(UpdateUserViewModel inputModel)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == inputModel.Id);

            user.Update(
                inputModel.Name,
                inputModel.LastName,
                inputModel.UserName,
                inputModel.Email,
                inputModel.RoleTitle,
                inputModel.About
                );
        }
        public void Login(LoginInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
