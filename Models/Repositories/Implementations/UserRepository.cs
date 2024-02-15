using WebDevelopment.Models.Context;
using WebDevelopment.Models.Entities;
using WebDevelopment.Models.Repositories.Interfaces;

namespace WebDevelopment.Models.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) 
        {
           _context = context;
        }
        public User AddUser(User user)
        {
        _context.Users.Add(user);
            return user;
        }

        public User GetUser(int id)
        {
            return _context.Users.FirstOrDefault(a => a.Id == id);
        }


        public IReadOnlyList<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
