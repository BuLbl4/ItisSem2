using Microsoft.EntityFrameworkCore;
using TeamHost.Context;
using TeamHost.Interfaces;
using TeamHost.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IStoreService, StoreService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area=Home}/{controller=Home}/{action=Index}/{id?}");

app.Run();