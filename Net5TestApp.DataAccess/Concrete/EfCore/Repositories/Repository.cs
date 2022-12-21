using Microsoft.EntityFrameworkCore;
using Net5TestApp.Common.Enums;
using Net5TestApp.DataAccess.Abstract;
using Net5TestApp.DataAccess.Concrete.EfCore.Context;
using Net5TestApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Net5TestApp.DataAccess.Concrete.EfCore.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DatabaseContext _context;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<List<T>> GetAllAsync()
        {
            return await Table.AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await Table.AsNoTracking().Where(filter).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC
                ? await Table.AsNoTracking().OrderBy(selector).ToListAsync()
                : await Table.AsNoTracking().OrderByDescending(selector).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC)
        {
            return orderByType == OrderByType.ASC
                ? await Table.AsNoTracking().Where(filter).OrderBy(selector).ToListAsync()
                : await Table.AsNoTracking().Where(filter).OrderByDescending(selector).ToListAsync();
        }

        public async Task<T> FindAsync(object id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, bool asNoTracking = false)
        {
            return !asNoTracking
                ? await Table.AsNoTracking().SingleOrDefaultAsync(filter)
                : await Table.SingleOrDefaultAsync(filter);
        }

        public IQueryable<T> GetQueryable()
        {
            return Table.AsQueryable();
        }

        public void Remove(T entity)
        {
            Table.Remove(entity);
        }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public void Update(T entity, T unchanget)
        {
            _context.Entry(unchanget).CurrentValues.SetValues(entity);
        }
    }
}
