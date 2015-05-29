using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glasses.Web.Models;

namespace Glasses.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Define(int size = 200)
        {
            ViewBag.TextSize = size;
            return View();
        }

        public ActionResult GlassesList()
        {
            var model = new List<Models.Glasses>()
            {
                new Models.Glasses { Name = "111", Dioptries = "0.5 - 6.0", Description = "Окуляри зі шкляною лінзою, металевою оправою та флекс-фіксаторами" },
                new Models.Glasses { Name = "222", Dioptries = "1.0 - 4.0", Description = "Окуляри з полімерною лінзою, силіконовою роговою оправою, флекс-фіксаторами" },
                new Models.Glasses { Name = "232", Dioptries = "1.0 - 4.0", Description = "Окуляри з полімерною лінзою найвищого гатунку, та комп'ютерним захистом. Міцна титаномістка оправа " },
                new Models.Glasses { Name = "112", Dioptries = "1.0 - 4.0", Description = "Окуляри з полімерною лінзою та силіконовою роговою оправою" },
                new Models.Glasses { Name = "122", Dioptries = "1.0 - 4.0", Description = "Окуляри з полімерною лінзою, комп'ютерним захистом. Металева оправа з флекс-фіксаторами" },
                new Models.Glasses { Name = "132", Dioptries = "1.0 - 4.0", Description = "Окуляри з полімерною лінзою найвищого гатунку, комп'ютерним захистом та металевою оправою" },
               
            };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}