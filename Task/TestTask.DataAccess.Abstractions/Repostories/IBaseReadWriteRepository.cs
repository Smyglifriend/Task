using Task.DataAccess.Domain.Abstractions.Interfaces;

namespace Task.DataAccess.Abstractions.Repostories;

public interface IBaseReadWriteRepository<TEntity>
    : IBaseReadonlyRepository<TEntity>
    where TEntity : class, IEntity
{
    Task<long> SaveAsync(TEntity model);

    Task SaveChangesAsync();

    Task RemoveAsync(TEntity model);

    Task RemoveAsync(long id);
}