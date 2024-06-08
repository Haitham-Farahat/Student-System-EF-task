using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    enum Contents
    {
        Application,
        Pdf,
        Zip
    }
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public Contents ContentType { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}
