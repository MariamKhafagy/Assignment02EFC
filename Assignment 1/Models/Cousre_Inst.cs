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
    [Table("Course_Inst")]
    internal class Course_Inst
    {
        [ForeignKey(nameof(Instructor))]
        public int ins_ID { get; set; }
        public Instructor Instructor { get; set; }
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public Course Course { get; set; }
        public string Evaluate { get; set; }
    }
}
