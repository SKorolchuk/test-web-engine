using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebEngine.Web.Extentions.StatisticsServices;

namespace TestWebEngine.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult StartUp()
        {
            return View();
        }
        public ActionResult Index()
        {
            return PartialView();
        }

        public PartialViewResult Next()
        {
            return PartialView();
        }
    }
}