using Company.G03.BLL.Reposters;
using Company.G03.DAL.Date.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Company.G03PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();



            builder.Services.AddScoped<AppDbContext>();//allow di for AppDbContext

            builder.Services.AddDbContext<AppDbContext>(); //allow DI for AppDbContext

            builder.Services.AddScoped<DepartmentRepostery>();//  allow DI forDepartmentRepostery

            var app = builder.Build();

            //Â  ÕÊ· ·«ﬂÊ«œ «··Ì Â—›⁄Â« ⁄ «·”Ì—›— IL
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server = .; Database = CompanyMVCG03; Trusted_Connection = True; TrustServerCertificate = True");
            }); //Allow DI For AppDbContext



            builder.Services.AddDbContext<AppDbContext>(options =>
            {


                ConfigurationManager configuration = builder.Configuration;
                //options.UseSqlServer(configuration);
            });
            // builder.Services.AddScoped<DepartmentRepository>(); // Allow DI For DepartmentRepository


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
        }
    }
}
