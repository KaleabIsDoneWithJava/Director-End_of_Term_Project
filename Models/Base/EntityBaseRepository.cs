using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly SMSContext _context;
        public EntityBaseRepository(SMSContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();

            return result;
        }

        //Not sure aobut this
       public async Task<IEnumerable<T>> GetListByIdAsync(int id)
        {
            var result = await _context.Set<T>().Where(n => n.Id == id).ToListAsync();
            return result;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            // set the state
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        //Returns the subject that the teacher teaches
        public List<Teacher> AddSubjectTaught(List<Teacher> teachers)
        {
            var ts = new List<Teacher>();
            
                ts = (from t in _context.Teachers 
                      join sg in _context.SubjectForGrades
                      on t.SubjectForGradeId equals sg.Id
                      join s in _context.Subjects
                      on sg.SubjectId equals s.Id
                      join g in _context.Grades
                      on sg.GradeId equals g.Id
                      select t).ToList();           


            /*var subjectForGrades;
            var result ;

            foreach (var teacher in teachers)
            {
                 subjectForGrades = await _context.SubjectForGrades.Where(c => c.Id == teacher.SubjectId).FirstOrDefaultAsync();
                 result = await _context.Subjects.Where(s => s.Id == subjectForGrades.Id).FirstOrDefaultAsync();
                

            }*/



            return ts;
        }





    }
}