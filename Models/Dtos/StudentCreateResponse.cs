using WebDevelopment.Models.Entities;

namespace WebDevelopment.Models.Dtos
{
    public class StudentCreateResponse : BaseResponse
    {
        public string UserName { get; set; } = default!;
        public string MatricNumber { get; set; } = default!;
        public string Role { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = default!;
    }
}
