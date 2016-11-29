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

        public PjesmaNaAlbumu(int rednibrojpjesme,string naziv, int trajanjeusekundama,string izvodac) {
            this.rednibrojpjesme = rednibrojpjesme;
            this.naziv = naziv;
            this.trajanjeusekundama = trajanjeusekundama;
            this.izvodac = izvodac;
        }
        public int getTrajanje() {

            return trajanjeusekundama;

        }
        public int getRedniBrojPjesme() {
            return rednibrojpjesme;
        }

    }
}
