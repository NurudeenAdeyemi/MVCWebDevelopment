namespace WebDevelopment.Models.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
