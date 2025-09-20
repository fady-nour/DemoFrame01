using DemoFrame01.Context;
using DemoFrame01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DemoFrame01.Models;
namespace DemoFrame01.Data
{
    //internal class CompanyDbContextSeed
    //{
    //     static bool Seeedd(ComponeyDbcontext dbcontext)
    //    {
    //        try
    //        {
    //            if (!dbcontext.Employees.Any())
    //            {
    //                var EmpsData = File.ReadAllText("File\\employees.json\"");
    //                var Employees = JsonSerializer.Deserialize<List<Employee>>(EmpsData);
    //                if (Employees.Count > 0)
    //                {
    //                    dbcontext.AddRange(Employees);
    //                    dbcontext.SaveChanges();
    //                }
    //            }
    //            return true;
    //        }
    //        catch (Exception)
    //        {

    //            return false;
    //        }
    //    }
    //}
}
