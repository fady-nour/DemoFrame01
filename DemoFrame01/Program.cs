using DemoFrame01.Context;
using Microsoft.EntityFrameworkCore;

namespace DemoFrame01
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //using ComponeyDbcontext dbcontext = new ComponeyDbcontext();
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


        }
    }
}
