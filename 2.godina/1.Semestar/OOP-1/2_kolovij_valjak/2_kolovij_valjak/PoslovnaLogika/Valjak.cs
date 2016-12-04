using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_kolovij_valjak.PoslovnaLogika
{
    class Valjak
    {
        private float polumjer;
        private float visina;

        //konstruktor na 1
        public Valjak() {
            
            polumjer = 1;
            visina = 1;
        }
        //konsturktor za postavljanej

        public Valjak(float polumjer , float visina) {
            this.polumjer = polumjer;
            this.visina = visina;

        }
        //postavi i dohvati
        public void PostaviPolumjer(float polumjer) {        
            this.polumjer = polumjer;
        }

        public float DohvatiPolumjer() {
            return polumjer;
            }

        public void PostaviVisinu(float visina) {
            this.visina = visina;
        }
        public float DohvatiVisinu() {
            return visina;
        }



    }
}
