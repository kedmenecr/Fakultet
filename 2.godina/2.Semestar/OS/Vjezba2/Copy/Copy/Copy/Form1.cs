using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Copy
{
    public partial class Form1 : Form
    {
        //string stazaDirektorijaizKojegKopiramo;
        //string stazaDirektorijauKojiKopiramo;
        //string[] popisDatotekaUDirektorijuIzKojegKopiramo;
        //string[] popisDatotekaUDirektorijuUkojiKopiramo;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // kontrola
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //stazaDirektorijaizKojegKopiramo = folderBrowser.SelectedPath;
                //direktorijIzKojegKopiramo.Text = stazaDirektorijaizKojegKopiramo;

                // ako je odabran folder, zapamti ga
                direktorijIzKojegKopiramo.Text = folderBrowser.SelectedPath;
                // očisti listu na ekranu
                popisDatotekazaKopiranje.Items.Clear();
                if (Directory.Exists(direktorijIzKojegKopiramo.Text))
                {
                    popisDatotekazaKopiranje.Items.AddRange(Directory.GetFiles(direktorijIzKojegKopiramo.Text));
                }
                else
                {
                    direktorijIzKojegKopiramo.Text = "";
                }
            }
        }

        //    if (!Directory.Exists(stazaDirektorijaizKojegKopiramo))
        //    {
        //        if (folderBrowser.ShowDialog() == DialogResult.OK)
        //        {
        //            stazaDirektorijaizKojegKopiramo = folderBrowser.SelectedPath;
        //            direktorijIzKojegKopiramo.Text = stazaDirektorijaizKojegKopiramo;
        //        }
        //        else
        //        {
        //            return;
        //        }
        //    }
        //    popisDatotekaUDirektorijuIzKojegKopiramo = Directory.GetFiles(stazaDirektorijaizKojegKopiramo);

        //    foreach (string datoteka in popisDatotekaUDirektorijuIzKojegKopiramo)
        //    {
        //        popisDatotekazaKopiranje.Items.Add(datoteka);
        //    }

        //    if (stazaDirektorijaizKojegKopiramo != null)
        //    {
        //        folderBrowser.SelectedPath = stazaDirektorijaizKojegKopiramo;
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            // kontrola
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                //stazaDirektorijaizKojegKopiramo = folderBrowser.SelectedPath;
                //direktorijIzKojegKopiramo.Text = stazaDirektorijaizKojegKopiramo;

                // ako je odabran folder, zapamti ga
                direktorijuKojiKopiramo.Text = folderBrowser.SelectedPath;
                // očisti listu na ekranu
                popisDirektorijauKojiKopiramo.Items.Clear();
                if (Directory.Exists(direktorijIzKojegKopiramo.Text))
                {
                    popisDirektorijauKojiKopiramo.Items.AddRange(Directory.GetFiles(direktorijuKojiKopiramo.Text));
                }
                else
                {
                    direktorijIzKojegKopiramo.Text = "";
                }
            }
        }
        //    FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

        //    if (folderBrowser.ShowDialog() == DialogResult.OK)
        //    {
        //        stazaDirektorijauKojiKopiramo = folderBrowser.SelectedPath;
        //        direktorijuKojiKopiramo.Text = stazaDirektorijauKojiKopiramo;
        //    }

        //    if (!Directory.Exists(stazaDirektorijauKojiKopiramo))
        //    {
        //        if (folderBrowser.ShowDialog() == DialogResult.OK)
        //        {
        //            stazaDirektorijauKojiKopiramo = folderBrowser.SelectedPath;
        //            direktorijuKojiKopiramo.Text = stazaDirektorijauKojiKopiramo;
        //        }
        //        else
        //        {
        //            return;
        //        }

        //    }
        //    popisDatotekaUDirektorijuUkojiKopiramo = Directory.GetFiles(stazaDirektorijauKojiKopiramo);

        //    foreach (string datoteka in popisDatotekaUDirektorijuUkojiKopiramo)
        //    {
        //        popisDirektorijauKojiKopiramo.Items.Add(datoteka);
        //    }

        //    if (stazaDirektorijauKojiKopiramo != null)
        //    {
        //        folderBrowser.SelectedPath = stazaDirektorijauKojiKopiramo;
        //    }
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            popisDatotekazaKopiranje.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            popisDirektorijauKojiKopiramo.Items.Clear();
        }

        //tipka za kopiranje
        private void button5_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(direktorijIzKojegKopiramo.Text) && Directory.Exists(direktorijuKojiKopiramo.Text))
            {
                foreach (string file in popisDatotekazaKopiranje.SelectedItems)
                {
                    string nazivDatoteke = Path.GetFileName(file);
                    string odredisnaDatoteka = Path.Combine(direktorijuKojiKopiramo.Text, nazivDatoteke);
                    if (File.Exists(odredisnaDatoteka))
                    {
                        // poruka
                    }
                    else
                    {
                        File.Copy(file, odredisnaDatoteka, true);
                    }
                }
                // osvježimo popis desno
                popisDirektorijauKojiKopiramo.Items.Clear();
                popisDirektorijauKojiKopiramo.Items.AddRange(Directory.GetFiles(direktorijuKojiKopiramo.Text));
            }
            //    if (Directory.Exists(stazaDirektorijaizKojegKopiramo))
            //    {
            //        string odabranaDatoteka = popisDatotekaUDirektorijuIzKojegKopiramo[popisDatotekazaKopiranje.SelectedIndex];
            //        var fileName = Path.GetFileName(odabranaDatoteka);
            //        proba.Text = fileName;

            //        var sourcePath = stazaDirektorijaizKojegKopiramo;
            //        proba2.Text = sourcePath;

            //        var targetPath = stazaDirektorijauKojiKopiramo;
            //        proba3.Text = targetPath;

            //        if (Directory.Exists(targetPath))
            //        {
            //            var sourceFile = Path.Combine(sourcePath, fileName);
            //            var destFile = Path.Combine(targetPath, fileName);

            //            if (File.Exists(sourceFile))
            //            {
            //                File.Copy(sourceFile, destFile, true);
            //                MessageBox.Show("Kopiranje uspješno");

            //                popisDirektorijauKojiKopiramo.Items.Clear();

            //                popisDatotekaUDirektorijuUkojiKopiramo = Directory.GetFiles(stazaDirektorijauKojiKopiramo);

            //                foreach (string datoteka in popisDatotekaUDirektorijuUkojiKopiramo)
            //                {
            //                    popisDirektorijauKojiKopiramo.Items.Add(datoteka);
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Nije odabrana datoteka");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Nije odabran direktorij");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Nije odabran direktorij");
            //        return;
            //    }


        }
    }
}