﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoktelSamostalnoWpf.PoslovnaLogika
{
    class CocaCola:Sastojak
    {
        public CocaCola(string naziv,double kolicina) : base(naziv, kolicina)
        {
            kolicinaDeci = kolicina * 2.5;
        }
        public override string Prikazi()
        {
            return kolicina + " Coca Cola Zero";
        }

    }
}
