[![Nuget](https://img.shields.io/nuget/v/AlasdairCooper.Components.Partial?color=eebb00&style=for-the-badge)](https://www.nuget.org/packages/AlasdairCooper.Godot.Configuration)
[![Nuget](https://img.shields.io/nuget/dt/AlasdairCooper.Components.Partial?color=0033ee&style=for-the-badge)](https://www.nuget.org/packages/AlasdairCooper.Godot.Configuration)

# AlasdairCooper.Components.Partial

This is a Blazor component that renders an MVC partial by name with a model parameter. This only works in a Blazor server project.

## Install

This package is available on [Nuget](https://www.nuget.org/packages/AlasdairCooper.Components.Partial).

## Setup

```csharp
using AlasdairCooper.Components.Partial

builder.Services.AddPartials();
```

## Usage

Make sure partials are in a discoverable folder (e.g Views/Shared), then use the component like so: 

```razor
<Partial Name="PartialPath" Model="PartialModel">
```

