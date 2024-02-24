using System.ComponentModel.DataAnnotations;

namespace WebDevelopment.Models.ViewModels
{
    public class CreateCourseViewModel
    {
        [Required(ErrorMessage = "Name length cannot exceed 50 characters")]
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Code { get; set; } = default!;
        public int Unit { get; set; }
    }
}
