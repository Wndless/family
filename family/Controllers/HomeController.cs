using Family.Model;
using Family.ModelProperty;
using Microsoft.AspNetCore.Mvc;

namespace family.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<FamilyData> model = FamilyModel.GetMenu("mom");
            
            return View(model);
        }
    }
}