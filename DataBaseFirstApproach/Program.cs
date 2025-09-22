

using DataBaseFirstApproach.Context;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace DataBaseFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session 5
            #region DataBase First with commands

            /*
             1-download package
            EntityFrameworkCore.SqlServer
            EntityFrameworkCore.Tools
            EntityFrameworkCore.Proxies
            use database = scaqfuled
                using MyDatabaseDbContext db = new MyDatabaseDbContext();
            var res = db.Employees.ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item.Age);
            }
             */


            #endregion
            #region DataBase first With Ef CorePower Tool
            /*
             * Extention =>download =>visuial studio
             * 
             * **/
            //using MyDatabaseContext db = new MyDatabaseContext();
            //var res = db.Employees.ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Name);
            //}


            #endregion
            #region Run SQL Queries via Application 
            using MyDatabaseContext db = new MyDatabaseContext();
            #region Select 
            //int EID = 2;
            //var res = db.Employees.FromSqlRaw("select * from Employee where id = {0}" , EID).ToList();
            //res = db.Employees.FromSqlInterpolated($"select * from Employee where id = {EID}").ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region Update ,delete
            //var res = db.Database.ExecuteSqlRaw("update Employee set Salary = 5000 where id = 1");
            //foreach (var item in db.Employees)
            //{
            //    Console.WriteLine(item.Name + " " + item.Salary);
            //}

            //var res = db.Database.ExecuteSqlRaw("delete from Employee where id = 5");
            #endregion

            #region Views
            //var res = db.EmployeeDepartments.ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}
            #endregion

            #region stored proc

            //{
            //    var employees = db.Employees
            //        .FromSqlRaw("EXEC GetEmployees")
            //        .ToList();

            //    foreach (var emp in employees)
            //    {
            //        Console.WriteLine($"{emp.Id} - {emp.Name}");
            //    }
            //}

            #endregion
            #endregion
            #endregion
        }
    }
}
