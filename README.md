![Nuget](https://img.shields.io/nuget/v/AlasdairCooper.Components.Partial?color=eebb00&style=for-the-badge) ![Nuget](https://img.shields.io/nuget/dt/AlasdairCooper.Components.Partial?color=0033ee&style=for-the-badge)
# AlasdairCooper.Components.Partial
This is a Blazor component that renders an MVC partial by name with a model parameter. This only works in a Blazor server project.
Install [the NuGet package](https://www.nuget.org/packages/AlasdairCooper.Components.Partial).
## Setup
```csharp
# Program.cs

...
using AlasdairCooper.Components.Partial
...
builder.Services.AddPartials();
```
## Usage
Make sure partials are in a discoverable folder (e.g Views/Shared) and you can just pass the view name as `Partial.Name`. 
```razor
# Component.razor

<Partial Name="PartialPath" Model="PartialModel">
```

