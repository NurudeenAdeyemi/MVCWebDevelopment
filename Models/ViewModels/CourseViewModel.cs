namespace WebDevelopment.Models.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string? Description { get; set; }
        public int Unit { get; set; }
        public int NumberOfLessons { get; set; }
    }
}
