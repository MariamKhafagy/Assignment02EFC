using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    //Convention
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //1:M Student with department
        [ForeignKey(nameof(AssignInDepartment))]
        public int Dep_Id { get; set; }
        public Department AssignInDepartment { get; set; }
    }
}
