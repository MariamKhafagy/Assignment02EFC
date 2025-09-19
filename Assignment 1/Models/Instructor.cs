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
    [Table("Instructor")]
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public decimal Bouns { get; set; }

        [Column(TypeName = "money")]
        public decimal Salary { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        public decimal HourRate { get; set; }

        //1:M instructor with department "Belong"
        //1:1 instructor with department "Manege"
        [ForeignKey(nameof(LearnInDepartment))]
        public int Dept_ID { get; set; }
        public Department LearnInDepartment { get; set; }
    }
}
