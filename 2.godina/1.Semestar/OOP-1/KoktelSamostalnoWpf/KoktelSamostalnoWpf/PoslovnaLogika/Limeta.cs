using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoktelSamostalnoWpf.PoslovnaLogika
{
    class Limeta : Sastojak
    {


        public Limeta(double kolicina) : base(kolicina)
        {

            kolicinaDeci = kolicina * 0.4;
        }
        public override string Prikazi()
        {
            return kolicina + "limete";

        }

    }
}
