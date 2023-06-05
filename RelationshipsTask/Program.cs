using RelationshipsTask.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RelationsDbContext>(opt =>
{
    opt.UseSqlServer("Server=MANUELA\\MSSQLSERVER01\\SQLEXPRESS;Database=RelationshipsTask;Integrated Security=true");
});
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles();
app.Run();