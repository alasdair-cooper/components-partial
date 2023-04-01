using Microsoft.Extensions.DependencyInjection;

namespace AlasdairCooper.Components.Partial
{

    public static class Extensions
    {
        public static IServiceCollection AddPartials(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddRazorTemplating();

            return services;
        }
    }
}