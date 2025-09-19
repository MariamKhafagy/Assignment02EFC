using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    //Data Annotations
    [Table("Department")]
    internal class Department
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        //1:1 instructor with department "Manege"

        [ForeignKey(nameof(manager))]
        public int Ins_ID { get; set; }
        public Instructor manager { get; set; }

        [Column(TypeName = "date")]
        public DateTime HiringDate { get; set; }

        //1:M Student with department
        public ICollection<Student> Students { get; set; }= new HashSet<Student>();

        //1:M instructor with department "Belong"
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        
    }
}
