﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    //Convention
    internal class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public ICollection<Course> Courses { get; set; }= new HashSet<Course>();
    }
}
