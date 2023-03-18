namespace AlasdairCooper.Components.Partial;

public static class Extensions
{
    public static IServiceCollection AddPartials(this IServiceCollection services)
    {
        services.AddRazorPages().AddRazorRuntimeCompilation();
        services.AddHttpClient();
        return services.AddHttpContextAccessor();
    }
}
