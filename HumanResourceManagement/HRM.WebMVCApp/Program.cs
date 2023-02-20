using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Contract.Service;
using HRM.Infrastructure.Data;
using HRM.Infrastructure.Repository;
using HRM.Infrastructure.Service;
using Microsoft.EntityFrameworkCore; //UseSqlServer() is in this framework


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//to read the connection string
builder.Services.AddDbContext<HRMDbContext>(option =>
{
    //pass the connection string here, HrmDb is the name of the connection string
    //here we are injecting Dbcontext file, it's dependency injection.
    option.UseSqlServer(builder.Configuration.GetConnectionString("HrmDb"));
});


//dependency injection for repositories
//whever you create a repository, you can use it only if you're using dependency injection
//how to use it:
builder.Services.AddScoped<ICandidateRepositoryAsync, CandidateRepositoryAsync>();
//whenver you want to use the type of ICandidateRepositoryAsync, it will automatically inject an object of CandidateRepositoryAsync





//dependency injection for services
builder.Services.AddScoped<ICandidateServiceAsync, CandidateServiceAsync>();
//inject dependency






var app = builder.Build();

// Configure the HTTP request pipeline.(if you want to add any middelware)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
