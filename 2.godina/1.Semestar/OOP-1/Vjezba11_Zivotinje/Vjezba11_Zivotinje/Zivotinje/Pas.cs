﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba11_Zivotinje.Zivotinje
{
    class Pas  : Zivotinja
    {
        public Pas(string naziv) : base(naziv)
        {
        }
       

        public override string GlasajSe() {
            return "bark";
        }
    }
}
