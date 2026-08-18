using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();

            ViewBag.TotalStudents = students.Count;
            ViewBag.TotalDepartments = students
                .Select(s => s.Department)
                .Distinct()
                .Count();

            ViewBag.TotalSemesters = students
                .Select(s => s.Semester)
                .Distinct()
                .Count();

            ViewBag.RecentStudents = students
                .OrderByDescending(s => s.Id)
                .Take(5)
                .ToList();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}