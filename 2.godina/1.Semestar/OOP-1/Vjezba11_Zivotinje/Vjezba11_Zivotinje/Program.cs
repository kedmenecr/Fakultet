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
            Pas bobi = new Pas();
            bobi.setNaziv("PES BOBI");
            Console.WriteLine("{0} : {1}",bobi.getNaziv(),bobi.GlasajSe());
            
        }
    }
}
