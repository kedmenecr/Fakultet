using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoktelSamostalnoWpf.PoslovnaLogika
{
    class Rum:Sastojak
    {
        public Rum(double kolicina , string naziv) :base(kolicina, naziv)
        {
            this.naziv = naziv;
            kolicinaDeci = kolicina;
        }

        public override string Prikazi()
        {
            return kolicina + "dcl ruma Bacardi Gold";
    }
    }
}
