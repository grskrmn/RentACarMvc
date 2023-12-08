using Business.Extensions;
using DataAccess.Extensions;
using MvcUI.Infrastructure.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.ConfigureServiceRegistration();
builder.Services.ConfigureRepositoryRegistration();

builder.Services.ConfigureSession();

// builder.Services.ConfigureIdentity();
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
app.UseSession();

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints => {
    endpoints.MapControllerRoute(
        "default",
        "{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapRazorPages();

});



// app.ConfigureAndCheckMigration();
// app.ConfigureDefaultAdminUserAsync();
app.Run();
