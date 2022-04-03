using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirsBackend.Domain.Entities
{
    public class HeirsDbContext : DbContext
    {
        public HeirsDbContext(DbContextOptions<HeirsDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
