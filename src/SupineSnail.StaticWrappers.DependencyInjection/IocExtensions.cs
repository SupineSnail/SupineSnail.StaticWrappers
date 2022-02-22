using SupineSnail.DependencyInjection;

namespace SupineSnail.StaticWrappers.DependencyInjection;

public static class IocExtensions
{
    /// <summary>
    /// Adds static wrappers for dalamud services to the DI stack
    /// </summary>
    /// <param name="services">The service collection</param>
    /// <returns>The service collection for chaining</returns>
    public static IServiceCollection AddDalamudStaticWrappers(this IServiceCollection services)
    {
        services.AddSingleton<IPluginLog, PluginLogWrapper>();
        return services;
    }
}