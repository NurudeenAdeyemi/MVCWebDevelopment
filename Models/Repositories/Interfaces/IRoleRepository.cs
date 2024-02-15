using WebDevelopment.Models.Entities;

namespace WebDevelopment.Models.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        IReadOnlyList<Role> GetRoles();
        Role GetRole(int id);
        Role AddRole(Role role);   
    }
}
