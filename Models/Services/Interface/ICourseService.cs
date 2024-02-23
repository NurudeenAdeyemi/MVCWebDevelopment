using WebDevelopment.Models.Dtos;

namespace WebDevelopment.Models.Services.Interface
{
    public interface ICourseService
    {
        //add new course
        CourseDTO AddCourse(CreateCourseRequest request);
        //update a course
        CourseDTO UpdateCourse(UpdateCourseRequest request);
        //view all courses
        IReadOnlyList<CourseDTO> GetCourses();
        //view a specific course details
        CourseDTO GetCourse(int id);
        //remove a course
        BaseResponse DeleteCourse(int id);
        //update a course

        // view course students
    }
}
