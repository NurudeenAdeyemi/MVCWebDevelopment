namespace WebDevelopment.Models.Dtos
{
    public class CourseDTO : BaseResponse
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Code { get; set; } = default!;
        public int Unit { get; set; }
        public IReadOnlyList<Less3> Lessons { get; set; }
    }

    public class LessonDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public record Less3(int Id, string Title);
}
