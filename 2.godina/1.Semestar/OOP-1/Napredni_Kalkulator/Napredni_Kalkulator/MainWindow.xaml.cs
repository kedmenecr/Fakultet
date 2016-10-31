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

namespace Napredni_Kalkulator
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    enum Operacije { Zbrajanje, Oduzimanje, Mnozenje, Dijeljenje, Nijedna, Back, MC, MR , Mp , Mm , CE , C , pm, SQRT , Postotak , JedanKrozX };
    public partial class Kalkulator : Window

    {
      


        //deklariranje članova
        int broj1 = 0;
        int broj2 = 0;
        int privremenaPohranaBroja = 0;
        int rezultat;
        

        private Operacije operacija = Operacije.Nijedna;


        public Kalkulator()
        {
            InitializeComponent();
        }
        private void pritisnutBroj(int broj)
        {
            privremenaPohranaBroja = privremenaPohranaBroja * 10 + broj;
            ekranTextBox.Text = privremenaPohranaBroja.ToString();
        }
        







        private void ekranTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pomocniTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void jedanButton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(1);
        }

        private void dvaButton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(2);
        }

        private void triButton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(3);
        }

        private void petButton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(5);
        }

        private void cetiriButton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(4);
        }

        private void sedambutton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(7);
        }

        private void osambutton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(8);
        }

        private void devetButton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(9);
        }

        private void sestButton_Click(object sender, RoutedEventArgs e)
        {
            pritisnutBroj(6);
        }

        private void jednakoButton_Click(object sender, RoutedEventArgs e)
        {
            broj2 = privremenaPohranaBroja;
            privremenaPohranaBroja = 0;

            if (operacija == Operacije.Zbrajanje)
            {
                rezultat = broj1 + broj2;
            }

            if (operacija == Operacije.Oduzimanje)
            {
                rezultat = broj1 - broj2;
            }
            ekranTextBox.Text = rezultat.ToString();
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.Zbrajanje;
            broj1 = privremenaPohranaBroja;
            privremenaPohranaBroja = 0;
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.Oduzimanje;
            broj1 = privremenaPohranaBroja;
            privremenaPohranaBroja = 0;
        }

        private void putaButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void jedankrozxButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
