using CasaRM.WebApp.Persistance;
using CasaRM.WebApp.Persistence.Models;
using CasaRM.WebApp.Repositories.Implementations;
using CasaRM.WebApp.Repositories.Interfaces;
using CasaRM.WebApp.Services.Implementations;
using CasaRM.WebApp.Services.Interfaces;
using CasaRM.WebApp.Shared.Models.Catalog;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Application Catalogs
builder.Configuration.AddJsonFile("appCatalogs.json", optional: false, reloadOnChange: false);

ApplicationCatalog applicationCatalog = new();

applicationCatalog.HousingTenureConditions = builder.Configuration.GetSection("HousingTenureConditions").Get<IEnumerable<CatalogDto>>();
applicationCatalog.HousingConstructionMaterialsWalls = builder.Configuration.GetSection("HousingConstructionMaterialsWalls").Get<IEnumerable<CatalogDto>>();
applicationCatalog.HousingConstructionMaterialsFloors = builder.Configuration.GetSection("HousingConstructionMaterialsFloors").Get<IEnumerable<CatalogDto>>();
applicationCatalog.RoomTypes = builder.Configuration.GetSection("RoomTypes").Get<IEnumerable<CatalogDto>>();
applicationCatalog.HousingConservationStatuses = builder.Configuration.GetSection("HousingConservationStatuses").Get<IEnumerable<CatalogDto>>();
applicationCatalog.BasicServices = builder.Configuration.GetSection("BasicServices").Get<IEnumerable<CatalogDto>>();
applicationCatalog.HostDocuments = builder.Configuration.GetSection("HostDocuments").Get<IEnumerable<CatalogDto>>();

// Add services to the container.
// Services
builder.Services.AddScoped<IHostService, HostService>();
builder.Services.AddScoped<ISocialStudyService, SocialStudyService>();
builder.Services.AddScoped<IHostingHistoryService, HostingHistoryService>();
builder.Services.AddScoped<IHostDocumentsService, HostDocumentsService>();

//Repositories
builder.Services.AddScoped<IHostRepository, HostRepository>();
builder.Services.AddScoped<ISocialStudyRepository, SocialStudyRepository>();
builder.Services.AddScoped<IMinorPersonDataRepository, MinorPersonDataRepository>();
builder.Services.AddScoped<ICompanionDataRepository, CompanionDataRepository>();
builder.Services.AddScoped<IFamilyGroupRepository, FamilyGroupRepository>();
builder.Services.AddScoped<IContributionRepository, ContributionRepository>();
builder.Services.AddScoped<IHousingSituationRepository, HousingSituationRepository>();
builder.Services.AddScoped<IHostingHistoryRepository, HostingHistoryRepository>();
builder.Services.AddScoped<IHistoryTicketRepository, HistoryTicketRepository>();

// Singletons
builder.Services.AddSingleton(applicationCatalog);

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
    name: "Hosts",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
