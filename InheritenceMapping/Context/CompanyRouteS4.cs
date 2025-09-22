using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceMapping.Context
{
    internal class CompanyRouteS4 : DbContext
    {
        public CompanyRouteS4() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ✅ اختار connection string المناسبة ليك (حسب بيئة التشغيل)
            //optionsBuilder.UseSqlServer("Server=. ;Database = DigitalCurrency; Integrated Security=SSPI; TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Server=FADYNOUR\\SQLEXPRESS2022; Database=CompanyRouteS4; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH
            // Table per hierarchy [TPH]
            modelBuilder.Entity<FullTimeEmployee>()
                .HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<Employee>();
            modelBuilder.Entity<Employee>().HasDiscriminator<string>("EmployeeType")
                .HasValue<FullTimeEmployee>("FullTime")
                .HasValue<PartTimeEmployee>("PartTime");
            #endregion

            #region TPT
            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
            #endregion
        }

        #region TPCT (Table per concrete type)
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion

        #region TPH (Table per hierarchy)
        //public DbSet<Employee> Employees { get; set; }
        #endregion

        #region TPT
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        #endregion
    }
}

