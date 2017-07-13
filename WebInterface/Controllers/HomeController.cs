using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using SharpCalculator.TwoArgumentsCalculators;

namespace WebInterface.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operations = new List<SelectListItem>()
            {
                new SelectListItem{Text = "+", Value = "add"},
                new SelectListItem{Text = "-", Value = "substract"},
                new SelectListItem{Text = "*", Value = "multiply"},
                new SelectListItem{Text = "/", Value = "divide"}
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

        public ActionResult Calculate(double first, double second, string Operation)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(Operation);
            var result = calculator.Calculate(first, second);
            return View(result);
        }
    }
}