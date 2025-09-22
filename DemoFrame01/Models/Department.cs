using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFrame01.Models
{
    [PrimaryKey(nameof(DepId))]
    public class Department
    {
        [Key]
        public int DepId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string DepName { get; set; }

        //public Employee Manager { get; set; } = null;
        [ForeignKey(nameof(ManagedDep))]
        public int ManagerId { get; set; }
        public virtual Employee ManagedDep { get; set; }
        public virtual ICollection<Employee> Employees { get; set;  } = new HashSet<Employee>();
    }
}
