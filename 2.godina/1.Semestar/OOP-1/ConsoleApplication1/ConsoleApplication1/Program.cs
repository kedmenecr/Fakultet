using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZbrajanjeJabuka
{
    public struct UnosJabuka
    {
        public string boja;
        public int kolicina;
    }
    class Program
    {
        static List<UnosJabuka> Lista = new List<UnosJabuka>();
        static void Main(string[] args)
        {
            string odabir = "";
            while (odabir.ToUpper() != "R")
            {
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
            float prosjek = 0;


            List<string> boja = new List<string>();

            Console.WriteLine("\nREZULTATI UNOSA");

            Console.WriteLine("---------------------------");
            foreach (UnosJabuka un in Lista)
            {
                Console.WriteLine("{0,-15}{1,10}", un.boja, un.kolicina.ToString());
                if (un.kolicina < min)
                    min = un.kolicina;
                if (un.kolicina > max)
                    max = un.kolicina;
                ukupno += un.kolicina;
            }
            prosjek = (float)ukupno / Lista.Count;
            Console.WriteLine("Minimalno jabuka: {0}", min);
            Console.WriteLine("Maximalno jabuka: {0}", max);
            Console.WriteLine("Ukupno jabuka: {0}", ukupno);
            Console.WriteLine("Prosjek: {0}", prosjek);
            Console.WriteLine("Razlicite boje: ");
            foreach (string bojaa in boja) Console.WriteLine(bojaa);
        }
        public static void UnosKolicine()
        {
            UnosJabuka u = new UnosJabuka();
            Console.WriteLine("UNOS JABUKA");
            Console.WriteLine("-----------");
            Console.Write("Boja: ");
            u.boja = Console.ReadLine();
            Console.Write("Kolicina: ");
            u.kolicina = int.Parse(Console.ReadLine());
            Lista.Add(u);
        }
    }
}