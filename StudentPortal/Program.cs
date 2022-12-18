using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentPortal.Database.Databases;
using StudentPortal.Repositories.Abstructions;
using StudentPortal.Service.Abstructions;
using StudentPortal.Repository;
using StudentPortalServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Dependency Resolve Area.............
builder.Services.AddDbContext<StudentPortalDBcontext>(x => x
.UseSqlServer(builder.Configuration.GetConnectionString("con")));
    

builder.Services.AddTransient <IStudentRepository, StudentRepo>();

builder.Services.AddTransient <IStudentService, StudentService>();

builder.Services.AddTransient<ICourseRepository, CourseRepository>();

builder.Services.AddTransient<ICourseService, CourseServices>();

builder.Services.AddTransient<IDepartmentRepository, DepartmentRepositoy>();

builder.Services.AddTransient<IDepartmentService, DepartmentServicen>();

//End of Dependency Resolve//

builder.Services.AddAutoMapper(typeof(Program));


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
