using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoFrame01.Assignment01;
using DemoFrame01.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoFrame01.Context
{
    internal class ComponeyDbcontext : DbContext
    {
        //when you want greate new class
        //you must download  this package => Microsoft.EntityFrameworkCore
        // another way to download console manager 
        public ComponeyDbcontext() : base()
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //conect bitween c# and sql
            //optionsBuilder.UseSqlServer("Data Source = . ; Initial catalog = CompanyRoute; Integrated Security =true");
            optionsBuilder.UseSqlServer("Server = . ;Database = CompanyRoute; Trusted_Connection =true;TrustServerCertificate =  true");



        }
        #region apply floating apis
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Employee>().HasOne(E => E.Manager).WithOne(E => E.ManagedDep)
            //   .HasForeignKey<Department>(E=>E.ManagerId).OnDelete(DeleteBehavior.NoAction) ;
            #region Assignment02
            modelBuilder.Entity<Student>()
       .HasOne<Department>()                    
       .WithMany()                                
       .HasForeignKey(s => s.Id);
            modelBuilder.Entity<Instructor>()
                .HasOne<Department>()
                .WithMany()
                .HasForeignKey(i => i.ID);
            modelBuilder.Entity<Course>()
       .HasOne<Topic>()                           
       .WithMany()                              
       .HasForeignKey(c => c.Top_ID)
       .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Stud_Course>()
       .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Stud_Course>()
                .HasOne<Student>()
                .WithMany()
                .HasForeignKey(sc => sc.stud_ID)
                ;

            modelBuilder.Entity<Stud_Course>()
                .HasOne<Course>()
                .WithMany()
                .HasForeignKey(sc => sc.Course_ID)
               ;

            modelBuilder.Entity<Course_Inst>()
    .HasKey(ci => new { ci.inst_ID, ci.Course_ID });

            modelBuilder.Entity<Course_Inst>()
                .HasOne<Instructor>()
                .WithMany()
                .HasForeignKey(ci => ci.inst_ID)
               ;

            modelBuilder.Entity<Course_Inst>()
                .HasOne<Course>()
                .WithMany()
                .HasForeignKey(ci => ci.Course_ID)
             ;
            #endregion
        }
        #endregion
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> UserTable { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Topic> topics { get; set; }


    }
}
