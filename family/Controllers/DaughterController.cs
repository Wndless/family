using Family.Model;
using Family.ModelProperty;
using Microsoft.AspNetCore.Mvc;

namespace family.Controllers
{
    public class DaughterController : Controller
    {
        public IActionResult Index()
        {
            List<FamilyData> model = FamilyModel.GetMenu("daughter");

            ViewBag.Model = model;

            return View(model);
        }
    }
}
