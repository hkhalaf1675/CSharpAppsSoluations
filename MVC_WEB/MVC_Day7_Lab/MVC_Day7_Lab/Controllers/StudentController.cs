using Microsoft.AspNetCore.Mvc;
using MVC_Day7_Lab.Models;

namespace MVC_Day7_Lab.Controllers
{
    public class StudentController : Controller
    {
        SchoolDbContext context;
        public StudentController(SchoolDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            return View(context.Students.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            return View(student);
        }
    }
}
