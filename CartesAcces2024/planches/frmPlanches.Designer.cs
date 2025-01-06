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
    partial class frmPlanches
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanches));
            this.pbDocument = new System.Windows.Forms.PictureBox();
            this.btnGenererVide = new System.Windows.Forms.Button();
            this.btnTrombi = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.panelBdd = new System.Windows.Forms.Panel();
            this.btnGererClassesTemp = new System.Windows.Forms.Button();
            this.btnToutAjouter = new System.Windows.Forms.Button();
            this.btnToutRetirer = new System.Windows.Forms.Button();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSel = new System.Windows.Forms.ListBox();
            this.listBoxNonSel = new System.Windows.Forms.ListBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTipSource = new System.Windows.Forms.ToolTip(this.components);
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProfils = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocument)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.panelBdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbDocument
            // 
            this.pbDocument.BackColor = System.Drawing.Color.White;
            this.pbDocument.Location = new System.Drawing.Point(2, 2);
            this.pbDocument.Margin = new System.Windows.Forms.Padding(2);
            this.pbDocument.Name = "pbDocument";
            this.pbDocument.Size = new System.Drawing.Size(1316, 1008);
            this.pbDocument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDocument.TabIndex = 0;
            this.pbDocument.TabStop = false;
            // 
            // btnGenererVide
            // 
            this.btnGenererVide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnGenererVide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenererVide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnGenererVide.Location = new System.Drawing.Point(21, 627);
            this.btnGenererVide.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenererVide.Name = "btnGenererVide";
            this.btnGenererVide.Size = new System.Drawing.Size(346, 32);
            this.btnGenererVide.TabIndex = 3;
            this.btnGenererVide.Text = "Générer les planches sans photos";
            this.btnGenererVide.UseVisualStyleBackColor = false;
            this.btnGenererVide.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // btnTrombi
            // 
            this.btnTrombi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnTrombi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrombi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnTrombi.Location = new System.Drawing.Point(21, 678);
            this.btnTrombi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrombi.Name = "btnTrombi";
            this.btnTrombi.Size = new System.Drawing.Size(346, 32);
            this.btnTrombi.TabIndex = 12;
            this.btnTrombi.Text = "Générer les trombinoscopes avec photos enregistrées";
            this.btnTrombi.UseVisualStyleBackColor = false;
            this.btnTrombi.Click += new System.EventHandler(this.btnTrombi_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(19, 21);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 17);
            this.lblTitre.TabIndex = 13;
            this.lblTitre.Text = "Titre";
            // 
            // cbClasse
            // 
            this.cbClasse.Enabled = false;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(120, 19);
            this.cbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(269, 24);
            this.cbClasse.TabIndex = 14;
            this.cbClasse.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectionIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbDocument);
            this.panel1.Location = new System.Drawing.Point(21, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 502);
            this.panel1.TabIndex = 15;
            // 
            // numZoom
            // 
            this.numZoom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZoom.Location = new System.Drawing.Point(574, 19);
            this.numZoom.Margin = new System.Windows.Forms.Padding(2);
            this.numZoom.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(90, 22);
            this.numZoom.TabIndex = 16;
            this.numZoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numZoom.ValueChanged += new System.EventHandler(this.numZoom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(471, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "🔎 Zoom :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnEnregistrer.Location = new System.Drawing.Point(412, 627);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(266, 32);
            this.btnEnregistrer.TabIndex = 18;
            this.btnEnregistrer.Text = "💾 Enregistrer le document";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // panelBdd
            // 
            this.panelBdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panelBdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBdd.Controls.Add(this.btnGererClassesTemp);
            this.panelBdd.Controls.Add(this.btnToutAjouter);
            this.panelBdd.Controls.Add(this.btnToutRetirer);
            this.panelBdd.Controls.Add(this.btnRetirer);
            this.panelBdd.Controls.Add(this.btnAjouter);
            this.panelBdd.Controls.Add(this.label2);
            this.panelBdd.Controls.Add(this.label1);
            this.panelBdd.Controls.Add(this.listBoxSel);
            this.panelBdd.Controls.Add(this.listBoxNonSel);
            this.panelBdd.Location = new System.Drawing.Point(705, 61);
            this.panelBdd.Margin = new System.Windows.Forms.Padding(2);
            this.panelBdd.Name = "panelBdd";
            this.panelBdd.Size = new System.Drawing.Size(309, 649);
            this.panelBdd.TabIndex = 19;
            // 
            // btnGererClassesTemp
            // 
            this.btnGererClassesTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnGererClassesTemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGererClassesTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnGererClassesTemp.Location = new System.Drawing.Point(30, 529);
            this.btnGererClassesTemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnGererClassesTemp.Name = "btnGererClassesTemp";
            this.btnGererClassesTemp.Size = new System.Drawing.Size(245, 45);
            this.btnGererClassesTemp.TabIndex = 20;
            this.btnGererClassesTemp.Text = "🛠 Gérer les classes temporaires";
            this.btnGererClassesTemp.UseVisualStyleBackColor = false;
            this.btnGererClassesTemp.Click += new System.EventHandler(this.btnGererClassesTemp_Click);
            // 
            // btnToutAjouter
            // 
            this.btnToutAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnToutAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToutAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnToutAjouter.Location = new System.Drawing.Point(161, 479);
            this.btnToutAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnToutAjouter.Name = "btnToutAjouter";
            this.btnToutAjouter.Size = new System.Drawing.Size(114, 32);
            this.btnToutAjouter.TabIndex = 19;
            this.btnToutAjouter.Text = "Tout ajouter >>";
            this.btnToutAjouter.UseVisualStyleBackColor = false;
            this.btnToutAjouter.Click += new System.EventHandler(this.btnToutAjouter_Click);
            // 
            // btnToutRetirer
            // 
            this.btnToutRetirer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnToutRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToutRetirer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnToutRetirer.Location = new System.Drawing.Point(30, 479);
            this.btnToutRetirer.Margin = new System.Windows.Forms.Padding(2);
            this.btnToutRetirer.Name = "btnToutRetirer";
            this.btnToutRetirer.Size = new System.Drawing.Size(118, 32);
            this.btnToutRetirer.TabIndex = 18;
            this.btnToutRetirer.Text = "<< Tout retirer";
            this.btnToutRetirer.UseVisualStyleBackColor = false;
            this.btnToutRetirer.Click += new System.EventHandler(this.btnToutRetirer_Click);
            // 
            // btnRetirer
            // 
            this.btnRetirer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetirer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnRetirer.Location = new System.Drawing.Point(30, 428);
            this.btnRetirer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(118, 32);
            this.btnRetirer.TabIndex = 17;
            this.btnRetirer.Text = "< Retirer";
            this.btnRetirer.UseVisualStyleBackColor = false;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnAjouter.Location = new System.Drawing.Point(161, 428);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(114, 32);
            this.btnAjouter.TabIndex = 16;
            this.btnAjouter.Text = "Ajouter >";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MaximumSize = new System.Drawing.Size(125, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Trombinoscopes à générer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Liste classes";
            // 
            // listBoxSel
            // 
            this.listBoxSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.listBoxSel.ForeColor = System.Drawing.Color.White;
            this.listBoxSel.FormattingEnabled = true;
            this.listBoxSel.ItemHeight = 16;
            this.listBoxSel.Location = new System.Drawing.Point(161, 59);
            this.listBoxSel.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSel.Name = "listBoxSel";
            this.listBoxSel.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSel.Size = new System.Drawing.Size(127, 356);
            this.listBoxSel.Sorted = true;
            this.listBoxSel.TabIndex = 13;
            // 
            // listBoxNonSel
            // 
            this.listBoxNonSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.listBoxNonSel.ForeColor = System.Drawing.Color.White;
            this.listBoxNonSel.FormattingEnabled = true;
            this.listBoxNonSel.ItemHeight = 16;
            this.listBoxNonSel.Location = new System.Drawing.Point(19, 59);
            this.listBoxNonSel.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxNonSel.Name = "listBoxNonSel";
            this.listBoxNonSel.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxNonSel.Size = new System.Drawing.Size(129, 356);
            this.listBoxNonSel.Sorted = true;
            this.listBoxNonSel.TabIndex = 12;
            // 
            // cbSource
            // 
            this.cbSource.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(705, 24);
            this.cbSource.Margin = new System.Windows.Forms.Padding(2);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(309, 28);
            this.cbSource.TabIndex = 20;
            this.toolTipSource.SetToolTip(this.cbSource, resources.GetString("cbSource.ToolTip"));
            this.cbSource.SelectedIndexChanged += new System.EventHandler(this.cbSource_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(703, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Source des élèves :";
            this.toolTipSource.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // toolTipSource
            // 
            this.toolTipSource.ToolTipTitle = "Sélectionner la source";
            // 
            // cbFormat
            // 
            this.cbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(172, 582);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(2);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(61, 28);
            this.cbFormat.TabIndex = 22;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 587);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Format des pages :";
            // 
            // cbProfils
            // 
            this.cbProfils.AutoSize = true;
            this.cbProfils.ForeColor = System.Drawing.Color.White;
            this.cbProfils.Location = new System.Drawing.Point(260, 587);
            this.cbProfils.Margin = new System.Windows.Forms.Padding(2);
            this.cbProfils.Name = "cbProfils";
            this.cbProfils.Size = new System.Drawing.Size(413, 21);
            this.cbProfils.TabIndex = 24;
            this.cbProfils.Text = "Colorier différemment les noms en fonction des profils élèves";
            this.cbProfils.UseVisualStyleBackColor = true;
            // 
            // frmPlanches
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1052, 817);
            this.Controls.Add(this.cbProfils);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSource);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numZoom);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnTrombi);
            this.Controls.Add(this.btnGenererVide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPlanches";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPlanches_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbDocument)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            this.panelBdd.ResumeLayout(false);
            this.panelBdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDocument;
        private System.Windows.Forms.Button btnGenererVide;
        private System.Windows.Forms.Button btnTrombi;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Panel panelBdd;
        private System.Windows.Forms.Button btnToutAjouter;
        private System.Windows.Forms.Button btnToutRetirer;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSel;
        private System.Windows.Forms.ListBox listBoxNonSel;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ToolTip toolTipSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGererClassesTemp;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbProfils;
    }
}