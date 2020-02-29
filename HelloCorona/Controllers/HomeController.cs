using HelloCorona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloCorona.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Other/HelloWorld.cshtml");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var student = new Student()
            {
                Age = 20,
                RollNumber = "A001"
            };
            var project = new Project()
            {
                Id = "Pr01",
                Name = ".Net MVC Project"
            };
            var combineData = new CombineData()
            {
                  MyProject = project,
                  MyStudent = student
            };            
            return View("~/Views/Home/About.cshtml", combineData);
        }

        public ActionResult HelloList()
        {
            var list = new List<Student>();
            list.Add(new Student()
            {
                Age = 10,
                RollNumber = "a001"
            });
            list.Add(new Student()
            {
                Age = 20,
                RollNumber = "a002"
            });
            list.Add(new Student()
            {
                Age = 30,
                RollNumber = "a003"
            });
            return View("~/Views/Home/ListStudent.cshtml", list);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}