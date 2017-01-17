using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vježba3_kalkulator_v2_0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Oglasnik : Window
    {

        public struct Oglas
        {

            //ovo su svojstva /properties/ deklarirana na skračeni način

            public string Tip { get; set; }
            public string Proizvodjac { get; set; }
            public int GodinaProzivodnje { get; set; }
            public string NovoVozilo { get; set; }
            public bool PrviVlasnik { get; set; }


            //deklaracija na stari način!

            private string oprema;
            public string Oprema
            {
                get
                {
                    return oprema;
                }
                set
                {
                    oprema = value;
                }
            }

        }
        private string[] proizvodjaci = new string[] { "Audi", "Bmw", "Mercedes", "Citroen", };
        private string[] dodatnaOprema = new string[] { "Klima", "Abs", "Osiguranje", "kočnice" };
        //lista oglasa
        public List<Oglas> oglasi = new List<Oglas>();
        //lista godine
        public List<int> VratiListuGodina(int odGodine, int doGodine) {

            List<int> godine = new List<int>();
            for (int i = odGodine; i <= doGodine; i++)
            {
                godine.Add(i);
                return godine;
            }
        }

        
        


        }
    }


        
    }
}
