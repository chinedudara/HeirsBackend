using HeirsBackend.Domain.DataObjects;
using HeirsBackend.Domain.Entities;
using HeirsBackend.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirsBackend.Services.Services
{
    public class CourseService : ICourseServices
    {
        private HeirsDbContext _context;

        public CourseService(HeirsDbContext context)
        {
            _context = context;
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public bool UploadCourses(List<CourseObj> courses)
        {
            List<Course> courseList = new List<Course>();
            courses.ForEach(course =>
            {
                if (!_context.Courses.Any(x => x.Id == course.id))
                {
                    courseList.Add(new Course
                    {
                        Id = course.id,
                        Name = course.name
                    });
                }
            });

            _context.Courses.AddRange(courseList);
            var res = _context.SaveChanges();
            if (res > 0)
            {
                return true;
            }
            return false;
        }
    }
}
