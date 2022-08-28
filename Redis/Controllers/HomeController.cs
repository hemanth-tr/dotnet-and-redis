using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["username"] = "Hemanth";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = Session["username"];
            Session.Clear();
            Session.Abandon();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}