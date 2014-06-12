using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinDin.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        public ActionResult ToDo()
        {
            return View();
        }

        public ActionResult Balance()
        {
            return View();
        }

        public ActionResult Expenses()
        {
            return View();
        }
    }
}