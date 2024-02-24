using Microsoft.EntityFrameworkCore;
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

        public void Delete(Course course)
        {
            _context.Courses.Remove(course);
        }

        public bool Exist(Func<Course, bool> predicate)
        {
            return _context.Courses.Any(predicate);
        }

        public Course? GetCourse(int id)
        {
            return _context.Courses.SingleOrDefault(c => c.Id == id);
        }

        public IReadOnlyList<Course> GetCourses()
        {
            return _context.Courses.Include(x => x.Lessons).ToList();  
        }
    }
}
