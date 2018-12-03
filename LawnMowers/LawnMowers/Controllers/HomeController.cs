using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LawnMowers.Models;

namespace LawnMowers.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Alexis Escamez.";

            return View();
        }

        [HttpPost]
        public ActionResult Result(string chain)
        {
            ViewBag.Message = "Your result page.";

            ProcessData pd = new ProcessData();
            
            return View(pd.handler(chain));
        }

    }
}