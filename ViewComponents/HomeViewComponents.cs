using Microsoft.AspNetCore.Mvc;

namespace family.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }
    }
}