using WebDevelopment.Models.Context;
using WebDevelopment.Models.Entities;
using WebDevelopment.Models.Repositories.Interfaces;

namespace WebDevelopment.Models.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Role AddRole(Role role)
        {
            _context.Roles.Add(role);
            return role;
        }

        public Role GetRole(int id)
        {
            var role = _context.Roles.FirstOrDefault(r => r.Id == id);
            return role;
        }

        public IReadOnlyList<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
