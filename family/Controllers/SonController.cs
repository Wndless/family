using Family.Model;
using Family.ModelProperty;
using Microsoft.AspNetCore.Mvc;

namespace family.Controllers
{
    public class SonController : Controller
    {
        public IActionResult Index()
        {
            List<FamilyData> model = FamilyModel.GetMenu("son");

            ViewBag.Model = model;

            return View(model);
        }
    }
}
