using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFrame01.Assignment01
{
    public class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}
