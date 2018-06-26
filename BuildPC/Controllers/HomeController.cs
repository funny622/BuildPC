using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuildPC.Models;
using BuildPC.Controllers;


namespace BuildPC.Controllers
{
    public class HomeController : Controller
    {
        DOANCNEntities context = new DOANCNEntities();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Build1()
        {
            ViewBag.Title = "Build";

            return View();
        }

        public ActionResult Build2()
        {
            ViewBag.Title = "Build2";

            return View();
        }

        public ActionResult Quanly()
        {
            ViewBag.Title = "Quanly";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Title = "Test";

            return View();
        }

        public ActionResult Nangcap()
        {
            ViewBag.Title = "Nangcap";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login";

            return View();
        }

        public ActionResult Check()
        {
            ViewBag.Title = "Check";

            return View();
        }
    }
}
