using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFrame01.Models
{
    public class Employee
    {
        //mapping by convention
        //by default properity public numeric is primary key 
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        //nullable refrence type
        //nvarchar =>allow null
        public int Age { get; set; }
      
        //valuue type not allow null
        public decimal Salary { get; set; }
        //value type not nullable
        //decimal(18,2)

        //navigational property
        //represent relation of 1
        //Ef core by convention=>department has one employee to manage it
        //[ForeignKey(nameof(DepManager))]
        //public int ManagerDeptId { get; set; }
        //public Department DepManager { get; set; } = null;

        public virtual Department Manager { get; set; }
        //one to one total total
    public Address EmpAddress { get; set; }



    }
}
