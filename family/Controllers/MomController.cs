
using Microsoft.AspNetCore.Mvc;

namespace family.Controllers
{
    public class MomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
