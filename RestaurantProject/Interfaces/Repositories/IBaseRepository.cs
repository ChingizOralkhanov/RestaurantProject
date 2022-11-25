using RestaurantProject.DataLayer.DtoModels;
using System.Linq.Expressions;

namespace RestaurantProject.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseModel
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = new());
        Task<IEnumerable<TEntity>> AddRangeAsync(List<TEntity> entities, CancellationToken cancellationToken = new());
        IQueryable<TEntity> GetQueryable();
        IQueryable<TEntity> GetPageQueryable(int PageSize, int PageNumber, Expression<Func<TEntity, bool>> predicate = null);
        IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = new());
        Task UpdateRangeAsync(List<TEntity> entity, CancellationToken cancellationToken = new());
        Task DeleteAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = new());
        Task DeleteRangeAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = new());
        Task RemoveFromDb(Expression<Func<TEntity, bool>> expression, bool saveChanges = false, CancellationToken cancellationToken = new());
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> GetByIdAsync(Guid id, string include);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
