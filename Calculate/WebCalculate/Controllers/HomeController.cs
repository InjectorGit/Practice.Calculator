using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculate;
namespace WebCalculate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
             new SelectListItem() { Value = "PLUS", Text ="PLUS" },
             new SelectListItem() { Value = "MULTIPLY", Text ="MULTIPLY" },
             new SelectListItem() { Value = "MINUS", Text ="MINUS" },
             new SelectListItem() { Value = "DIVISION", Text ="DIVISION" },
             new SelectListItem() { Value = "MINIMUM", Text ="MINIMUM" }
            };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
         public ActionResult Index(double firstValue, double secondValue, string count)
            {
            calc calculator = ClassFactoryMethod.calcMethod(Convert.ToInt16(count));
            double result = calculator.Calculate(firstValue, secondValue);

            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
             new SelectListItem() { Value = "PLUS", Text ="PLUS" },
             new SelectListItem() { Value = "MULTIPLY", Text ="MULTIPLY" },
             new SelectListItem() { Value = "MINUS", Text ="MINUS" },
             new SelectListItem() { Value = "DIVISION", Text ="DIVISION" },
             new SelectListItem() { Value = "MINIMUM", Text ="MINIMUM" }
            };
            return View();
        }

    }
}