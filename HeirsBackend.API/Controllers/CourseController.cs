using HeirsBackend.Domain.Entities;
using HeirsBackend.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HeirsBackend.API.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private ICourseServices _courseService;

        public CourseController(ICourseServices courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("/get")]
        public IActionResult GetAll()
        {
            var res = _courseService.GetAll();
            return Ok(res);
        }

        [HttpPost("/uploadcourses")]
        public IActionResult UploadCourses(List<Course> courses)
        {
            return Ok();
        }
    }
}
