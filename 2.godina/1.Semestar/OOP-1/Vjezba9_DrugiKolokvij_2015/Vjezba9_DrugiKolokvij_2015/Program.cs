using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba9_DrugiKolokvij_2015.Logika;

namespace Vjezba9_DrugiKolokvij_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            Izvodac beatles = new Izvodac("Beatles", 1960);
            GlazbeniAlbum abbeyRoad = new GlazbeniAlbum("Abbey Road", beatles, Zanr.Rock);
            abbeyRoad.DodajPjesmu(new PjesmaNaAlbumu(1, "Come Together", 257, beatles));
            abbeyRoad.DodajPjesmu(2, "Something", 183);
            // abbeyRoad.ObrisiPjesmu(2);

            // ispis
            Console.WriteLine("{0}, {1}, {2}", abbeyRoad.getNaziv(), abbeyRoad.getIzvodac(), abbeyRoad.getIzvodac());
            Console.WriteLine("Trajanje {0} min", abbeyRoad.VratiTrajanje() / 60);
            Console.WriteLine("-------------------------------------------------------------------");
            foreach (PjesmaNaAlbumu p in abbeyRoad.VratiPjesme())
                Console.WriteLine(p);

            Console.ReadLine();


        }
    }
}
