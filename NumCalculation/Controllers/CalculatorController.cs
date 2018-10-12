using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NumCalculation.Models;

namespace NumCalculation.Controllers
{
    public class CalculatorController : Controller
    {
		// GET: Calculator
		public ActionResult Index()
		{
			return View();
		}


		public ActionResult Result(ModelAddition modelBinders)
		{
			ViewBag.result = modelBinders.firstValue + modelBinders.secondValue;

			return View("~/Views/Calculator/Index.cshtml");

		}
	}
}