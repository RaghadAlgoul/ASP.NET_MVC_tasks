using MVC_Task2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Task2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Student()
        {
            List<Models.Student> obj = new List<Student>();
            obj.Add(new Student { ID = 1, Name = "Raghad Alghoul", Major = "CS",Faculty="IT" });
            obj.Add(new Student { ID = 2, Name = "Raghad Alrashdan", Major = "CS", Faculty = "IT" });
            return View(obj);
        }
    }
}