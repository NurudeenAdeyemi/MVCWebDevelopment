using WebDevelopment.Models.Dtos;
using WebDevelopment.Models.Repositories.Interfaces;
using WebDevelopment.Models.Services.Interface;

namespace WebDevelopment.Models.Services.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly IUserRepository _userRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUserRepository userRepository, IStudentRepository studentRepository, IUnitOfWork unitOfWork) 
        { 
            _userRepository = userRepository;
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }

        public StudentCreateResponse AddStudent(StudentCreateRequestModel model)
        {
            var usernameExist = _studentRepository.GetStudent();
        }
    }
}
