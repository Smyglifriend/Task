using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace TestTask.Service.Contact.Abstractions.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddContactServicesMapper(this IServiceCollection services)
        => services.AddAutoMapper(Assembly.GetExecutingAssembly());
}