using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoktelSamostalnoWpf.PoslovnaLogika;

namespace KoktelSamostalnoWpf
{
    class Program
    {
        static void Main(string[] args)
        {
            // preprema koktela
            Koktel CubaLibre = new Koktel("Cuba Libre");
            CubaLibre.Dodaj(new Limeta(0.5));
            CubaLibre.Dodaj(new Rum("Baccardi gold", 0.4));
            CubaLibre.Dodaj(new CocaCola("zero", 1));
            CubaLibre.Dodaj(new Led("drobljeni"));
            Console.WriteLine(CubaLibre.Posluzi());
            Console.ReadKey();
        }
    }
}
