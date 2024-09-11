using Company.G03.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.G03.DAL.Date.Contexts
{
   public class AppDbContext : DbContext
    {




        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = .; Database = CompanyMVCG03; Trusted_Connection = True; TrustServerCertificate = True");

        //}

        
        //عشان اعمل ماب للكلاس عشان يتحول ل table في الداتا بيز


        public DbSet<Department> Department { get; set; }














    }
}
