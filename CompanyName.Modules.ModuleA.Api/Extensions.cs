using CompanyName.Modules.ModuleA.Core;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Bootstrapper")]
namespace CompanyName.Modules.ModuleA.Api;

internal static class Extensions
{
    public static IServiceCollection AddModuleA(this IServiceCollection services)
    {
        services.AddCore();
        return services;
    }
}