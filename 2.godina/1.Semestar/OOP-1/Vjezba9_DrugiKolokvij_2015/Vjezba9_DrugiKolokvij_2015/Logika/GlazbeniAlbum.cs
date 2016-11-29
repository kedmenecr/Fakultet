using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba9_DrugiKolokvij_2015.Logika
{
    class GlazbeniAlbum
    {
        private string naziv;
        private Izvodac izvodac;
        private Zanr zanr;
        private List<PjesmaNaAlbumu> pjesme;

        public GlazbeniAlbum(string naziv, Izvodac izvodac, Zanr zanr)
        {
            this.naziv = naziv;
            this.izvodac = izvodac;
            this.zanr = zanr;
            pjesme = new List<PjesmaNaAlbumu>();
        }
        public string getNaziv() {
            return naziv;
        }
        public Izvodac getIzvodac()
        {
            return izvodac;
        }
        public List<PjesmaNaAlbumu> getListaPjesma()
        {
            return pjesme;
        }
        public void dodajPjesmu(PjesmaNaAlbumu pjesme) {
        pjesme.Add(pjesme)
                }

        ////public void DodajPjesmu(int rednibrojpjesme, string naziv, int trajanjeusekundama) {
        ////    pjesme.Add(new PjesmaNaAlbumu(rednibrojpjesme, naziv, trajanjeusekundama));

        ////}
    }
}
