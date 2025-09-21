using InheritenceMapping.Context;
using Microsoft.EntityFrameworkCore;

namespace InheritenceMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyRouteS4 dbc = new CompanyRouteS4();
            #region Inheritence mapping
            #region Table per concrete type [TPCT]
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Address = "Cairo",
            //    Salary = 5000,
            //    StartDate = DateTime.Now
            //};
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "Mohamed",
            //    Age = 25,
            //    Address = "Giza",
            //    HourRate = 50,
            //    CountOfHours = 160
            //};
            //dbc.Add(fullTimeEmployee);
            //dbc.Add(partTimeEmployee);
            //dbc.SaveChanges();

            //var ee=(from e in dbc.FullTimeEmployees
            //        select e).ToList();
            //var eee = (from e in dbc.PartTimeEmployees
            //           select e).ToList();
            //Console.WriteLine(ee.Count);
            //Console.WriteLine(eee.Count);
            #endregion
            #region Table per Hierarchy [TPH]

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Address = "Cairo",
            //    Salary = 5000,
            //    StartDate = DateTime.Now
            //};
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "Mohamed",
            //    Age = 25,
            //    Address = "Giza",
            //    HourRate = 50,
            //    CountOfHours = 160
            //};
            //dbc.Add(fullTimeEmployee);
            //dbc.Add(partTimeEmployee);
            //dbc.SaveChanges();
            //var emp = (from e in dbc.Employees
            //           select e).ToList();
            //foreach (var item in emp)
            //{
            //    if (item is FullTimeEmployee)
            //    {
            //        Console.WriteLine($"FullTimeEmployee: {item.Name}");
            //    }
            //    else if (item is PartTimeEmployee)
            //    {
            //        Console.WriteLine($"PartTimeEmployee: {item.Name}");
            //    }
            //}
            #endregion
            #region TPT

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Address = "Cairo",
            //    Salary = 5000,
            //    StartDate = DateTime.Now
            //};
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "Mohamed",
            //    Age = 25,
            //    Address = "Giza",
            //    HourRate = 50,
            //    CountOfHours = 160
            //};
            //dbc.Add(fullTimeEmployee);
            //dbc.Add(partTimeEmployee);
            //dbc.SaveChanges();
            var emp = (from e in dbc.Employees
                       select e).ToList();
            foreach (var item in emp)
            {
                Console.WriteLine($"Employee: {item.Name}");    
            }

            #endregion
                #endregion


        }
    }
}
