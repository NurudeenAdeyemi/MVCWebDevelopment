using WebDevelopment.Models.Dtos;
using WebDevelopment.Models.Entities;
using WebDevelopment.Models.Exceptions;
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
                /*return new CourseDTO
                {
                    Message = $"Course with name {request.Name} or Code {request.Code} already exist",
                    Status = false
                };*/
                throw new BadRequestException($"Course with name {request.Name} or Code {request.Code} already exist");
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
            };
        }

        public BaseResponse DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public CourseDTO GetCourse(int id)
        {
            var course = _courseRepository.GetCourse(id);
            if(course is null)
            {
                throw new NotFoundException($"Course with id:{id} does not exist");
            }
            return new CourseDTO
            {
                CourseId=course.Id,
                Code = course.Code,
                Name = course.Name,
                Description = course.Description,
                Unit = course.Unit,
                Lessons = course.Lessons.Select(x => new Less3(x.Id, x.Topic)).ToList(),
                Status = true
            };
        }

        public IReadOnlyList<CourseDTO> GetCourses()
        {
            var courses = _courseRepository.GetCourses();
            return courses.Select(course => new CourseDTO
            {
                CourseId = course.Id,
                Code = course.Code,
                Name = course.Name,
                Description = course.Description,
                Unit = course.Unit,
                Lessons = course.Lessons.Select(x => new Less3(x.Id, x.Topic)).ToList(),
                Status = true
            }).ToList();
        }

        public CourseDTO UpdateCourse(UpdateCourseRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
