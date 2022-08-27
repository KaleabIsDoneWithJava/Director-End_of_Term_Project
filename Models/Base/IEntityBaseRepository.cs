using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director.Models.Base
{
   public interface IEntityBaseRepository<T> where T:class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetListByIdAsync(long id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
        Task AddAsync(T entity);
        Task UpdateAsync(long id, T entity);
        Task DeleteAsync(long id);
    }
}
