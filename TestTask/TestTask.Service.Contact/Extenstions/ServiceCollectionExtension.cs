using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using TestTask.Service.Contact.Abstractions.Interfaces;
using TestTask.Service.Contact.Implementation;

namespace TestTask.Service.Contact.Extenstions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddContactService(this IServiceCollection services)
        => services
            .AddScoped<IContactService, ContactService>();
}