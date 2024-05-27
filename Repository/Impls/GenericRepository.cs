using DataAccessObjects.Interfaces;
using DataAccessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects.Impls;
using Repositories.Interfaces;

namespace Repositories.Impls
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly IGenericDAO<TEntity> _genericDAO;

        public GenericRepository(IGenericDAO<TEntity> genericDAO)
        {
            _genericDAO = genericDAO;
        }

        public async Task<TEntity> FindAsync(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.FindAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding entity: {ex.Message}", ex);
            }
        }

        public async Task<IQueryable<TEntity>> FindAll(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.FindAll(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding all entities: {ex.Message}", ex);
            }
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _genericDAO.FindAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding entity: {ex.Message}", ex);
            }
        }

        public async Task<IQueryable<TEntity>> GetAllAsync()
        {
            try
            {
                return await _genericDAO.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all entities: {ex.Message}", ex);
            }
        }

        public async Task DeleteRangeAsync(IQueryable<TEntity> entities)
        {
            try
            {
                await _genericDAO.DeleteRangeAsync(entities);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting range of entities: {ex.Message}", ex);
            }
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            try
            {
                return await _genericDAO.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting entity by ID: {ex.Message}", ex);
            }
        }

        public async Task<IEnumerable<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _genericDAO.GetWhereAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting entities by predicate: {ex.Message}", ex);
            }
        }

        public async Task<bool> HardDeleteAsync(object key)
        {
            try
            {
                return await _genericDAO.HardDeleteAsync(key);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error hard deleting entity: {ex.Message}", ex);
            }
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            try
            {
                return await _genericDAO.DeleteAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting entity: {ex.Message}", ex);
            }
        }

        public async Task<bool> HardDeleteIdAsync(object key)
        {
            try
            {
                return await _genericDAO.HardDeleteIdAsync(key);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error hard deleting entity by ID: {ex.Message}", ex);
            }
        }

        public async Task<bool> InsertAsync(TEntity entity)
        {
            try
            {
                return await _genericDAO.InsertAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting entity: {ex.Message}", ex);
            }
        }

        public async Task<bool> InsertRangeAsync(IQueryable<TEntity> entities)
        {
            try
            {
                return await _genericDAO.InsertRangeAsync(entities);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting range of entities: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateByIdAsync(TEntity entity, object id)
        {
            try
            {
                return await _genericDAO.UpdateByIdAsync(entity, id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating entity by ID: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateRangeAsync(IQueryable<TEntity> entities)
        {
            try
            {
                return await _genericDAO.UpdateRangeAsync(entities);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating range of entities: {ex.Message}", ex);
            }
        }

        public async Task<bool> AnyAsync(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.AnyAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking if any entity matches predicate: {ex.Message}", ex);
            }
        }

        public async Task<int> CountAsync(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.CountAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error counting entities by predicate: {ex.Message}", ex);
            }
        }

        public async Task<int> CountAsync()
        {
            try
            {
                return await _genericDAO.CountAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error counting entities: {ex.Message}", ex);
            }
        }

        public async Task<TEntity> FistOrDefault(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.FistOrDefault(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding first or default entity: {ex.Message}", ex);
            }
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _genericDAO.FirstOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding first or default entity: {ex.Message}", ex);
            }
        }

        public async Task<bool> SaveChagesAysnc()
        {
            try
            {
                return await _genericDAO.SaveChagesAysnc();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving changes: {ex.Message}", ex);
            }
        }

        public async Task<bool> IsMinAsync(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.IsMinAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking if entity is min: {ex.Message}", ex);
            }
        }

        public async Task<bool> IsMaxAsync(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.IsMaxAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking if entity is max: {ex.Message}", ex);
            }
        }

        public async Task<TEntity> GetMinAsync()
        {
            try
            {
                return await _genericDAO.GetMinAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting min entity: {ex.Message}", ex);
            }
        }

        public async Task<TEntity> GetMaxAsync()
        {
            try
            {
                return await _genericDAO.GetMaxAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting max entity: {ex.Message}", ex);
            }
        }

        public async Task<bool> IsMaxAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _genericDAO.IsMaxAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking if entity is max: {ex.Message}", ex);
            }
        }

        public async Task<bool> IsMinAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                return await _genericDAO.IsMinAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking if entity is min: {ex.Message}", ex);
            }
        }

        public async Task<TEntity> GetMinAsync(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.GetMinAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting min entity: {ex.Message}", ex);
            }
        }

        public async Task<TEntity> GetMaxAsync(Func<TEntity, bool> predicate)
        {
            try
            {
                return await _genericDAO.GetMaxAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting max entity: {ex.Message}", ex);
            }
        }
    }
}