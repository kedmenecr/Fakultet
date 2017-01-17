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
using System.Windows.Shapes;

namespace Vježba_3_Kalkulator
{
    enum Operacija { Zbrajanje , Oduzimanje , Dijeljenje , Mnozenje };
    
            
    /// <summary>
    /// Interaction logic for Kalkulator.xaml
    /// </summary>
    public partial class Kalkulator : Window
    {
        public Kalkulator()
        {
            InitializeComponent();
            //prviBrojTextBox.Text = "101";

        }

        

      
        private void Izracunaj(Operacija o) {
            double prviBroj;
            double drugiBroj;
            double rezultat = 0;


            try
            {



                prviBroj = double.Parse(prviBrojTextBox.Text);
                drugiBroj = double.Parse(drugiBrojTextBox.Text);
                //računanje 
                if (o == Operacija.Zbrajanje)
                {
                    rezultat = prviBroj + drugiBroj;
                }
                else if (o == Operacija.Oduzimanje)
                {
                    rezultat = prviBroj - drugiBroj;
                }
                else if (o == Operacija.Dijeljenje)
                {
                    rezultat = prviBroj / drugiBroj;
                }
                else
                {
                    rezultat = prviBroj * drugiBroj;
                }
            }


            catch (Exception greska)
            {
                rezultatBrojTextBox.Text = greska.Message;
            }
            rezultatBrojTextBox.Text = rezultat.ToString();
        }
        private void zbrojButton_Click_1(object sender, RoutedEventArgs e)
        {
            Izracunaj(Operacija.Zbrajanje);
        }

        private void oduzmiButton_Click(object sender, RoutedEventArgs e)
        {
            Izracunaj(Operacija.Oduzimanje);
        }

        private void pomnoziButton_Click(object sender, RoutedEventArgs e)
        {
            Izracunaj(Operacija.Mnozenje);
        }

        private void podijeliButton_Click(object sender, RoutedEventArgs e)
        {
            Izracunaj(Operacija.Dijeljenje);

        }
    }
    }

