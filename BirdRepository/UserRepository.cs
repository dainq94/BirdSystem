using BirdDAO;
using BusinessObjects.Models;

namespace BirdRepository
{
    public class UserRepository : IUserRepository
    {
        public void Create(User user)
        => UserDAO.Instance.Create(user);

        public List<User> getAllUsers()
        => UserDAO.Instance.GetAllUsers();

        public User getUserByEmail(string email)
        => UserDAO.Instance.GetUserByEmail(email);

        public bool UserExit(string usernameOrEmailOrPhone)
        {
            throw new NotImplementedException();
        }
    }
}