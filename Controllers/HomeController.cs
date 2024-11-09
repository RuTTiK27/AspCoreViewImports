using AspCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="Rutvik",Gender="Male" },
                new Student{Id=2,Name="Karo",Gender="Male" },
                new Student{Id=3,Name="Kaka",Gender="Male" }
            };
            return View(students);
        }
        public IActionResult About()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="Rutvik",Gender="Male" },
                new Student{Id=2,Name="Karo",Gender="Male" },
                new Student{Id=3,Name="Kaka",Gender="Male" }
            };
            return View(students);
        }
        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="Rutvik",Gender="Male" },
                new Student{Id=2,Name="Karo",Gender="Male" },
                new Student{Id=3,Name="Kaka",Gender="Male" }
            };
            return View(students);
        }
    }
}
