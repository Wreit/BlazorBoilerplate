using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Extensions;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();
builder.Services.AddMudBlazorSnackbar();
builder.Services.AddMudServicesWithExtensions();

builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();