using WebDevelopment.Models.Entities;

namespace WebDevelopment.Models.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        IReadOnlyList<Student> GetStudents();
        Student GetStudent(int id);
        Student AddStudent(Student student);
    }
}
