using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba9_DrugiKolokvij_2015.Logika;
namespace Vjezba9_DrugiKolokvij_2015.Logika
{
    class Izvodac
    {

        private string naziv;
        private int godina;


        public Izvodac(string naziv, int godina)
        {
            this.naziv = naziv;
            this.godina = godina;
        }
        public override string ToString()
        {
            return naziv + " / " + godina + " / " ;
        }
    }
}
