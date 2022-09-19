using ModsenTask.DataAccess.Domain.Models;
using Task.DataAccess.Abstractions.Repostories;

namespace ModsenTask.DataAccess.Abstractions.Repostories;

public interface IUserRoleRepository : IBaseReadonlyRepository<UserRole>
{
    Task SaveAsync(UserRole model);

    Task RemoveAsync(UserRole model);
}