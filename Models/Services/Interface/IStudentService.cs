using WebDevelopment.Models.Dtos;

namespace WebDevelopment.Models.Services.Interface
{
    public interface IStudentService
    {
        StudentCreateResponse AddStudent(StudentCreateRequestModel model);
    }
}
