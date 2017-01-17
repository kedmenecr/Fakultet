using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoktelSamostalnoWpf.PoslovnaLogika
{
    class Led:Sastojak
    {
        public Led(string naziv) : base(naziv)
        {
            this.naziv = naziv;
            kolicinaDeci = 1;
        }
        public override string Prikazi()
        {
            return "Led " + naziv;
        }

    }
}
