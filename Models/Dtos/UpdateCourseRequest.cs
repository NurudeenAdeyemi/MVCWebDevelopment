namespace WebDevelopment.Models.Dtos
{
    public class UpdateCourseRequest
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Code { get; set; } = default!;
        public int Unit { get; set; }
        public required IReadOnlyList<string> Lessons { get; set; }
    }
}