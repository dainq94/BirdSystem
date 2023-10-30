using BusinessObjects.Models;

namespace BirdService
{
    public interface IUserService
    {
        User GetUserByEmail(string email);
        List<User> GetAllUsers();
        bool UserExit(string usernameOrEmailOrPhone);
        void Create(User user);
    }
}
