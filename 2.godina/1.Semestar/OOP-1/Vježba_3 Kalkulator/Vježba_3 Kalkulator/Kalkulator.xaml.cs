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
    /// <summary>
    /// Interaction logic for Kalkulator.xaml
    /// </summary>
    public partial class Kalkulator : Window
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        

      
        
        private void zbrojButton_Click_1(object sender, RoutedEventArgs e)
        {
            double prviBroj;
            double drugiBroj;
            double rezultat;

            prviBroj = double.Parse(prviBrojTextBox.Text);
            drugiBroj = double.Parse(drugiBrojTextBox.Text);
            rezultat = prviBroj + drugiBroj;
            rezultatBrojTextBox.Text = rezultat.ToString();
        }

        private void oduzmiButton_Click(object sender, RoutedEventArgs e)
        {
            double prviBroj;
            double drugiBroj;
            double rezultat;

            prviBroj = double.Parse(prviBrojTextBox.Text);
            drugiBroj = double.Parse(drugiBrojTextBox.Text);
            rezultat = prviBroj - drugiBroj;
            rezultatBrojTextBox.Text = rezultat.ToString();
        }

        private void pomnoziButton_Click(object sender, RoutedEventArgs e)
        {
            double prviBroj;
            double drugiBroj;
            double rezultat;

            prviBroj = double.Parse(prviBrojTextBox.Text);
            drugiBroj = double.Parse(drugiBrojTextBox.Text);
            rezultat = prviBroj * drugiBroj;
            rezultatBrojTextBox.Text = rezultat.ToString();
        }

        private void podijeliButton_Click(object sender, RoutedEventArgs e)
        {
            double prviBroj;
            double drugiBroj;
            double rezultat;

            prviBroj = double.Parse(prviBrojTextBox.Text);
            drugiBroj = double.Parse(drugiBrojTextBox.Text);
            rezultat = prviBroj / drugiBroj;
            rezultatBrojTextBox.Text = rezultat.ToString();
        }
    }
    }

