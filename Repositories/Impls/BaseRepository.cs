using DataAccessObjects.Impls;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Impls
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public Task<TEntity> AddAsync(TEntity entity) => BaseDAO<TEntity>.Instance.AddAsync(entity);

        public Task<bool> DeleteAsync(TEntity entity) => BaseDAO<TEntity>.Instance.DeleteAsync(entity);

        public Task<DbSet<TEntity>> GetAllAsync() => BaseDAO<TEntity>.Instance.GetAllAsync();

        public Task<TEntity> GetByIdAsync(object id) => BaseDAO<TEntity>.Instance.GetByIdAsync(id);

        public Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate) => BaseDAO<TEntity>.Instance.GetFirstOrDefaultAsync(predicate);

        public Task<IEnumerable<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> predicate) => BaseDAO<TEntity>.Instance.GetWhereAsync(predicate);

        public Task<bool> UpdateAsync(TEntity entity) => BaseDAO<TEntity>.Instance.UpdateAsync(entity);
    }
}