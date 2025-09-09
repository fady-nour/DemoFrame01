using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFrame01.Assignment01
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public string? Adress { get; set; } 
        public decimal HourRateBouns { get; set; } 
        public int Dept_ID { get; set; }
    }
}
