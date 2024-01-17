using MudBlazor.Extensions;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

builder
    .Services
    .AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddMudServices();
builder.Services.AddMudBlazorSnackbar();
builder.Services.AddMudServicesWithExtensions();

#if DEBUG
builder.Services.AddSassCompiler();
#endif

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App.Components.App>()
    .AddAdditionalAssemblies(typeof(Program).Assembly)
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode();

app.Run();
