using System.Collections.Generic;
using System.Web.Mvc;

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
            ViewBag.Message = "Студенти НУ \"Львівська політехніка\"";

            return View();
        }

        public ActionResult Instractions()
        {
            return View();
        }

        public ActionResult Define(int size = 1, double dioptr = 4)
        {
            if (size >= 9) return RedirectToAction("GoodEyes");

				ViewBag.Size = size;
				ViewBag.Dioptr = dioptr;
            return View();
        }

        public ActionResult GoodEyes()
        {
            return View();
        }

        public ActionResult GlassesList()
        {
            var model = new List<Models.Glasses>()
            {
                new Models.Glasses 
                { 
                    Name = "111",
                    Dioptries = "0.5 - 6.0",
                    Description = "Окуляри зі шкляною лінзою, металевою оправою та флекс-фіксаторами",
                    ImageUrl = @"\Content\Images\Glasses\111.jpg"
                },
                new Models.Glasses 
                { 
                    Name = "222",
                    Dioptries = "1.0 - 4.0",
                    Description = "Окуляри з полімерною лінзою, силіконовою роговою оправою, флекс-фіксаторами",
                    ImageUrl = @"\Content\Images\Glasses\222.jpg"
                },
                new Models.Glasses 
                {
                    Name = "232",
                    Dioptries = "1.0 - 4.0",
                    Description = "Окуляри з полімерною лінзою найвищого гатунку, та комп'ютерним захистом. Міцна титаномістка оправа ",
                    ImageUrl = @"\Content\Images\Glasses\232.jpg"
                },
                new Models.Glasses
                { 
                    Name = "112",
                    Dioptries = "1.0 - 4.0",
                    Description = "Окуляри з полімерною лінзою та силіконовою роговою оправою",
                    ImageUrl = @"\Content\Images\Glasses\112.jpg"
                },
                new Models.Glasses
                {
                    Name = "122",
                    Dioptries = "1.0 - 4.0",
                    Description = "Окуляри з полімерною лінзою, комп'ютерним захистом. Металева оправа з флекс-фіксаторами",
                    ImageUrl = @"\Content\Images\Glasses\122.jpg"
                },
                new Models.Glasses 
                {
                    Name = "132",
                    Dioptries = "1.0 - 4.0",
                    Description = "Окуляри з полімерною лінзою найвищого гатунку, комп'ютерним захистом та металевою оправою",
                    ImageUrl = @"\Content\Images\Glasses\132.jpg"
                },
               
            };

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "+380933988644 Андрій";

            return View();
        }

		  public ActionResult BadSight() {
			  return View();
		  }
    }
}