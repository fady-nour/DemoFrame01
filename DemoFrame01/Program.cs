using DemoFrame01.Assignment01;
using DemoFrame01.Context;
using DemoFrame01.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoFrame01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ComponeyDbcontext dbcontext = new ComponeyDbcontext(); // open connection

            #region Session 1
            #region Demo
            #region Entitty frame work core
            /*
             ORM => object Rational mapper 
            support linq
            support multible DB 
            cross platform
            support migrations
            auto tracker
            disadvantges
            perfomance low (auto tracker)
            complexity 
             */
            #endregion

            #region Ado.net
            /*
             low level framee
            no migration 
            no tacking
            manual connection 
            direct acess with database
            disadvantdes
             */
            #endregion

            #region Dapper
            /*
             * lightweight
             * simple api 
             * faster
             * easy to use
             no tracking and migrations
             micro orm
             limited features
            */
            #endregion
            #endregion
            #endregion

            #region Session 2
            #region Demo
            #region Relation between classes
            /* you can make relation between two tables in three ways
             * 1. navigation
             * 2. fluent apis
             * 3. by convention
             */
            #endregion

            #region Query object model

            #region Add new record
            //Employee emp01 = new Employee()
            //{
            //    Name = "Fady",
            //    Salary = 10000,
            //    Age = 23
            //};
            //dbcontext.Employees.Add(emp01);
            //dbcontext.SaveChanges();
            #endregion

            #region Get data from table
            //var emp01 = dbcontext.Employees.Where(P => P.Id == 1).FirstOrDefault();
            //Console.WriteLine(emp01?.Id);
            #endregion

            #region Update data in table
            //var emp01 = dbcontext.Employees.Where(P => P.Id == 1).FirstOrDefault();
            //if (emp01 != null) 
            //{
            //    emp01.Name = "ALI";
            //    dbcontext.SaveChanges();
            //}
            #endregion

            #region Delete data in table
            //var emp01 = dbcontext.Employees.Where(P => P.Id == 1).FirstOrDefault();
            //if (emp01 != null) 
            //{
            //    dbcontext.Employees.Remove(emp01);
            //    dbcontext.SaveChanges();
            //}
            #endregion

            #endregion
            #endregion
            #endregion

            #region Session 3
            #region Eager Loading
            var students = dbcontext.students
                 .Include(s => s.Departments)
                 .ThenInclude(d => d.Instructors)
                 .ToList();

            var student = dbcontext.students.FirstOrDefault();
            Console.WriteLine(student?.Departments?.Name);
            #endregion
            #endregion

            #region Session 4
            #region Lazy loading 
            /*
             enable lazy loading
            1- install package Microsoft.EntityFrameworkCore.Proxies
            2- enable lazy loading in OnConfiguring in DbContext
            3- make navigation properties virtual
             */

            //var emp = dbcontext.Employees.FirstOrDefault(e => e.Id == 5);
            //if (emp != null) 
            //{
            //    Console.WriteLine($"emp name {emp.Name}");
            //    Console.WriteLine($"emp dep name {emp.Manager.DepName}");
            //}
            #endregion

            #region Joins
            // Example of Inner Join
            var res = from d in dbcontext.departments
                      join e in dbcontext.Employees
                      on d.ID equals e.Id
                      select new
                      {
                          EmpId = e.Id,
                          EmpName = e.Name,
                          DeptId = d.ID,
                          DeptName = d.Name
                      };
            #endregion
            #endregion
        }
    }
}

