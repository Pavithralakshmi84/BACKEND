using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;

namespace MVCUIDesigning.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View();
        }
        //[HttpPost]
        //public ViewResult AddEmp(int? id, string name, string job, double? salary)
        //{
        //    ViewData["Id"] = id;
        //    ViewData["Name"] = name;
        //    ViewData["Job"] = job;
        //    ViewData["Salary"] = salary;
        //    return View("DisplayEmp1");
        //}

        //[HttpPost]
        //public ViewResult AddEmp(FormCollection fc)
        //{
        //    ViewData["Id"] = fc["id"];
        //    ViewData["Name"] = fc["name"];
        //    ViewData["Job"] = fc["job"];
        //    ViewData["Salary"] = fc["salary"];
        //    return View("DisplayEmp1");
        //}

        [HttpPost]
        public ViewResult AddEmp(Employee Emp)
        {
            return View("DisplayEmp2", Emp);
        }
    }
}