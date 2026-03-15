using MVCUIDesigning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;


namespace MVCUIDesigning.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddStudent(Student student)
        {
            return View("DisplayStudent", student);
        }
        [HttpGet]
        public ViewResult AddStudentST()
        {
            return View(new Student());
        }
        [HttpPost]
        public ViewResult AddStudentST(Student student)
        {
            return View("DisplayStudentST", student);
        }

    }
}