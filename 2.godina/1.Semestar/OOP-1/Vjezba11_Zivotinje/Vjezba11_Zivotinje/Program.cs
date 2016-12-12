using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vjezba11_Zivotinje.Zivotinje;
namespace Vjezba11_Zivotinje
{
    class Program
    {
        static void Main(string[] args)
        {
            Zivotinja bobi = new Pas();
            bobi.setNaziv("PES BOBI");
            Krava Milka = new Krava();
            Milka.setNaziv("Milka");
            Macka Mila = new Macka();
            Mila.setNaziv("Milka");
            Dalmatiner Rex = new Dalmatiner();
            Rex.setNaziv("Rex");
            List<Zivotinja> zoo = new List<Zivotinja>();
            zoo.Add(bobi);
            zoo.Add(Milka);
            zoo.Add(Mila);

            zoo.Add(Rex);

            foreach ( Zivotinja z in zoo)
            {
                Console.WriteLine("{0} : {1} ",z.getNaziv(), z.GlasajSe());
            }



        }
    }
}
