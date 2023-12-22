using CreateMineServices.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITimeService, TimeLong>();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");

app.Run();