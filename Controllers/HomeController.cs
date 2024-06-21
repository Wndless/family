using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace family.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult _Footer()
        {
            List<string> familys = new List<string> { "엄마", "아빠", "아들", "딸" };

            return PartialView("footer", familys);
        }
    }
}