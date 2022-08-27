﻿using Microsoft.EntityFrameworkCore;
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

        public async Task DeleteAsync(long id)
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
        public async Task<IEnumerable<T>> GetListByIdAsync(long id)
        {
            var result = await _context.Set<T>().Where(n => n.Id == id).ToListAsync();
            return result;
        }

       


        public async Task<T> GetByIdAsync(long id)
        {
            var result = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task UpdateAsync(long id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            // set the state
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

 
    }
}