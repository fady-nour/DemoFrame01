using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceMapping.Context
{
    internal class CompanyRouteS4:DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server = FADYNOUR\\SQLEXPRESS2022 ;Database = CompanyRouteS4; Trusted_Connection =true;TrustServerCertificate =  true");


        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
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
        #region Table per concrete type [TPCT]  
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }

        #endregion
        #region Table par Hierarchy [TPH]

        //public DbSet<Employee> Employees { get; set; }
        #endregion
        #region TPT
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        #endregion

    }
} 
