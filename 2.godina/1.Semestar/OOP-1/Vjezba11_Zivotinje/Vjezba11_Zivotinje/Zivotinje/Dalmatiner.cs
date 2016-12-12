using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba11_Zivotinje.Zivotinje
{
    class Dalmatiner : Pas
    {
        public Dalmatiner(string naziv) : base(naziv)
        {
        }

        public new string GlasajSe()
        {
            return "Bark bak";
        }
    }
}
