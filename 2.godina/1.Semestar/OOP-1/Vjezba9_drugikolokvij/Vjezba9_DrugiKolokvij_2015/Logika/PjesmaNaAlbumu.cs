using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba9_DrugiKolokvij_2015.Logika
{
    class PjesmaNaAlbumu
    {
        private int rednibrojpjesme;
        private string naziv;
        private int trajanjeusekundama;
        private string izvodac;
        private int _rbr;
        private string _naziv;
        private int _trajanje;
        private Izvodac izvodac1;

        public PjesmaNaAlbumu(int rednibrojpjesme,string naziv, int trajanjeusekundama,string izvodac) {
            this.rednibrojpjesme = rednibrojpjesme;
            this.naziv = naziv;
            this.trajanjeusekundama = trajanjeusekundama;
            this.izvodac = izvodac;
        }

        public PjesmaNaAlbumu(int _rbr, string _naziv, int _trajanje, Izvodac izvodac1)
        {
            this._rbr = _rbr;
            this._naziv = _naziv;
            this._trajanje = _trajanje;
            this.izvodac1 = izvodac1;
        }

        public int getTrajanje() {

            return trajanjeusekundama;

        }
        public int getRedniBrojPjesme() {
            return rednibrojpjesme;
        }

    }
}
