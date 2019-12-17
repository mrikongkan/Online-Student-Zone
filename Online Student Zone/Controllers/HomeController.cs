using Online_Student_Zone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Student_Zone.Controllers
{
    public class HomeController : Controller
    {
        StudentsContext db = new StudentsContext();
        // GET: Home
        public ActionResult Index()
        {
            var Data = db.Students.ToList();
            return View(Data);
        }

        [HttpGet]
        public ActionResult AddStudents()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudents(Students std)
        {
            if(ModelState.IsValid == true)
            {
                db.Students.Add(std);
                var studentdata = db.SaveChanges();
                if (studentdata > 0)
                {
                    ViewBag.AlertMessage = "<script>alert('Data Successfully Addded!');</script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.AlertMessage = "<script>alert('Data Successfully Not Addded!');</script>";
                }
            }
            return View();
        }
    }
}