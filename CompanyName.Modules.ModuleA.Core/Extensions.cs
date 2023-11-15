using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CompanyName.Modules.ModuleA.Api")]
namespace CompanyName.Modules.ModuleA.Core;

internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services) 
    {
        //services.AddSqlServer(null);
        return services;
    }
}