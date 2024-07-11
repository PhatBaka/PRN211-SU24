using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(object id);
        DbSet<TEntity> GetAll();
        TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetWhere(Expression<Func<TEntity, bool>> predicate);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
