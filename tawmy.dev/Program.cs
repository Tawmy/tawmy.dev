using Tailwind;
using tawmy.dev.Components;
using tawmy.dev.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<DataService>();
builder.Services.AddRazorComponents();

builder.UseTailwindCli();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

await app.Services.GetRequiredService<DataService>().LoadDataAsync();

var version = typeof(Program).Assembly.GetName().Version!;
app.Logger.LogInformation("tawmy.dev, version {version}", version.ToString(3));

app.Run();