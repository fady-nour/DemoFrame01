using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFrame01.Assignment01
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public string? Adress { get; set; } 
        public decimal HourRateBouns { get; set; } 
        public int Dept_ID { get; set; }
        public Department? Departments { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; } = new List<Course_Inst>();
    }
}
