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
        List<object> godineStudija = new List<object>
        {   new {value = 1, text ="Prva"},
            new {value = 2, text ="Druga"},
            new {value = 3, text ="Treća"},
            new {value = 4, text ="Četvrta"},
            new {value = 5, text ="Peta" }};


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
        public ActionResult Azuriraj(int? Id)
        {
            Student s;
            //vracanje ako je id null
            if (Id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                s = new Student();
                ViewBag.Title = "Upis novog studenta";

            }
            else
            {
                s = studenti.VratiStudent().Find(x => x.Id == Id);
            //nadji prvog studenta koji ima jedna id
            if (s == null)
            {
                return HttpNotFound();
            }
                ViewBag.Title = "Ažuriranje podataka o studentu";
            
        }
            ViewBag.GodineStudija = godineStudija;
            return View(s);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Azuriraj(
            [Bind(Include = "Id,Ime,Prezime,Spol,OIB,GodinaRodjenja,GodinaStudija,RedovitiStundet")] Student s)
        {
            if (ModelState.IsValid)
            {
                if(s.Id != 0) { 
                studenti.AzuriranjeStudenta(s);
                
                }
                else
                {
                    studenti.DodajStudenta(s);
                    return RedirectToAction("Popis");
                }
            }

            ViewBag.GodineStudija = godineStudija;
            ViewBag.Title = "Ažuriranje podataka o studentu";
            return View(s);
        }

    }
}