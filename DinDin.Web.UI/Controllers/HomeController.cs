using DinDin.Web.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinDin.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private static List<ExpenseModel> ExpenseHistory = new List<ExpenseModel>();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Raspberry Pi!";

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

        [HttpGet]
        public ActionResult Expenses()
        {
            ViewBag.History = ExpenseHistory;
            return View();
        }

        [HttpPost]
        public ActionResult Expenses(ExpenseModel expense)
        {
            if (ModelState.IsValid) {
                ExpenseHistory.Insert(0, expense);
                ModelState.Clear();
            }
            ViewBag.History = ExpenseHistory;
            return View(expense);
        }
    }
}
