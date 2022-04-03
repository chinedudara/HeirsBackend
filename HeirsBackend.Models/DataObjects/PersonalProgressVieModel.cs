using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeirsBackend.Domain.DataObjects
{
    public class PersonalProgressVieModel
    {
        public string name { get; set; }
        public List<string> courses { get; set; } = new List<string>();
        public int gpa { get; set; }
    }
}
