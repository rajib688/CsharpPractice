﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public double Fees { get; set; }
        public List<Topic> Topics { get; set; }
        public List<CourseEnrollment> CourseRegitrations { get; set; }
    }
}
