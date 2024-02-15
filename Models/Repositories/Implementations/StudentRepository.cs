using WebDevelopment.Models.Context;
using WebDevelopment.Models.Entities;
using WebDevelopment.Models.Repositories.Interfaces;

namespace WebDevelopment.Models.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
       
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            return student;
        }

        public Student GetStudent(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public IReadOnlyList<Student> GetStudents()
        {
            return _context.Students.ToList();
        }
    }
}
