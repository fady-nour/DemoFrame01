using DemoFrame01.Context;
using DemoFrame01.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoFrame01
{

 internal class program   {
        static void Main(string[] args)
        {
            #region Session 1
            #region demo


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
             * lightwight
             * simple api 
             * faster
             * easy to use
             no tracking and migrations
          micro orm
            limited features
            */
            #endregion
            #region Dbcontext
            //ComponeyDbcontext componeyDbcontext = new ComponeyDbcontext();
            //try
            //{

            //}
            //finally
            //{
            //    componeyDbcontext.Dispose();
            //}

            //using ComponeyDbcontext dbcontext = new ComponeyDbcontext();
            //dbcontext.Database.Migrate();
            //to apply migeatin must doenload package entity framework
            #endregion
            #endregion

            using ComponeyDbcontext dbcontext = new ComponeyDbcontext();
            #endregion
            #region Session 2
            #region Demo
            #region Relation between classes
            /* you can make relation between tow table in three way
             * 1.navigation
             * 2.fluent apis
             * 3.by convention
             * 
             * 
             * */
            #endregion

            #region Query object model
            using ComponeyDbcontext dp = new ComponeyDbcontext();//openconnection
            #region Add new record
            //to add data in database
            //connect with database

            //Employee emp01 = new Employee()
            //{
            //    Name = "Fady",
            //    Salary = 10000,
            //    Age = 23
            //};
            ////by default auto track
            //dp.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //Console.WriteLine(dp.Entry<Employee>(emp01).State);
            //dp.Add(emp01);
            //dp.Set<Employee>().Add(emp01);
            //dp.Employees.Add(emp01);
            //Console.WriteLine(dp.Entry<Employee>(emp01).State);
            //dp.SaveChanges();

            #endregion

            #region get data from table
            //    var emp01 = dp.Employees.Where(P => P.Id == 1).FirstOrDefault();
            //Console.WriteLine(emp01.Id);

            #endregion

            #region update data in table
            //var emp01 = dp.Employees.Where(P => P.Id == 1).FirstOrDefault();
            //if (emp01 != null) 
            //{
            //    emp01.Name = "ALI";
            //    Console.WriteLine(dp.Entry<Employee>(emp01).State);
            //    dp.SaveChanges();
            //}


            #endregion
            #region delete data in table
            //var emp01 = dp.Employees.Where(P => P.Id == 1).FirstOrDefault();
            //if (emp01 != null) 
            //{
            //dp.Employees.Remove(emp01);
            //    dp.Remove(emp01);
            //    Console.WriteLine(dp.Entry<Employee>(emp01).State);
            //    dp.SaveChanges();
            //}




            #endregion

            #endregion

            #region one to one total to total


            #endregion
            #endregion
            #endregion

            #region Session 4
            #region Demo
            #region Lazy loading 
            /*
             enable lazy loading
            1-install packahe microsoft.frameworkcore.proxies
            2-enable lazy loading in onconfiguring in class dpcontext
            3-make navigation properity virtual
             
             */

            //var emp =dp.Employees.FirstOrDefault(e=>e.Id==5);
            //if(emp != null) 
            //{
            //    Console.WriteLine($"emp name {emp.Name}");
            //    Console.WriteLine($"emp dep name {emp.Manager.DepName}");
            //}
            #endregion
            #region joincatagory
            /*
             * inner join
             * select e.id ,e.name ,d.depid,d.deptname 
             * from Employee e ,Department D 
             * Where D.DeptId == E.Departmentid
             * */


            //var result = dbcontext.departments.Join(dbcontext.Employees,
            //    d => d.DepId,
            //    e => e.Id,
            //    (d, e) => new
            //    {
            //        EmpId = e.Id,
            //        EmpName = e.Name,
            //        DeptId = d.DepId,
            //        DeptName = d.DepName
            //    }).ToList();

            var res = from d in dbcontext.departments
                      join e in dbcontext.Employees
                      on d.DepId equals e.Id
                      select new
                      {
                          EmpId = e.Id,
                          EmpName = e.Name,
                          DeptId = d.DepId,
                          DeptName = d.DepName
                      };
            #region Get manager id
            //var result = dbcontext.Employees.Join(dbcontext.departments,
            //    e => e.Id,
            //    d => d.ManagerId,
            //    (e, d) => new
            //    {
            //        EmpId = e.Id,
            //        EmpName = e.Name,
            //        DeptId = d.DepId,
            //        DeptName = d.DepName
            //    }).ToList();
            #endregion
            #endregion
            #region Groupe join

            //var result = dbcontext.departments.GroupJoin(dbcontext.Employees,
            //    d => d.DepId,
            //    e => e.Id,
            //    (d, emps) => new
            //    {
            //        DeptId = d.DepId,
            //        DeptName = d.DepName,
            //        Emps = emps
            //    }).ToList();
            //var ress = from d in dbcontext.departments
            //          join e in dbcontext.Employees
            //          on d.DepId equals e.Id into emps
            //          select new
            //          {
            //              DeptId = d.DepId,
            //              DeptName = d.DepName,
            //              Emps = emps
            //          };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Dept id {item.DeptId} Dept name {item.DeptName}");
            //    foreach (var emp in item.Emps)
            //    {
            //        Console.WriteLine($"Emp id {emp.Id} Emp name {emp.Name}");
            //    }
            //}
            #endregion
            #region Leftouterjoin
            /*LEFT OUTER JOIN
                   Yes
               Use GroupJoin + DefaultIfEmpty().
              Returns all rows from the primary table even
              if no match exists in the secondary table
            */
            #endregion
            #region rightouterjoin
            /*RIGHT OUTER JOIN
                   Indirect
           EF Core does not support Right Join directly.
            Simulate by swapping table order in a left join
            .*/
            #endregion


            #endregion
            #endregion
        }
    }
}
