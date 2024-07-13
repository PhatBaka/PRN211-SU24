using DataAccessObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Impls
{
    public class BaseDAO<TEntity> : IBaseDAO<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        private static BaseDAO<TEntity> instance = null;
        private static readonly object InstanceLock = new object();

        public BaseDAO(AppDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public static BaseDAO<TEntity> Instance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        AppDBContext context = new AppDBContext();
                        instance = new BaseDAO<TEntity>(context);
                    }
                    return instance;
                }
            }
        }

        public TEntity GetById(object id)
        {
            try
            {
                return _dbSet.Find(id);
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw new Exception("Error occurred while fetching by Id", ex);
            }
        }

        public DbSet<TEntity> GetAll()
        {
            try
            {
                return _dbSet;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw new Exception("Error occurred while fetching all entities", ex);
            }
        }

        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return _dbSet.FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw new Exception("Error occurred while fetching first entity with predicate", ex);
            }
        }

        public IEnumerable<TEntity> GetWhere(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return _dbSet.Where(predicate).ToList();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw new Exception("Error occurred while fetching entities with predicate", ex);
            }
        }

        public TEntity Add(TEntity entity)
        {
            try
            {
                // Attach the entity to the context if it's not already being tracked
                var entry = _context.Entry(entity);
                if (entry.State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }

                _dbSet.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw new Exception("Error occurred while adding entity", ex);
            }
        }


        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                _dbSet.Remove(entity);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                throw new Exception("Error occurred while deleting entity", ex);
            }
        }
    }
}