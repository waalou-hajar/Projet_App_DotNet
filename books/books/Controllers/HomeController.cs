using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace books.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult home()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult FAQ()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult home_admin()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult register()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult livre1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult livre2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult livre3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult livre4()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult authAdmin()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}