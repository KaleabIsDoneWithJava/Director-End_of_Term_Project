using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Director.Models.Base;

namespace Director.Models.Services
{
    public class ClassService : EntityBaseRepository<Class>, IClassService
    {
        private readonly SMSContext _context;
        public ClassService(SMSContext context) : base(context)
        {
            _context = context;
        }
        
        //returns the classId from the db given the gradeId and SectionId from the model class
        public int GetClassGradeSection(int GradeId, int SectionId)
        {
            var result =  (from c in _context.Classes
                                where c.GradeId == GradeId 
                                where c.SectionId == SectionId
                                select c.Id).First();
            
            return result;
        }

    }
}
