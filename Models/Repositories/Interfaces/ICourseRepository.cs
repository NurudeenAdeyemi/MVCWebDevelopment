using WebDevelopment.Models.Entities;

namespace WebDevelopment.Models.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        IReadOnlyList<Course> GetCourses();
        Course GetCourse(int id);
        Course AddCourse(Course course);
        bool Exist(Func<Course, bool> predicate);
    }
}
