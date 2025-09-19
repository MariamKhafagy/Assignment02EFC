using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    //Fluent API
    internal class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(topic))]
        public int Top_ID { get; set; }
        public Topic topic { get; set; }
    }
}
