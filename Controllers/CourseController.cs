using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebDevelopment.Models.Dtos;
using WebDevelopment.Models.Entities;
using WebDevelopment.Models.Services.Interface;
using WebDevelopment.Models.ViewModels;

namespace WebDevelopment.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            var courses = _courseService.GetCourses();
            var result = courses.Select(x => new CourseViewModel
            {
                Id = x.CourseId,
                Name = x.Name,
                Code = x.Code,
                Unit = x.Unit,
                NumberOfLessons = x.Lessons.Count(),
            }).ToList();
            return View(result);
        }

        public IActionResult GetCourse(int id)
        {
            var x = _courseService.GetCourse(id);
            var result = new CourseViewModel
            {
                Id = x.CourseId,
                Name = x.Name,
                Code = x.Code,
                Unit = x.Unit,
                Description = x.Description,
            };
            return View(result);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(CreateCourseViewModel model, string Lesson1, string Lesson2, string Lesson3)
        {
            var request = new CreateCourseRequest
            {
                Name = model.Name,
                Code = model.Code,
                Description = model.Description,
                Unit = model.Unit,
                Lessons = new List<string> { Lesson1, Lesson2, Lesson3 },
            };

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = _courseService.AddCourse(request);
            ViewBag.CourseResponse = result.Message;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var x = _courseService.GetCourse(id);

            if (x == null)
            {
                return NotFound();
            }
            var result = new CourseViewModel
            {
                Id = x.CourseId,
                Name = x.Name,
                Code = x.Code,
                Unit = x.Unit,
                Description = x.Description,
            };
            return View(result);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _courseService.DeleteCourse(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
