using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aj678815MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Senior majoring in MIS graduating May of 2020.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me.";

            return View();
        }
    }
}