using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Biki04Controller : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                return View("Success", st);
            }
            return View();
        }
        public IActionResult Details(Student st)
        {
            return View(st);
        }
    }
}

