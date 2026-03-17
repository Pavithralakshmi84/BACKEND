using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controller_Architeture.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult List()
        {
            return View();
        }

        // Action 2
        public ActionResult Details()
        {
            return View();
        }

        // Action 3
        public ActionResult Create()
        {
            return View();
        }
    }
}