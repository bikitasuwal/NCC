using Microsoft.AspNetCore.Mvc;

namespace Bikita_4_CSRF.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // 👈 Important for CSRF protection
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                TempData["msg"] = "Login Successful!";
            }
            else
            {
                TempData["msg"] = "Invalid username or password.";
            }
            return View();

        }
    }
    }