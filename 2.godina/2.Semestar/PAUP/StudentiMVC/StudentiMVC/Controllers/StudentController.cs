using StudentiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace StudentiMVC.Controllers
{
    public class StudentController : Controller
    {
        //model kontrolera

        private StudentiDB baza = new StudentiDB();
        private StudentiDB baza1 = new StudentiDB();
        private StudentiDB studenti = new StudentiDB();
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

        public ActionResult Detaljno()
        {
            ViewBag.Title = "Detaljni podatci";
            return View(baza1.VratiStudent());  
        }

        //azuriranje podatak o studentu
        public ActionResult Azuriraj(int? Id) {
            //vracanje ako je id null
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Student s = studenti.VratiStudent().Find(x => x.Id == Id);
            //nadji prvog studenta koji ima jedna id
            if(s == null)
            {
                return HttpNotFound();
            }
            ViewBag.Title = "Detaljno o studentima";
            return View();
        }

    }
}