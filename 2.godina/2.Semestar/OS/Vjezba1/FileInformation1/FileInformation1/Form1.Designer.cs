﻿namespace FileInformation1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.odaberiDirektorijTipka = new System.Windows.Forms.Button();
            this.direktorijTextBox = new System.Windows.Forms.TextBox();
            this.popisDatoteka = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dodajPopisDatotekaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.odabranaDatotekaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.odabranaDatotekaIndexTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vrijemeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.velicinaDatotekeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.atributiTextBox = new System.Windows.Forms.TextBox();
            this.readonlyTextBox = new System.Windows.Forms.TextBox();
            this.Atributi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // odaberiDirektorijTipka
            // 
            this.odaberiDirektorijTipka.Location = new System.Drawing.Point(12, 12);
            this.odaberiDirektorijTipka.Name = "odaberiDirektorijTipka";
            this.odaberiDirektorijTipka.Size = new System.Drawing.Size(75, 23);
            this.odaberiDirektorijTipka.TabIndex = 0;
            this.odaberiDirektorijTipka.Text = "Direktorij";
            this.odaberiDirektorijTipka.UseVisualStyleBackColor = true;
            this.odaberiDirektorijTipka.Click += new System.EventHandler(this.odaberiDirektorijTipka_Click);
            // 
            // direktorijTextBox
            // 
            this.direktorijTextBox.Location = new System.Drawing.Point(93, 14);
            this.direktorijTextBox.Name = "direktorijTextBox";
            this.direktorijTextBox.Size = new System.Drawing.Size(549, 20);
            this.direktorijTextBox.TabIndex = 1;
            this.direktorijTextBox.TextChanged += new System.EventHandler(this.direktorijTextBox_TextChanged);
            // 
            // popisDatoteka
            // 
            this.popisDatoteka.FormattingEnabled = true;
            this.popisDatoteka.Location = new System.Drawing.Point(12, 70);
            this.popisDatoteka.Name = "popisDatoteka";
            this.popisDatoteka.Size = new System.Drawing.Size(630, 173);
            this.popisDatoteka.TabIndex = 2;
            this.popisDatoteka.SelectedIndexChanged += new System.EventHandler(this.popisDatoteka_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj u listu (Proba)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Obriši popis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dodajPopisDatotekaButton
            // 
            this.dodajPopisDatotekaButton.Location = new System.Drawing.Point(210, 41);
            this.dodajPopisDatotekaButton.Name = "dodajPopisDatotekaButton";
            this.dodajPopisDatotekaButton.Size = new System.Drawing.Size(195, 23);
            this.dodajPopisDatotekaButton.TabIndex = 5;
            this.dodajPopisDatotekaButton.Text = "Dodaj popis datoteka u direktoriju";
            this.dodajPopisDatotekaButton.UseVisualStyleBackColor = true;
            this.dodajPopisDatotekaButton.Click += new System.EventHandler(this.dodajPopisDatotekaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "U Listi je odabrana datoteka:";
            // 
            // odabranaDatotekaTextBox
            // 
            this.odabranaDatotekaTextBox.Location = new System.Drawing.Point(161, 249);
            this.odabranaDatotekaTextBox.Name = "odabranaDatotekaTextBox";
            this.odabranaDatotekaTextBox.Size = new System.Drawing.Size(481, 20);
            this.odabranaDatotekaTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Indeks odabrane datoteke:";
            // 
            // odabranaDatotekaIndexTextBox
            // 
            this.odabranaDatotekaIndexTextBox.Location = new System.Drawing.Point(161, 278);
            this.odabranaDatotekaIndexTextBox.Name = "odabranaDatotekaIndexTextBox";
            this.odabranaDatotekaIndexTextBox.Size = new System.Drawing.Size(79, 20);
            this.odabranaDatotekaIndexTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Atributi);
            this.groupBox1.Controls.Add(this.readonlyTextBox);
            this.groupBox1.Controls.Add(this.atributiTextBox);
            this.groupBox1.Controls.Add(this.vrijemeTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.velicinaDatotekeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci odabrane datoteke";
            // 
            // vrijemeTextBox
            // 
            this.vrijemeTextBox.Location = new System.Drawing.Point(372, 28);
            this.vrijemeTextBox.Name = "vrijemeTextBox";
            this.vrijemeTextBox.Size = new System.Drawing.Size(169, 20);
            this.vrijemeTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vrijeme:";
            // 
            // velicinaDatotekeTextBox
            // 
            this.velicinaDatotekeTextBox.Location = new System.Drawing.Point(59, 28);
            this.velicinaDatotekeTextBox.Name = "velicinaDatotekeTextBox";
            this.velicinaDatotekeTextBox.Size = new System.Drawing.Size(169, 20);
            this.velicinaDatotekeTextBox.TabIndex = 1;
            this.velicinaDatotekeTextBox.TextChanged += new System.EventHandler(this.velicinaDatotekeTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Veličina:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // atributiTextBox
            // 
            this.atributiTextBox.Location = new System.Drawing.Point(59, 86);
            this.atributiTextBox.Name = "atributiTextBox";
            this.atributiTextBox.Size = new System.Drawing.Size(169, 20);
            this.atributiTextBox.TabIndex = 4;
            // 
            // readonlyTextBox
            // 
            this.readonlyTextBox.Location = new System.Drawing.Point(372, 86);
            this.readonlyTextBox.Name = "readonlyTextBox";
            this.readonlyTextBox.Size = new System.Drawing.Size(169, 20);
            this.readonlyTextBox.TabIndex = 5;
            // 
            // Atributi
            // 
            this.Atributi.AutoSize = true;
            this.Atributi.Location = new System.Drawing.Point(6, 89);
            this.Atributi.Name = "Atributi";
            this.Atributi.Size = new System.Drawing.Size(42, 13);
            this.Atributi.TabIndex = 6;
            this.Atributi.Text = "Atributi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ReadOnly:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.odabranaDatotekaIndexTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.odabranaDatotekaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajPopisDatotekaButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.popisDatoteka);
            this.Controls.Add(this.direktorijTextBox);
            this.Controls.Add(this.odaberiDirektorijTipka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button odaberiDirektorijTipka;
        private System.Windows.Forms.TextBox direktorijTextBox;
        private System.Windows.Forms.ListBox popisDatoteka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button dodajPopisDatotekaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odabranaDatotekaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox odabranaDatotekaIndexTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox velicinaDatotekeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vrijemeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Atributi;
        private System.Windows.Forms.TextBox readonlyTextBox;
        private System.Windows.Forms.TextBox atributiTextBox;
    }
}

