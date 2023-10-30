using BirdRepository;
using BusinessObjects.Models;

namespace BirdService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository = null;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void Create(User user)
        {
            _userRepository.Create(user);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.getAllUsers();
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.getUserByEmail(email);
        }

        public bool UserExit(string usernameOrEmailOrPhone)
        {
            return _userRepository.UserExit(usernameOrEmailOrPhone);
        }

        List<User> IUserService.GetAllUsers()
        {
            throw new NotImplementedException();
        }

        User IUserService.GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}