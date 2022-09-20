using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Director.Models.Base
{
    // These repository is a generic class, meaning that any type of object can use it's containing methods
    // Reinforces the dry principle (Don't repeat yourself)
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly SMSContext _context;
        public EntityBaseRepository(SMSContext context)
        {
            _context = context;
        }

        //Add a single object of type T into any table/class in the db
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        //Delete a single object of type T from any table/class in the db
        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        //Get a all the objects in a table/class of type T from any table/class in the db
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = await _context.Set<T>().ToListAsync();

            return result;
        }

        //Not sure if we will use this
       public async Task<IEnumerable<T>> GetListByIdAsync(int id)
        {
            var result = await _context.Set<T>().Where(n => n.Id == id).ToListAsync();
            return result;
        }

        //Get a single object of type T from any table/class in the db
        public async Task<T> GetByIdAsync(int id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        //Updates a single object of type T in any table/class in the db
        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            // set the state
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }






    }
}