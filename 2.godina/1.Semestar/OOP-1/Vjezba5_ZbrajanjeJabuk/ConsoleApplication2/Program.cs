using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbrajanjeJabuka
{

    public struct Unosjabuka
    {
        public string boja;
        public int kolicina;

    }

    class Program
    {

        static List<Unosjabuka> Lista = new List<Unosjabuka>();
        static void Main(string[] args)
        {
            string odabir = "";
            while (odabir.ToUpper() != "R" ){
                UnosKolicine();
                Console.Write("Za rezultate upisati (R) ili (ENTER) za nastavak...");
                odabir = Console.ReadLine();
            }
            Rezultati();
            Console.ReadLine();
        }
        public static void Rezultati()
        {
            int min = int.MaxValue;
            int max = 0;
            int ukupno = 0;
            float prosjek;

            List<String> boja = new List<string>();
            Console.WriteLine("\nREZULTATI UNOSA");
            Console.WriteLine("--------------------------");
            
            foreach (Unosjabuka un in Lista)
            {
                Console.WriteLine("{0,-15}{1,10}", un.boja, un.kolicina.ToString());
                if (un.kolicina < min)
                {
                    min = un.kolicina;

                }
                if (un.kolicina < max)
                {
                    max = un.kolicina;
                    ukupno += un.kolicina;
                }

            }

        }

       static public void UnosKolicine()
        {

            
        }
    }
}
