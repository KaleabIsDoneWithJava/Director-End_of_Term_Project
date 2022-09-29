using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
    public interface IStudentService : IEntityBaseRepository<Student>
    {
        //Functions that are implemented in StudentService
        IEnumerable GetAllStudentDetail();
    }
}
