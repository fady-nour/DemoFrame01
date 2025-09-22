using InheritenceMapping.Context;

namespace InheritenceMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session 5
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
            //var emp = (from e in dbc.Employees
            //           select e).ToList();
            //foreach (var item in emp)
            //{
            //    Console.WriteLine($"Employee: {item.Name}");
            //}

            #endregion
            #endregion
            #region Local
            #region Example 1
            //var res =dbc.Employees.Any(E=>E.Age !=null);
            //Console.WriteLine(res);
            //var res =dbc.Employees.Local.Any(E=>E.Age !=null);
            //Console.WriteLine(res);
            #endregion
            #region Ex2
            //var emp =dbc.Employees.First();
            //if (emp != null)
            //{
            //    Console.WriteLine(emp.Age);
            //}
            //var res = dbc.Employees.Local.First(e => e.Age== null);
            //    Console.WriteLine(res);
            //Console.WriteLine("==============");
            //var ress = dbc.Employees.Local.Any();
            //Console.WriteLine(ress);


            #endregion



            #endregion
            #endregion

        }
    }
}
