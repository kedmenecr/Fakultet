using System;
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

        public Sastojak(string naziv, double kolicina)
        {
            this.naziv = naziv;
            this.kolicina = kolicina;
        }
       

        public Sastojak(string naziv,double kolicina,double defaulKolicina)
        {
            this.naziv = naziv;
            this.kolicina = kolicina;
            
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
