using WebDevelopment.Models.Entities;

namespace WebDevelopment.Models.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IReadOnlyList<User> GetUsers();
        User GetUser(int id);
        User AddUser(User user);
    }
}
