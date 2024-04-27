# FeatureManagementExperiment
Experimenting to learn ways of using Microsoft's FeatureManagement-Dotnet

## .NET version
This project was started as a .NET 7 app. On 4/27/2024 I upgraded it to .NET 8.

## Additional notes
In this app the feature flags are stored in the appSettings.json file. This is not a good practice for production. Instead, use Azure App Configuration.

## FeatureManagement References
[Tutorial: Use feature flags in an ASP.NET Core app](https://learn.microsoft.com/en-us/azure/azure-app-configuration/use-feature-flags-dotnet-core?tabs=core6x) was especially useful.

[Quickstart: Add feature flags to an ASP.NET Core app](https://learn.microsoft.com/en-us/azure/azure-app-configuration/quickstart-feature-flag-aspnet-core?tabs=core6x) is also useful.