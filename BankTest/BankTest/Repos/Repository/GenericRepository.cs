﻿using BankTest.Data;
using BankTest.Repos.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankTest.Repos.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly BankTestContext _context; // use dependecy injection
        internal DbSet<T> dbSet;
        public GenericRepository(BankTestContext context)
        {
            _context = context;
            dbSet = context.Set<T>();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<EntityEntry<T>> Add(T entity)
        {
           return await dbSet.AddAsync(entity);
        }

        public virtual EntityEntry<T> Remove(T entity)
        {
            return dbSet.Remove(entity);
        }

        public virtual EntityEntry<T> Update(T entity) => dbSet.Update(entity);


        public virtual IQueryable<T> Where(params Expression<Func<T, bool>> [] predicates)
        {
            if (predicates != null && predicates.Length > 0)
            {
                IQueryable<T> _query = _context.Set<T>();
                foreach (var p in predicates)
                {
                    if(p != null)
                        _query = _query.Where(p);
                }
                return _query;
            }
            return _context.Set<T>();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
