using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KORISTI SE ISPIS PARAMETARA POMOČUI FOR PETLJE
            Console.WriteLine("Aplikacija pokrenuta...........\n");
            Console.WriteLine("primljenih argumenata  : {0} ", args.Length);
            Console.WriteLine("--------------------------------------------\n");

            for (int i = 0; i < args.Length; i++) {
                Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);


            }
            Console.ReadLine();

            Console.WriteLine("--------------------------------------------\n");
            //KORISTI SE FOREACH 
            int brojac = 0;
            foreach (string arg in args)
            {
                Console.WriteLine("Arg[{0}] = [{0}]", brojac, args[brojac]);
                brojac = brojac + 1;
            }
            Console.ReadLine();

        }

    }
}
