using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
    public interface ITeacherService : IEntityBaseRepository<Teacher>
    {
        //Functions that are implemented in TeacherService
        IEnumerable GetAllTeacherDetail()
        //Task<IEnumerable> GetAllTeacherDetail()

;

    }
}
