using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controller_Architeture.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Action 2
        public ActionResult About()
        {
            return View();
        }

        // Action 3
        public ActionResult Contact()
        {
            return View();
        }


    }
}