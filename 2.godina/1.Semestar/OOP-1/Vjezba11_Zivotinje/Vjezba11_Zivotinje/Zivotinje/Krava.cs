﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba11_Zivotinje.Zivotinje
{
    class Krava:Zivotinja
    {
        public Krava(string naziv) : base(naziv)
        {
        }

        public override string GlasajSe()
        {
            return "muuuu";
        }
    }
}
