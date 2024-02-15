using WebDevelopment.Models.Entities;

namespace WebDevelopment.Models.Dtos
{
    public class StudentCreateRequestModel
    {
        public string Password { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Address { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }
    }
}
