using Family.Model;
using Family.ModelProperty;
using Microsoft.AspNetCore.Mvc;

namespace family.Controllers
{
    public class MomController : Controller
    {
        public IActionResult Index()
        {
            List<FamilyData> model = FamilyModel.GetMenu("mom");

            return View(model);
        }
    }
}
