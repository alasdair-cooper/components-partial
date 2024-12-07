using Microsoft.Extensions.DependencyInjection;

namespace AlasdairCooper.Components.Partial;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPartials(this IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddRazorTemplating();

        return services;
    }
}