using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFrame01.Assignment01
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }

        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        [Range(0,120)]
        public int Age { get; set; }
        public int Dep_id { get; set; }


    }
}
