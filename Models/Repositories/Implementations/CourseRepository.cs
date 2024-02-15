using WebDevelopment.Models.Context;
using WebDevelopment.Models.Entities;
using WebDevelopment.Models.Repositories.Interfaces;

namespace WebDevelopment.Models.Repositories.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Course AddCourse(Course course)
        {
            _context.Courses.Add(course);
            return course;
        }

        public Course GetCourse(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.Id == id);
        }

        public IReadOnlyList<Course> GetCourses()
        {
            return _context.Courses.ToList();  
        }
    }
}
