using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestTask.DataAccess.Abstractions.Repostories;
using TestTask.DataAccess.Repositories;

namespace TestTask.DataAccess.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration)
        => services.AddDbContext<TestTaskDbContext>(options
            => options.UseSqlServer(configuration.GetConnectionString("TestTask")));

    public static IServiceCollection AddUnitOfWork<TContext>(this IServiceCollection services)
        where TContext : DbContext
        => services
            .AddScoped<IUnitOfWork, UnitOfWork<TContext>>();
}