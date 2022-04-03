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

        public List<Person> GetAll()
        {
            return _context.Persons.ToList();
        }
    }
}
