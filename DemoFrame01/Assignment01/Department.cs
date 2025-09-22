using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoFrame01.Assignment01
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }

        public int Ins_ID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime HiringDate { get; set; }

        // Relations
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}
