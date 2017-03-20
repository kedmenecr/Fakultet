using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoktelSamostalnoWpf.PoslovnaLogika
{
    class Koktel
    {
        private string naziv;
        private List<Sastojak> sastojci = new List<Sastojak>(); 

        public Koktel(string naziv)
        {
            this.naziv = naziv;
        }
        public void Dodaj(Sastojak s)
        {
            sastojci.Add(s);
        }
        //u drugom slučaju funckija je void tipa a ne string.
        public string  Posluzi()
        {
            StringBuilder sb = new StringBuilder();
            double kolicinaLitara = 0;
            sb.Append("Poslužujem koktel" + naziv + Environment.NewLine);
            sb.Append("Sastojci (" + sastojci.Count + ")" + Environment.NewLine);
            foreach (Sastojak s in sastojci)
            {
                sb.Append(s.Prikazi() + Environment.NewLine);
                kolicinaLitara += s.vratiDecilitre();

            }
            sb.Append("Potrebna čaša minilano dcl : " + kolicinaLitara + Environment.NewLine);

            return sb.ToString();

            //double kolicinaDeci = 0;
            //Console.WriteLine("Posluzujem koktel " + naziv + "\n");
            //Console.WriteLine("Sastojci   (" + sastojci.Count() + ")" + "\n");
            //foreach(Sastojak s in sastojci)
            //{
            //    Console.WriteLine(s.Prikazi() + "\n");
            //    kolicinaDeci += s.vratiDecilitre();
            //}
            //Console.WriteLine("Potrebna čaša minilano dcl : " + kolicinaDeci);
                
                
        }
    }
}
