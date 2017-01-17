using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba11_Zivotinje.Zivotinje
{
    class Macka:Zivotinja
    {
        public Macka(string naziv) : base(naziv)
        {
        }

        public override string GlasajSe()
        {
            return "mijau";
        }
    }
}
