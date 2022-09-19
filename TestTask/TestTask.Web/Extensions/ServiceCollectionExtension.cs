using System.Reflection;

namespace TestTask.Web.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddWebMapper(this IServiceCollection services)
        => services.AddAutoMapper(Assembly.GetExecutingAssembly());
}