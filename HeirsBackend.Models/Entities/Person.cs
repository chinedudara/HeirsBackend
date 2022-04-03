using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirsBackend.Domain.Entities
{
    public class Person
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        public string Name { get; set; }
        public int? Score { get; set; }
    }
}
