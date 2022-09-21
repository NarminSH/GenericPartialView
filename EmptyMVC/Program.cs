using EmptyMVC.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PhoneDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("default"));
});
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Computer}/{action=Index}/{id?}");

app.Run();

