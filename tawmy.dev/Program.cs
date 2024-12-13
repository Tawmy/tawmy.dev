using Tailwind;
using tawmy.dev.Components;
using tawmy.dev.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<DataService>();
builder.Services.AddRazorComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app.RunTailwind("css:watch");
}
else
{
    app.UseExceptionHandler("/Error", true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

await app.Services.GetRequiredService<DataService>().LoadDataAsync();

app.Run();