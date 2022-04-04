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

        public List<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }

        public List<Person> GetPersons()
        {
            return _context.Persons.ToList();
        }

        public bool UploadCourses(List<CourseObj> courses)
        {
            try
            {
                List<Course> courseList = new List<Course>();
                courses.ForEach(course =>
                {
                    if (string.IsNullOrEmpty(course.id) || string.IsNullOrEmpty(course.name))
                    {
                        return;
                    }

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
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UploadPersons(List<PersonObj> persons)
        {
            try
            {
                List<Person> personList = new List<Person>();
                persons.ForEach(person =>
                {
                    if (!_context.Persons.Any(x => x.PersonId == person.person_id && x.CourseId == person.course_id))
                    {
                        personList.Add(new Person
                        {
                            Id = person.person_id + person.course_id,
                            PersonId = person.person_id,
                            Name = person.name,
                            Score = person.score,
                            CourseId = person.course_id
                        });
                    }
                });

                _context.Persons.AddRange(personList);
                var res = _context.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public PersonalProgressVieModel GetProgress(string id)
        {
            int totalScore = 0;
            var courses = GetCourses();
            PersonalProgressVieModel model = new PersonalProgressVieModel();
            List<Person> personList = _context.Persons.Where(x => x.PersonId == id).ToList();
            personList.ForEach(person =>
            {
                model.courses.Add(courses.First(x => x.Id == person.CourseId).Name);
                totalScore += (person.Score == null) ? 0 : person.Score.GetValueOrDefault();
            });

            model.gpa = totalScore / personList.Count;
            model.name = personList.FirstOrDefault().Name;
            return model;
        }
    }
}
