﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Student> Students { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Homework> Homeworks { get; set; }

    }
}
