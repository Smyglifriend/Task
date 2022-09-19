using TestTask.DataAccess;
using TestTask.DataAccess.Extensions;
using TestTask.Web.Core.Extensions;
using TestTask.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddDatabase(builder.Configuration)
    .AddMapper()
    .AddWebMapper()
    .AddUnitOfWork<TestTaskDbContext>()
    .AddServices()
    .AddControllersWithViews();

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Contact}/{action=DisplayAllContacts}/{id?}");
});

app.Run();