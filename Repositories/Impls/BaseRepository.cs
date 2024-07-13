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
        public TEntity Add(TEntity entity) => BaseDAO<TEntity>.Instance.Add(entity);

        public bool Delete(TEntity entity) => BaseDAO<TEntity>.Instance.Delete(entity);

        public DbSet<TEntity> GetAll() => BaseDAO<TEntity>.Instance.GetAll();

        public TEntity GetById(object id) => BaseDAO<TEntity>.Instance.GetById(id);

        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate) => BaseDAO<TEntity>.Instance.GetFirstOrDefault(predicate);

        public IEnumerable<TEntity> GetWhere(Expression<Func<TEntity, bool>> predicate) => BaseDAO<TEntity>.Instance.GetWhere(predicate);

        public void Update(TEntity entity) => BaseDAO<TEntity>.Instance.Update(entity);
    }
}