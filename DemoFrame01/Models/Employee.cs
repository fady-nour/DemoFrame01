using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFrame01.Models
{
    public class Employee
    {
        //mapping by convention
        //by default properity public numeric is primary key 

        public int Id { get; set; }
        public string? Name { get; set; }
        //nullable refrence type
        //nvarchar =>allow null
        public int Age { get; set; }
      
        //valuue type not allow null
        public decimal Salary { get; set; }
        //value type not nullable
        //decimal(18,2)



    }
}
