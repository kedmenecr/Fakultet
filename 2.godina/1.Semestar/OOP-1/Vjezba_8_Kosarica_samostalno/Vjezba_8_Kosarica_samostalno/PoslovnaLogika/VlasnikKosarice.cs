using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_8_Kosarica_samostalno.PoslovnaLogika
{
    class VlasnikKosarice
    {
        private string id;
        private string naziv;
        private string adresa;




        public VlasnikKosarice(string id, string naziv, string adresa)
        {
            this.id = id;
            this.naziv = naziv;
            this.adresa = adresa;
        }
        public string vratiID(string id) {
            return id;
        }
        public string vratiAdresu(string adresa)
        {
            return adresa;
        }
        public string vratiNaziv(string naziv)
        {
            return adresa;
        }
        public void promjeniNaziv(string naziv) {

            this.naziv = naziv;
        }
        public void promjeniAdresu(string adresa)
        {

            this.adresa= adresa;
        }

    }
}


