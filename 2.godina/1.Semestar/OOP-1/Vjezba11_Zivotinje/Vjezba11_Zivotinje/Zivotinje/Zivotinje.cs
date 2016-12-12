using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba11_Zivotinje.Zivotinje
{
    class Zivotinje
    {
        private string naziv;

        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public string getNaziv()
        {
            return naziv;
        }
        public string GlasajSe()
        {
            return "Neznam se glasati!";
        }

    }
}
