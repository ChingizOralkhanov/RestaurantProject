using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer;
using RestaurantProject.DataLayer.DtoModels;
using RestaurantProject.Exceptions;
using RestaurantProject.Interfaces.Repositories;
using System.Linq.Expressions;

namespace RestaurantProject.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseModel
    {
        public readonly AppDbContext _dbContext;
        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = new())
        {
            await _dbContext.Set<TEntity>().AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> AddRangeAsync(List<TEntity> entities, CancellationToken cancellationToken = default)
        {
            await _dbContext.Set<TEntity>().AddRangeAsync(entities, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
            => await GetQueryable().AnyAsync(predicate);

        public async Task DeleteAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            var dbSet = _dbContext.Set<TEntity>();
            var entity = await dbSet.Where(e => !e.IsDeleted).FirstOrDefaultAsync(expression, cancellationToken);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity).Name);
            }

            entity.DeleteRecord();
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteRangeAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            var dbSet = _dbContext.Set<TEntity>();
            var entities = dbSet.Where(e => !e.IsDeleted).Where(expression);
            await entities.ForEachAsync(e => e.DeleteRecord());
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public IQueryable<TEntity> GetAll() => _dbContext.Set<TEntity>();

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
            => _dbContext.Set<TEntity>().Where(predicate);

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            var dbSet = _dbContext.Set<TEntity>();
            return await dbSet.FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted);
        }

        public async Task<TEntity> GetByIdAsync(Guid id, string include)
        {
            var dbSet = _dbContext.Set<TEntity>();
            return await dbSet.Include(include).FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted);
        }

        public IQueryable<TEntity> GetPageQueryable(int PageSize, int PageNumber, Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate == null)
                return _dbContext.Set<TEntity>().Where(c => !c.IsDeleted).Skip((PageNumber - 1) * PageSize).Take(PageSize);
            else
                return _dbContext.Set<TEntity>().Where(e => !e.IsDeleted).Where(predicate).Skip((PageNumber - 1) * PageSize).Take(PageSize);
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _dbContext.Set<TEntity>().Where(c => !c.IsDeleted);
        }

        public IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveFromDb(Expression<Func<TEntity, bool>> expression, bool saveChanges = false, CancellationToken cancellationToken = default)
        {
            var dbSet = _dbContext.Set<TEntity>();
            var entities = dbSet.Where(e => !e.IsDeleted).Where(expression);
            dbSet.RemoveRange(entities);
            if (saveChanges)
                await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task UpdateRangeAsync(List<TEntity> entity, CancellationToken cancellationToken = default)
        {
            _dbContext.UpdateRange(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
