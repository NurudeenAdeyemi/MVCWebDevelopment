namespace WebDevelopment.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string HashSalt { get; set; } = default!;
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public Profile Profile { get; set; }
    }
}
