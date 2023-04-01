using Microsoft.Extensions.DependencyInjection;

namespace AlasdairCooper.Components.Partial
{

    public static class Extensions
    {
        public static IServiceCollection AddPartials(this IServiceCollection services)
        {
            services.AddHttpClient();
            services.AddRazorPages();
            services.AddControllersWithViews();
            return services.AddTransient<IRazorViewToStringRenderer, RazorViewToStringRenderer>();
        }
    }
}