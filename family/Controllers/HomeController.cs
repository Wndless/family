using Family.ModelProperty;
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
            List<FamilyData> datas = new List<FamilyData>();

            datas.Add(new FamilyData() { menu_name = "mom", menu_const_name = "엄마", label_name = "옥주" });
            datas.Add(new FamilyData() { menu_name = "dad", menu_const_name = "아빠", label_name = "동훈" });
            datas.Add(new FamilyData() { menu_name = "son", menu_const_name = "아들", label_name = "태건" });
            datas.Add(new FamilyData() { menu_name = "daughter", menu_const_name = "딸", label_name = "태린" });

            return PartialView("footer", datas);
        }
    }
}