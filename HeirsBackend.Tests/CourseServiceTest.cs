using HeirsBackend.Domain.DataObjects;
using HeirsBackend.Services.IServices;
using HeirsBackend.Services.Services;
using Moq;
using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace HeirsBackend.Tests
{
    public class CourseServiceTest
    {
        private readonly ICourseServices _courseService;

        public CourseServiceTest()
        {
            _courseService = new Mock<ICourseServices>().Object;
        }

        [Fact]
        public void Course_Upload_Should_Fail_On_Property_Empty_Or_Null()
        {
            //Arrange
            List<CourseObj> courses = new List<CourseObj>();
            courses.Add(new CourseObj { id = "c3", name = "" });

            //Act
            var result = _courseService.UploadCourses(courses);

            //Assert
            result.ShouldBeFalse();
            result.ShouldBeOfType<bool>();
        }
    }
}