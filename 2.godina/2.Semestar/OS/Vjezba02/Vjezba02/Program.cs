using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba02
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            
            //pisanje
            string path = @"d:/roberto.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.Write("Hello");
                    sw.Write("Hello");

                }
            }
            string path1 = @"d:/roberto.txt";

            string s = "";
            StreamReader sr = File.OpenText(path1);

            while((s = sr.ReadLine()) != null )
            {
                Console.Write(s);
            }
            Console.Read();
        }
    }
}

