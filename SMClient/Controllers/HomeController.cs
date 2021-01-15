using SMClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMClient.Controllers
{
    public class HomeController : Controller
    {
        private ServiceReference1.ServiceClient sm = new ServiceReference1.ServiceClient();
        public ActionResult Index()
        {
            return View(sm.GetStudents());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent([Bind(Include = "Id,Code,Name,Birthday,Gender,Email,Introduction")] Student student)
        {
            sm.AddStudent(student);
            return RedirectToAction("Index");
        }
        public ActionResult UpdateStudent(int? id)
        {
            Student student = sm.Edit(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult UpdateStudent([Bind(Include = "Id,Code,Name,Birthday,Gender,Email,Introduction")] Student student)
        {
            sm.UpdateStudent(student);
            return RedirectToAction("Index");
        }
    }
}