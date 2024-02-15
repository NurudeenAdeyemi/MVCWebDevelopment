using WebDevelopment.Models.Dtos;
using WebDevelopment.Models.Entities;
using WebDevelopment.Models.Repositories.Interfaces;
using WebDevelopment.Models.Services.Interface;

namespace WebDevelopment.Models.Services.Implementation
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CourseService(ICourseRepository courseRepository, IUnitOfWork unitOfWork) 
        {
            _courseRepository = courseRepository;
            _unitOfWork = unitOfWork;
        }

        public CourseDTO AddCourse(CreateCourseRequest request)
        {
            //check if course already exist
            bool courseExist = _courseRepository.Exist(x => x.Name == request.Name || x.Code == request.Code);
            if (courseExist)
            {
                return new CourseDTO
                {
                    Message = $"Course with name {request.Name} or Code {request.Code} already exist",
                    Status = false
                };
            }

            var course = new Course
            {
               Name = request.Name,
               Code = request.Code,
               Description = request.Description,
               Unit = request.Unit
            };

            foreach(var lesson in request.Lessons)
            {
                var newLesson = new Lesson
                {
                    Topic = lesson,
                    CourseId = course.Id,
                };
              course.Lessons.Add(newLesson);
            }
            _courseRepository.AddCourse(course);

            _unitOfWork.Save();

            return new CourseDTO
            {
                Name= request.Name,
                Code= request.Code,
                Description= request.Description,
                Unit = request.Unit,
                Message = "",
                Status = true,
                Lessons = request.Lessons
            };
        }

        public BaseResponse DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public CourseDTO GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<CourseDTO> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
