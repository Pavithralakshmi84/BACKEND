using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //  public ActionResult Index()
        //{
        //  return View();
        // }

        public ViewResult Index1(int? id, string name, double? price)
        {
            ViewData["Id"] = id;
            ViewData["Name"] = name;
            ViewData["Price"] = price;
            return View();
        }
        public ViewResult Display1()
        {
            List<string> Colors = new List<string>() { "Red", "Blue", "Pink", "Black", "White", "Green", "Brown", "Purple" };
            ViewData["Colors"] = Colors;
            return View();
        }

        public ViewResult Index2(int? id, string name, double? price)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Price = price;
            return View();
        }
        public ViewResult Display2()
        {
            List<string> Colors = new List<string>() { "Red", "Blue", "Pink", "Black", "White", "Green", "Purple", "Yellow" };
            ViewBag.Colors = Colors;
            return View();
        }

        public RedirectToRouteResult Index3(int? id, string name, double? price)
        {
            ViewData["Id"] = id;
            ViewBag.Name = name;
            TempData["Price"] = price;
            return RedirectToAction("Index4");
        }
        public ViewResult Index4()
        {
            return View();
        }
    }
}