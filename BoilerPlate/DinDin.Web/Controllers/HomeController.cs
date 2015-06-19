using System.Web.Mvc;

namespace DinDin.Web.Controllers
{
    public class HomeController : DinDinControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}