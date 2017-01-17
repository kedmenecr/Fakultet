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
        public List<PjesmaNaAlbumu> VratiPjesme()
        {
            return pjesme;
        }
        public void DodajPjesmu(PjesmaNaAlbumu pjesma)
        {
            pjesme.Add(pjesma);
        }

        public void DodajPjesmu(int rednibroj, string naziv, int trajanje)
        {
            pjesme.Add(new PjesmaNaAlbumu(rednibroj, naziv, trajanje, izvodac));
        }

        public void ObrisiPjesmu(int rednibroj)
        {
            for (int i = pjesme.Count - 1; i >= 0; i--)
                if (pjesme[i].getRedniBrojPjesme() == rednibroj)
                    pjesme.RemoveAt(i);
        }

        public int VratiBrojPjesama()
        {
            return pjesme.Count;
        }

        public int VratiTrajanje()
        {
            int t = 0;
            foreach (PjesmaNaAlbumu p in pjesme)
                t += p.getTrajanje();
            return t;
        }

        ////public void DodajPjesmu(int rednibrojpjesme, string naziv, int trajanjeusekundama) {
        ////    pjesme.Add(new PjesmaNaAlbumu(rednibrojpjesme, naziv, trajanjeusekundama));

        ////}
    }
}
