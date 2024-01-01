using ManagingModelBinding.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<User>();

var app = builder.Build();

app.MapControllerRoute("default","{controller=Home}/{action=Index}");

app.Run();
