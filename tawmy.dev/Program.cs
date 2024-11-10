using tawmy.dev.Components;
using tawmy.dev.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

if (builder.Environment.IsDevelopment() && builder.Configuration["DOTNET_RUNNING_IN_CONTAINER"] != "true")
{
    // if environment is dev and not running in container, add tailwind service for hot reload
    builder.Services.AddHostedService<TailwindService>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();