using Microsoft.AspNetCore.Mvc;
using practise.Models;
using System.Diagnostics;
using DAL1;
using BOL1;

namespace practise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Student() {
            List<Student> student = DbStudent.GetStudent();
            ViewBag.Student = student;

            return View();
        }

       
        public IActionResult AddNew() {
              return View();
        }

        [HttpPost]
        public IActionResult AddNew(string id,string name,string fees,string course,string date) {

            Student newstud = new Student(int.Parse(id), name, double.Parse(fees), Enum.Parse<Course>(course.ToUpper()), DateOnly.Parse(date));
            
            DbStudent.insertStudent(newstud);
            return RedirectToAction("Student");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}