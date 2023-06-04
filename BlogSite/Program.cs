using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlogSite.Data;
using BlogSite.Areas.Identity.Data;
using BlogSite.Services.PostService;
using BlogSite.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IPostRepository, PostRepository>();
var connectionString = builder.Configuration.GetConnectionString("BlogSiteContextConnection") ?? throw new InvalidOperationException("Connection string 'BlogSiteContextConnection' not found.");
builder.Services.AddDbContext<BlogSiteDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<BlogSiteContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<BlogSiteContext>();

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();
app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();
