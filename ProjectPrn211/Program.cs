var builder = WebApplication.CreateBuilder(args);
//add start
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

//add end
var app = builder.Build();

//update start
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Question}/{action=Index}/{id?}"
    );
//cap file ngoai
app.UseStaticFiles();
//update end

app.UseSession(); 
app.Run();
