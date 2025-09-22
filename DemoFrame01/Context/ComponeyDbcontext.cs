using DemoFrame01.Assignment01;
using DemoFrame01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Student = DemoFrame01.Assignment01.Student;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
           .HasOne(s => s.Departments)
           .WithMany(d => d.Students)
           .HasForeignKey(s => s.Dep_id);

            modelBuilder.Entity<Instructor>()
                .HasOne<Department>(i => i.Departments)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Stud_Course>()
    .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

modelBuilder.Entity<Stud_Course>()
    .HasKey(sc => new { sc.stud_ID, sc.Course_ID });
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

           

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Stud_Courses)
                .HasForeignKey(sc => sc.Course_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.Course_Insts)
                .HasForeignKey(ci => ci.inst_ID);

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.Course_Instss)
                .HasForeignKey(ci => ci.Course_ID);

            #region Seeding migrate
            modelBuilder.Entity<Department>().HasData(
            new Department { ID = 1, Name = "CS", Ins_ID = 1, HiringDate = DateTime.Now },
            new Department { ID = 2, Name = "IS", Ins_ID = 2, HiringDate = DateTime.Now }
               );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FName = "Ali", LName = "Hassan", Age = 20, Dep_id = 1 },
                new Student { Id = 2, FName = "Mona", LName = "Adel", Age = 22, Dep_id = 2 }
            );

            #endregion


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //conect bitween c# and sql
            //optionsBuilder.UseSqlServer("Data Source = . ; Initial catalog = CompanyRoute; Integrated Security =true");
            optionsBuilder.UseSqlServer("Server = . ;Database = CompanyRoute; Trusted_Connection =true;TrustServerCertificate =  true")
                .UseLazyLoadingProxies();



        }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<User> UserTable { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Topic> topics { get; set; }


    }
}
