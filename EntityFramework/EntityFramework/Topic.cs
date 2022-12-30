﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Topic
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}