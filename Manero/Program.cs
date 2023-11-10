using manero.Data;
using Manero.Data;
using Manero.Repositories;
using Manero.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Determine the appropriate connection string based on the environment
string? connectionString = builder.Environment.IsDevelopment()
    ? builder.Configuration.GetConnectionString("DevelopmentConnection")
    : builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddDbContext<ProductDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DataSql")));


builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

//Im adding a product service for injection option - Jeppe 3/11
builder.Services.AddSingleton<ProductService>();
builder.Services.AddScoped<ProductsService>();

//Adding Service and Repositories for retrieving user promo codes - Christian 9/11
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<PromoCodeRepo>();
builder.Services.AddScoped<UserPromoCodeRepo>();


builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();



var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    // Initialize roles
//    if (!await roleManager.RoleExistsAsync("Admin"))
//    {
//        await roleManager.CreateAsync(new IdentityRole("Admin"));
//    }

//    // Initialize first admin user
//    if (!userManager.Users.Any())
//    {
//        var adminUser = new IdentityUser { UserName = "admin@example.com", Email = "admin@example.com" };
//        var adminUserResult = await userManager.CreateAsync(adminUser, "Admin@123");

//        if (adminUserResult.Succeeded)
//        {
//            await userManager.AddToRoleAsync(adminUser, "Admin");
//        }

//        var userHans = new IdentityUser {
//            Id = "a106762b-162f-4e96-9c50-8f6b80298fd1",
//            UserName = "hans@maneromail.com", 
//            Email = "hans@maneromail.com" 
//        };
//        var userHansResult = await userManager.CreateAsync(adminUser, "Bytmig123!");

//        if (adminUserResult.Succeeded)
//        {
//            await userManager.AddToRoleAsync(adminUser, "User");
//        }
//    }
//
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
{
	app.UseExceptionHandler("/Home/Error");
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
	pattern: "{controller=Welcome}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

public partial class Program { }