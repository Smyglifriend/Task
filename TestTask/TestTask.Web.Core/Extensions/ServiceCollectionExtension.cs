using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestTask.DataAccess.Extensions;
using TestTask.Service.Contact.Abstractions.Extensions;
using TestTask.Service.Contact.Extenstions;

namespace TestTask.Web.Core.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddMapper(this IServiceCollection services)
        => services
            .AddContactServicesMapper();

    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration config)
        => services
            .AddContext(config);

    public static IServiceCollection AddServices(this IServiceCollection services)
        => services.AddContactService();
}