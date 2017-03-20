using Microsoft.Win32;
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
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using static System.Windows.Forms;
using System.Xml.Linq;

namespace Vjezba02_Samostalno_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private string stazaDirektorija;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void OtvoriButton_Click(object sender, RoutedEventArgs e)
        {


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == true)
            {
                otvoriTextBox.Text = File.ReadAllText(ofd.FileName);

                string filename = ofd.FileName;
                pathOtvoriTextBox.Text = filename;
                stazaDirektorija = ofd.FileName;


            }



            // Open document 



        }

        private void folderButton_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openfiledalog1 = new OpenFileDialog();

            {
                string path = @"D:\luka.txt";
                using (StreamWriter File = new StreamWriter(path))
                {
                    File.Write(spremiTextBox.Text);
                    string filename = openfiledalog1.FileName;
                    spremiTextBox.Text = filename;
                }


            }
        }
    }
}
