﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoktelSamostalnoWpf.PoslovnaLogika
{
    class Sastojak
    {
        protected string naziv;
        protected double kolicina;
        protected double kolicinaDeci;


        public Sastojak(string naziv)
        {
            this.naziv = naziv;
        }

        public Sastojak(double kolicina)
        {
            this.kolicina = kolicina;
        }

        public Sastojak( double kolicina, string naziv)
        {
            this.kolicina = kolicina;
            this.naziv = naziv;
        }
  
        

        public virtual string Prikazi()
        {
            return "undefined";
        }
        public  double vratiDecilitre()
        {
            return kolicinaDeci;
        }
    }

    

}
