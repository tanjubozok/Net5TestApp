using Net5TestApp.Common.Enums;
using Net5TestApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Net5TestApp.DataAccess.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC);
        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> selector, OrderByType orderByType = OrderByType.DESC);
        Task<T> FindAsync(object id);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter, bool asNoTracking = false);
        IQueryable<T> GetQueryable();
        Task AddAsync(T entity);
        void Remove(T entity);
        void Update(T entity, T unchanget);
    }
}
