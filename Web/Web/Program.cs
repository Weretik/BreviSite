using Microsoft.AspNetCore.Identity;
using Web.Components;
using Application;
using FluentValidation;
using MediatR;
using AutoMapper;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Repositiries;
using MudBlazor.Services;
using Web.Mappings;
using Web.ViewModels;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMudServices();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddMaps(typeof(ApplicationAssemblyMarker).Assembly);
    cfg.AddMaps(typeof(WalletViewModelProfile).Assembly);
});

builder.Services.AddMediatR(cfg => 
    cfg.RegisterServicesFromAssembly(typeof(ApplicationAssemblyMarker).Assembly
));

builder.Services.AddValidatorsFromAssembly(typeof(ApplicationAssemblyMarker).Assembly);

builder.Services.AddScoped<IWalletRepository, WalletRepository>();

string connection = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<BreviDBContext>(options =>
    options.UseNpgsql(connection));

builder.Services
    .AddIdentity<AppUser, IdentityRole<int>>(options =>
    {
        options.User.RequireUniqueEmail = true;
        options.Password.RequiredLength = 6;
        options.Password.RequireDigit = false;
        options.Password.RequireNonAlphanumeric = false;
    })
.AddEntityFrameworkStores<BreviDBContext>()
.AddDefaultTokenProviders();

builder.Services.AddScoped<IWalletRepository, WalletRepository>();

var app = builder.Build();

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddUserSecrets<Program>()
    .AddEnvironmentVariables();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Web.Client._Imports).Assembly);

app.Run();
