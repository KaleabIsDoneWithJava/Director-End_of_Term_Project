using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;
using static Director.Models.Services.StudentService;

namespace Director.Models.Services
{
    public interface IStudentService : IEntityBaseRepository<Student>
    {
        //Functions that are implemented in StudentService
        IEnumerable<TempStudent> GetAllStudentDetail();
        //List<string> SearchStudents(string SearchKeyword);

    }
}
