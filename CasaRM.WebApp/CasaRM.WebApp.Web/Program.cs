using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Implementations;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Services.Implementations;
using CasaRM.WebApp.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Services
builder.Services.AddScoped<IHostService, HostService>();

//Repositories
builder.Services.AddScoped<IHostRepository, HostRepository>();
builder.Services.AddScoped<ISocialStudyRepository, SocialStudyRepository>();

// Database configuration
var dbConnectionString = builder.Configuration.GetConnectionString("DbConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(dbConnectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Identity configuration
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.Lockout.AllowedForNewUsers = false;
})
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

// Application build
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseStatusCodePages();
    app.UseExceptionHandler("/Home/Error");
    app.UseStatusCodePagesWithRedirects("/Home/Error/{0}");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
