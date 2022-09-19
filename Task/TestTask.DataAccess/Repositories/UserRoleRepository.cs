﻿namespace Task.DataAccess.Repositories;

internal class UserRoleRepository 
    : BaseReadonlyRepository<UserRole>,
    IUserRoleRepository
{
    public UserRoleRepository(ModsenTaskDbContext dbContext)
        : base(dbContext)
    {
    }


    public async Task SaveAsync(UserRole model)
    {
        await _dbSet.AddAsync(model);
    }
    
    public virtual async Task RemoveAsync(UserRole model)
    {
        _dbContext.Remove(model);
        await _dbContext.SaveChangesAsync();
    }
}