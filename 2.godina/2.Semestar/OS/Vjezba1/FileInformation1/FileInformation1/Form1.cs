using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileInformation1
{
    public partial class Form1 : Form
    {

        string stazaDirektorija;
        string[] popisDatotekaUDirektoriju; 

        public Form1()
        {
            InitializeComponent();
        }

        private void odaberiDirektorijTipka_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                stazaDirektorija = folderBrowserDialog1.SelectedPath;
                direktorijTextBox.Text = stazaDirektorija;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            popisDatoteka.Items.Add("Tekst 1");
            popisDatoteka.Items.Add("Tekst 2");
            popisDatoteka.Items.Add("Tekst 3"); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            popisDatoteka.Items.Clear();
        }

        private void dodajPopisDatotekaButton_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(stazaDirektorija))
            {
                /* Ovaj dio se kasnije može preskočiti kako ne bi svaki puta
                 * kada je staza u redu smetao korinsika */
                
                ww//string message = "Staza direktorija je valjana";
                //string caption = "Provjera valjanosti staze direktorija.";
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //DialogResult result;
                //result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                //string message = "Staza direktorija NIJE valjana!";
                //string caption = "Provjera valjanosti staze direktorija.";
                //MessageBoxButtons buttons = MessageBoxButtons.OK;
                //DialogResult result;
                //result = MessageBox.Show(message, caption, buttons);

                //ako folde nije valjani onda treba folder broweser dialog

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    stazaDirektorija = folderBrowserDialog1.SelectedPath;
                    direktorijTextBox.Text = stazaDirektorija;
                }


            }

            popisDatotekaUDirektoriju = Directory.GetFiles(stazaDirektorija);

            foreach (string datoteka in popisDatotekaUDirektoriju)
            {
                popisDatoteka.Items.Add(datoteka);
            }

            if (stazaDirektorija != null) 
            {
                folderBrowserDialog1.SelectedPath = stazaDirektorija;
            }

        }

        private void popisDatoteka_SelectedIndexChanged(object sender, EventArgs e)
        {

            string odabranaDatotekaStaza = popisDatotekaUDirektoriju[popisDatoteka.SelectedIndex];
            odabranaDatotekaTextBox.Text = odabranaDatotekaStaza;
            odabranaDatotekaIndexTextBox.Text = popisDatoteka.SelectedIndex.ToString();

            
            FileInfo fInf = new FileInfo(odabranaDatotekaStaza);

            vrijemeTextBox.Text = fInf.LastWriteTime.ToString();
            atributiTextBox.Text = fInf.Attributes.ToString();
            readonlyTextBox.Text = fInf.IsReadOnly.ToString();

             string velicinaDatotekeTextBox1 = fInf.Length.ToString();

            if (fInf.Length >= (1 << 30))
                velicinaDatotekeTextBox1 = string.Format("{0}Gb", fInf.Length >> 30);
            else
            if (fInf.Length >= (1 << 20))
                velicinaDatotekeTextBox1 = string.Format("{0}Mb", fInf.Length >> 20);
            else
            if (fInf.Length >= (1 << 10))
                velicinaDatotekeTextBox1 = string.Format("{0}Kb", fInf.Length >> 10);

            velicinaDatotekeTextBox.Text = velicinaDatotekeTextBox1;

            
        }

        private void velicinaDatotekeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void direktorijTextBox_TextChanged(object sender, EventArgs e)
        {
            stazaDirektorija = direktorijTextBox.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //zadnje vrijeme pristupa
        //atributi
        //read only treba napraviti
    }
}
