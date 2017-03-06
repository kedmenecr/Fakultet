using StudentiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentiMVC.Controllers
{
    public class StudentController : Controller
    {
        //model kontrolera

        private StudentiDB baza = new StudentiDB();

        // GET: Student

            //ulazna stranica
        public ActionResult Index()
        {
            ViewBag.Title = "Baza Studenata";
            return View();
            
        }
        public ActionResult Popis()
        {
            ViewBag.Title = "Popis studenata";
            return View(baza.VratiStudent());

        }

    }
}