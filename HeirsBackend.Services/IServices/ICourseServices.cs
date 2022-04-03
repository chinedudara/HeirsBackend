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
        List<Person> GetAll();
    }
}
