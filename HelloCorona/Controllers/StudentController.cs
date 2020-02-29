using HelloCorona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloCorona.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> list = new List<Student>();
        // GET: Student
        public ActionResult Index()
        {
            return View(list);
        }

        public ActionResult Create()
        {
            return View("CreateV2", new Student());
        }

        [HttpPost]
        public ActionResult Store(Student student) // ViewModel (view) vs Model -> database
        {
            if (ModelState.IsValid)
            {
                list.Add(student);
                return Redirect("/Student/Index");
            }
            else
            {
                return View("Create", student);
            }
        }
    }
}