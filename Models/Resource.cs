using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    enum Resources
    {
        Video,
        Presentation,
        Document,
        Other
    }

    internal class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public Resources ResourceType { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
