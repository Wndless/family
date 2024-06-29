﻿using Family.Model;
using Family.ModelProperty;
using Microsoft.AspNetCore.Mvc;

namespace family.Controllers
{
    public class DadController : Controller
    {
        public IActionResult Index()
        {
            List<FamilyData> model = FamilyModel.GetMenu("dad");

            ViewBag.Model = model;

            return View(model);
        }
    }
}
