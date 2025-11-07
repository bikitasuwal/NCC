using Microsoft.AspNetCore.Mvc;
using Bikita_4_interest.Models;

namespace Bikita_4_interest.Controllers
{
    
        public class InterestController : Controller
        {

            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Calculate(InterestModel model)
            {
                if (ModelState.IsValid)
                {
                    model.Result = (model.Principal * model.Rate * model.Time) / 100;
                    return View("Result", model);
                }
                return View("Index");
            }


        }

    
}
