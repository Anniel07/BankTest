using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankTest.Repos.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<EntityEntry<T>> Add(T entity);
        EntityEntry<T> Remove(T entity);
        EntityEntry<T> Update(T entity);

        /// <summary>
        /// Apply dinamic where filter
        /// </summary>
        /// <param name="predicates"></param>
        /// <returns></returns>
        IQueryable <T> Where(params Expression<Func<T, bool>>[] predicates);
        Task<bool> SaveChangesAsync();
    }
}
