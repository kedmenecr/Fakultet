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
            CubaLibre.Dodaj(new Rum(0.4, "Baccardi gold"));
            CubaLibre.Dodaj(new CocaCola(1,"zero"));
            CubaLibre.Dodaj(new Led("drobljeni"));
            Console.WriteLine(CubaLibre.Posluzi());
            Console.ReadKey();
        }
    }
}
