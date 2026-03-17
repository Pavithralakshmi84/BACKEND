using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAction_Results.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Action Method 2
        public ActionResult About()
        {
            return View();
        }

        // 3. Third action (view in Shared folder)
        public ActionResult SharedPage()
        {
            return View("~/Views/Shared/SharedPage.cshtml");
        }

        // 4. Fourth action (view in Test folder)
        public ActionResult TestPage()
        {
            return View("~/Views/Test/TestPage.cshtml");
        }

        // 5. Fifth action (another view in Test folder)
        public ActionResult CustomPage()
        {
            return View("~/Views/Test/CustomPage.cshtml");
        }
    }
}