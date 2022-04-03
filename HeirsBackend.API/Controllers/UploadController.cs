using HeirsBackend.Domain.DataObjects;
using HeirsBackend.Domain.Entities;
using HeirsBackend.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HeirsBackend.API.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        private ICourseServices _courseService;

        public UploadController(ICourseServices courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("/getcourses")]
        public IActionResult GetAllCourses()
        {
            var res = _courseService.GetCourses();
            return Ok(res);
        }

        [HttpGet("/getpersons")]
        public IActionResult GetAllPersons()
        {
            var res = _courseService.GetPersons();
            return Ok(res);
        }

        [HttpPost("/uploadcourses")]
        public IActionResult UploadCourses([FromBody] CourseUploadDTO requestObj)
        {
            var res = _courseService.UploadCourses(requestObj.courses);
            return Ok(res);
        }

        [HttpPost("/uploadpersonaldata")]
        public IActionResult UploadPersons([FromBody] PersonUploadDTO requestObj)
        {
            var res = _courseService.UploadPersons(requestObj.persons);
            return Ok(res);
        }

        [HttpGet("/reportpersonalprogress/{id}")]
        public IActionResult GetGPA(string id)
        {
            var res = _courseService.GetProgress(id);
            return Ok(res);
        }
    }
}
