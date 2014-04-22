using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Parser;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.EnvironmentName = ConfigurationManager.AppSettings["EnvironmentName"];
            var lastPing = HttpContext.Application["last-ping"];
            if (lastPing == null)
            {
                ViewBag.LastPing = "never";
            }
            else
            {
                ViewBag.LastPing = ((DateTime) lastPing) + " UTC";
            }
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

        public ActionResult Ping()
        {
            HttpContext.Application["last-ping"] = DateTime.UtcNow;
            return new EmptyResult();
        }
    }
}