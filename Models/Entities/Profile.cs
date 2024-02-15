namespace WebDevelopment.Models.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string? Bio { get; set; }
        public string? ProfilePicture { get; set; }
        public string? SocialMediaLink { get; set; }
        public string? Interests { get; set; }
        public string? Skills { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
