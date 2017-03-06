using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentiMVC.Models
{
    public class Student
    {
        private int myVar;

        public int Id
        {
            get { return myVar; }
            set { myVar = value; }
        }
        public string  Ime { get; set; }
        public string Prezime { get; set; }
        public Spol Spol { get; set; }
        public string OIB { get; set; }
        public DateTime Datumrodjenja { get; set; }
        public int GodinaStudija { get; set; }
        public bool RedovniStudent { get; set; }

    }
}