using HeirsBackend.Domain.DataObjects;
using HeirsBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirsBackend.Services.IServices
{
    public interface ICourseServices
    {
        List<Course> GetCourses();
        List<Person> GetPersons();
        bool UploadCourses(List<CourseObj> courses);
        bool UploadPersons(List<PersonObj> persons);
        PersonalProgressVieModel GetProgress(string id);
    }
}
