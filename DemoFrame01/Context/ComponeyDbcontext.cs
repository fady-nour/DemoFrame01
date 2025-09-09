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
           // optionsBuilder.UseSqlServer("Data Source = . ; Initial catalog = CompanyRoute; Integrated Security =true");
            optionsBuilder.UseSqlServer("Server = . ;Database = CompanyRoute; Trusted_Connection =true;TrustServerCertificate =  true");



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
