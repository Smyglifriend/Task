using TestTask.DataAccess.Domain.Abstractions.Interfaces;

namespace TestTask.DataAccess.Abstractions.Repostories;

public interface IUnitOfWork
{
    IBaseReadonlyRepository<TEntity> GetReadonlyRepository<TEntity>() 
        where TEntity : class;

    IBaseReadWriteRepository<TEntity> GetReadWriteRepository<TEntity>() 
        where TEntity : class, IEntity;

    TIRepository GetCustomRepository<TEntity, TIRepository>()
        where TEntity : class
        where TIRepository : class, IBaseReadonlyRepository<TEntity>;

    Task<int> SaveChangesAsync();
}