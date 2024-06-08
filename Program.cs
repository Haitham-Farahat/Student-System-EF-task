using P01_StudentSystem.Data;
using P01_StudentSystem.Models;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();

            Course course1 = new Course() { Name = "ASP.Net", Description = "" };
            Course course2 = new Course() { Name = "Laravel", Description = "" };

            context.Courses.Add(course1);
            context.Courses.Add(course2);
            context.SaveChanges();

            context.Resources.Add(new Resource() { Name = "learn/microsoft.com", ResourceType = Resources.Document, CourseId = 1 });
            context.SaveChanges();
            var result = context.Resources.ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ResourceType);
            }
        }
    }
}
