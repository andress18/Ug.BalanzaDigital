using Microsoft.EntityFrameworkCore;
using Ug.BalanzaDigital.Data;
using Ug.BalanzaDigital.Data.DbContexts;
using Ug.BalanzaDigital.Gestor.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<BalanzaDigitalContext>(options => { options.UseInMemoryDatabase("TestDb"); });


builder.Services.AddScoped(typeof(Repository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();