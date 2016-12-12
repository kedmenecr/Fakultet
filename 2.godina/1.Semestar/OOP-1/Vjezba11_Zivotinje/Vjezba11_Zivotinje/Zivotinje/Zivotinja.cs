using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba11_Zivotinje.Zivotinje
{
    class Zivotinja
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
        public virtual string GlasajSe()
        {
            return "Neznam se glasati!";
        }
        public Zivotinja(string naziv)
        {
            this.naziv = naziv;

        }

    }
}
