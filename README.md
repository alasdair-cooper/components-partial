# AlasdairCooper.Components.Partial
This is a Blazor component that renders an MVC partial by name with a model parameter. This only works in a Blazor server project.
Install [the NuGet package](https://www.nuget.org/packages/AlasdairCooper.Components.Partial).
## Setup for .NET 5
```csharp
# Startup.cs

...
using AlasdairCooper.Components.Partial

public void ConfigureServices(IServiceCollection services)
{
    ...
    services.AddPartials();
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    ...
    app.UseEndpoints(endpoints =>
    {
        ...
        endpoints.MapControllers();
    }
}
```
## Setup for .NET 6, 7 and above
```csharp
# Program.cs

...
using AlasdairCooper.Components.Partial
...
builder.Services.AddPartials();
...
app.MapControllers();
```
## Usage
Make sure partials are in a discoverable folder (e.g Views/Shared) and you can just pass the view name as `Partial.Name`. 
```razor
# Component.razor

<Partial Name="PartialPath" Model="PartialModel">
```

