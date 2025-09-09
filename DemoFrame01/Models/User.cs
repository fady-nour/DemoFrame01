using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFrame01.Models
{
   [Table("Users")]
    public class User
    {
        [Key]
        public int SSN { get; set; }//is primary key with constraint(1,1);
        [Required]
        [Column("UserName" ,TypeName ="varchar(50)")]
        [MaxLength(50,ErrorMessage ="name must be less than 51 character")]
        [MinLength(3,ErrorMessage ="name must greater than 3 chars")]
        [StringLength(maximumLength:50,MinimumLength =3)]
        public string UName { get; set; }
        [Required]
        [Range(20,50)]
        public int Age { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]

        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password {  get; set; }
        [NotMapped]
        public int MyProperty { get; set; }

    }
}
