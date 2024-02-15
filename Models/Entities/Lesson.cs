namespace WebDevelopment.Models.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Topic { get; set; } = default!;
        public int CourseId { get; set; }
        public Course Course { get; set;}
    }
}
