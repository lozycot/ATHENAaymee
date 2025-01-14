/**
 * MIT License
 * 
 * Copyright (c) 2023, 2024 Collège Caroline Aigle
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 */

namespace CartesAcces2024
{
    partial class frmSelectionZone
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
            this.pbDoc = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbOver = new System.Windows.Forms.PictureBox();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.numD = new System.Windows.Forms.NumericUpDown();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAntihoraire = new System.Windows.Forms.Button();
            this.btnHoraire = new System.Windows.Forms.Button();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSupprPage = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tkbZoom = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDoc
            // 
            this.pbDoc.Location = new System.Drawing.Point(2, 2);
            this.pbDoc.Margin = new System.Windows.Forms.Padding(2);
            this.pbDoc.Name = "pbDoc";
            this.pbDoc.Size = new System.Drawing.Size(911, 660);
            this.pbDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDoc.TabIndex = 0;
            this.pbDoc.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbOver);
            this.panel1.Controls.Add(this.pbDoc);
            this.panel1.Location = new System.Drawing.Point(151, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 666);
            this.panel1.TabIndex = 1;
            // 
            // pbOver
            // 
            this.pbOver.BackColor = System.Drawing.Color.White;
            this.pbOver.Location = new System.Drawing.Point(2, 2);
            this.pbOver.Margin = new System.Windows.Forms.Padding(2);
            this.pbOver.Name = "pbOver";
            this.pbOver.Size = new System.Drawing.Size(911, 660);
            this.pbOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOver.TabIndex = 1;
            this.pbOver.TabStop = false;
            // 
            // numG
            // 
            this.numG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numG.Location = new System.Drawing.Point(35, 485);
            this.numG.Margin = new System.Windows.Forms.Padding(2);
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(112, 27);
            this.numG.TabIndex = 2;
            this.numG.ValueChanged += new System.EventHandler(this.numG_ValueChanged);
            // 
            // numB
            // 
            this.numB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numB.Location = new System.Drawing.Point(566, 853);
            this.numB.Margin = new System.Windows.Forms.Padding(2);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(102, 27);
            this.numB.TabIndex = 3;
            this.numB.ValueChanged += new System.EventHandler(this.numB_ValueChanged);
            // 
            // numD
            // 
            this.numD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numD.Location = new System.Drawing.Point(1076, 485);
            this.numD.Margin = new System.Windows.Forms.Padding(2);
            this.numD.Name = "numD";
            this.numD.Size = new System.Drawing.Size(99, 27);
            this.numD.TabIndex = 4;
            this.numD.ValueChanged += new System.EventHandler(this.numD_ValueChanged);
            // 
            // numH
            // 
            this.numH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numH.Location = new System.Drawing.Point(566, 132);
            this.numH.Margin = new System.Windows.Forms.Padding(2);
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(98, 27);
            this.numH.TabIndex = 5;
            this.numH.ValueChanged += new System.EventHandler(this.numH_ValueChanged);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnValider.Location = new System.Drawing.Point(1001, 969);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(174, 52);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Suivant >";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnAnnuler.Location = new System.Drawing.Point(1037, 29);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(138, 52);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "❌Tout annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(921, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pour que les photos soient correctement découpées, placez les lignes rouges au ni" +
    "veau des extrémités de la grille entière.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(562, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marge haute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 463);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marge gauche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(562, 831);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Marge basse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1072, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Marge droite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(586, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "(N\'oubliez pas de faire TOUS les côtés, en utilisant les barres de défilement.)";
            // 
            // btnAntihoraire
            // 
            this.btnAntihoraire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnAntihoraire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAntihoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntihoraire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnAntihoraire.Location = new System.Drawing.Point(35, 91);
            this.btnAntihoraire.Margin = new System.Windows.Forms.Padding(2);
            this.btnAntihoraire.Name = "btnAntihoraire";
            this.btnAntihoraire.Size = new System.Drawing.Size(179, 58);
            this.btnAntihoraire.TabIndex = 14;
            this.btnAntihoraire.Text = "↪ Pivoter a gauche";
            this.btnAntihoraire.UseVisualStyleBackColor = false;
            this.btnAntihoraire.Click += new System.EventHandler(this.btnAntihoraire_Click);
            // 
            // btnHoraire
            // 
            this.btnHoraire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnHoraire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoraire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoraire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnHoraire.Location = new System.Drawing.Point(996, 91);
            this.btnHoraire.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoraire.Name = "btnHoraire";
            this.btnHoraire.Size = new System.Drawing.Size(179, 58);
            this.btnHoraire.TabIndex = 15;
            this.btnHoraire.Text = "↩ Pivoter a droite";
            this.btnHoraire.UseVisualStyleBackColor = false;
            this.btnHoraire.Click += new System.EventHandler(this.btnHoraire_Click);
            // 
            // cbClasse
            // 
            this.cbClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(96, 982);
            this.cbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(131, 28);
            this.cbClasse.TabIndex = 16;
            this.cbClasse.SelectedIndexChanged += new System.EventHandler(this.cbClasse_SelectedIndexChanged);
            // 
            // numPage
            // 
            this.numPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPage.Location = new System.Drawing.Point(322, 983);
            this.numPage.Margin = new System.Windows.Forms.Padding(2);
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(94, 27);
            this.numPage.TabIndex = 17;
            this.numPage.ValueChanged += new System.EventHandler(this.numPage_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 985);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Classe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(271, 985);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Page";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1088, 780);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.MaximumSize = new System.Drawing.Size(150, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 100);
            this.label9.TabIndex = 20;
            this.label9.Text = "Définissez la classe et le numéro de page avant de pouvoir continuer.";
            // 
            // btnSupprPage
            // 
            this.btnSupprPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnSupprPage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSupprPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnSupprPage.Location = new System.Drawing.Point(805, 969);
            this.btnSupprPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprPage.Name = "btnSupprPage";
            this.btnSupprPage.Size = new System.Drawing.Size(192, 52);
            this.btnSupprPage.TabIndex = 21;
            this.btnSupprPage.Text = "🗑 Supprimer cette page";
            this.btnSupprPage.UseVisualStyleBackColor = false;
            this.btnSupprPage.Click += new System.EventHandler(this.btnSupprPage_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(31, 909);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "🔎 Zoom :";
            // 
            // tkbZoom
            // 
            this.tkbZoom.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tkbZoom.Location = new System.Drawing.Point(118, 907);
            this.tkbZoom.Margin = new System.Windows.Forms.Padding(4);
            this.tkbZoom.Maximum = 100;
            this.tkbZoom.Minimum = 30;
            this.tkbZoom.Name = "tkbZoom";
            this.tkbZoom.Size = new System.Drawing.Size(1057, 56);
            this.tkbZoom.TabIndex = 24;
            this.tkbZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbZoom.UseWaitCursor = true;
            this.tkbZoom.Value = 50;
            this.tkbZoom.Scroll += new System.EventHandler(this.tkbTaillePhoto_Scroll);
            // 
            // frmSelectionZone
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(1237, 1032);
            this.Controls.Add(this.tkbZoom);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSupprPage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numPage);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.btnHoraire);
            this.Controls.Add(this.btnAntihoraire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.numH);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numD);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSelectionZone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Athena - Découpage des marges";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSelectionZone_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbDoc)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbOver;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numD;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAntihoraire;
        private System.Windows.Forms.Button btnHoraire;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.NumericUpDown numPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSupprPage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tkbZoom;
    }
}