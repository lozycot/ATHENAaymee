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
    partial class frmModifClassesTemporaires
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
            this.btnCsvNouvelleAnnee = new System.Windows.Forms.Button();
            this.btnAddClasseTemp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelClasseTemp = new System.Windows.Forms.Button();
            this.listBoxClassesTemp = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbDeplacement = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddElTemp = new System.Windows.Forms.Button();
            this.listBoxElTemp = new System.Windows.Forms.ListBox();
            this.btnDelElTemp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCsvNouvelleAnnee
            // 
            this.btnCsvNouvelleAnnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnCsvNouvelleAnnee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCsvNouvelleAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnCsvNouvelleAnnee.Location = new System.Drawing.Point(503, 26);
            this.btnCsvNouvelleAnnee.Margin = new System.Windows.Forms.Padding(2);
            this.btnCsvNouvelleAnnee.Name = "btnCsvNouvelleAnnee";
            this.btnCsvNouvelleAnnee.Size = new System.Drawing.Size(268, 61);
            this.btnCsvNouvelleAnnee.TabIndex = 20;
            this.btnCsvNouvelleAnnee.Text = "Importer un .csv pour les nouveaux 6ème";
            this.btnCsvNouvelleAnnee.UseVisualStyleBackColor = false;
            this.btnCsvNouvelleAnnee.Click += new System.EventHandler(this.btnCsvNouvelleAnnee_Click);
            // 
            // btnAddClasseTemp
            // 
            this.btnAddClasseTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnAddClasseTemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClasseTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnAddClasseTemp.Location = new System.Drawing.Point(4, 47);
            this.btnAddClasseTemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddClasseTemp.Name = "btnAddClasseTemp";
            this.btnAddClasseTemp.Size = new System.Drawing.Size(183, 62);
            this.btnAddClasseTemp.TabIndex = 17;
            this.btnAddClasseTemp.Text = "➕ Créer une classe temporaire";
            this.btnAddClasseTemp.UseVisualStyleBackColor = false;
            this.btnAddClasseTemp.Click += new System.EventHandler(this.btnAddClasseTemp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelClasseTemp);
            this.groupBox1.Controls.Add(this.btnAddClasseTemp);
            this.groupBox1.Controls.Add(this.listBoxClassesTemp);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(42, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(193, 707);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste de classes nouvelle année";
            // 
            // btnDelClasseTemp
            // 
            this.btnDelClasseTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnDelClasseTemp.Enabled = false;
            this.btnDelClasseTemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelClasseTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnDelClasseTemp.Location = new System.Drawing.Point(6, 113);
            this.btnDelClasseTemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelClasseTemp.Name = "btnDelClasseTemp";
            this.btnDelClasseTemp.Size = new System.Drawing.Size(183, 64);
            this.btnDelClasseTemp.TabIndex = 18;
            this.btnDelClasseTemp.Text = "🗑 Supprimer une classe temporaire";
            this.btnDelClasseTemp.UseVisualStyleBackColor = false;
            this.btnDelClasseTemp.Click += new System.EventHandler(this.btnDelClasseTemp_Click);
            // 
            // listBoxClassesTemp
            // 
            this.listBoxClassesTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.listBoxClassesTemp.ForeColor = System.Drawing.Color.White;
            this.listBoxClassesTemp.FormattingEnabled = true;
            this.listBoxClassesTemp.ItemHeight = 16;
            this.listBoxClassesTemp.Location = new System.Drawing.Point(8, 181);
            this.listBoxClassesTemp.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxClassesTemp.Name = "listBoxClassesTemp";
            this.listBoxClassesTemp.Size = new System.Drawing.Size(181, 404);
            this.listBoxClassesTemp.Sorted = true;
            this.listBoxClassesTemp.TabIndex = 12;
            this.listBoxClassesTemp.SelectedIndexChanged += new System.EventHandler(this.listBoxClassesTemp_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDeplacement);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAddElTemp);
            this.groupBox2.Controls.Add(this.listBoxElTemp);
            this.groupBox2.Controls.Add(this.btnDelElTemp);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(251, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(195, 707);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste d\'élèves de la classe sélectionnée";
            // 
            // cbDeplacement
            // 
            this.cbDeplacement.FormattingEnabled = true;
            this.cbDeplacement.Location = new System.Drawing.Point(7, 663);
            this.cbDeplacement.Margin = new System.Windows.Forms.Padding(2);
            this.cbDeplacement.Name = "cbDeplacement";
            this.cbDeplacement.Size = new System.Drawing.Size(184, 24);
            this.cbDeplacement.Sorted = true;
            this.cbDeplacement.TabIndex = 23;
            this.cbDeplacement.SelectedIndexChanged += new System.EventHandler(this.cbDeplacement_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 595);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MaximumSize = new System.Drawing.Size(120, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 51);
            this.label7.TabIndex = 24;
            this.label7.Text = "↪ Déplacer l\'élève dans une autre classe :";
            // 
            // btnAddElTemp
            // 
            this.btnAddElTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnAddElTemp.Enabled = false;
            this.btnAddElTemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddElTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnAddElTemp.Location = new System.Drawing.Point(8, 50);
            this.btnAddElTemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddElTemp.Name = "btnAddElTemp";
            this.btnAddElTemp.Size = new System.Drawing.Size(183, 59);
            this.btnAddElTemp.TabIndex = 16;
            this.btnAddElTemp.Text = "➕ Créer un élève temporaire";
            this.btnAddElTemp.UseVisualStyleBackColor = false;
            this.btnAddElTemp.Click += new System.EventHandler(this.btnAddElTemp_Click);
            // 
            // listBoxElTemp
            // 
            this.listBoxElTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.listBoxElTemp.ForeColor = System.Drawing.Color.White;
            this.listBoxElTemp.FormattingEnabled = true;
            this.listBoxElTemp.ItemHeight = 16;
            this.listBoxElTemp.Location = new System.Drawing.Point(8, 181);
            this.listBoxElTemp.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxElTemp.Name = "listBoxElTemp";
            this.listBoxElTemp.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxElTemp.Size = new System.Drawing.Size(184, 404);
            this.listBoxElTemp.Sorted = true;
            this.listBoxElTemp.TabIndex = 13;
            this.listBoxElTemp.SelectedIndexChanged += new System.EventHandler(this.listBoxElTemp_SelectedIndexChanged);
            // 
            // btnDelElTemp
            // 
            this.btnDelElTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnDelElTemp.Enabled = false;
            this.btnDelElTemp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelElTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnDelElTemp.Location = new System.Drawing.Point(8, 113);
            this.btnDelElTemp.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelElTemp.Name = "btnDelElTemp";
            this.btnDelElTemp.Size = new System.Drawing.Size(183, 64);
            this.btnDelElTemp.TabIndex = 19;
            this.btnDelElTemp.Text = "🗑 Suppr. un élève temporaire";
            this.btnDelElTemp.UseVisualStyleBackColor = false;
            this.btnDelElTemp.Click += new System.EventHandler(this.btnDelElTemp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.button1.Location = new System.Drawing.Point(503, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 61);
            this.button1.TabIndex = 27;
            this.button1.Text = "❌ Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModifClassesTemporaires
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(857, 762);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCsvNouvelleAnnee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmModifClassesTemporaires";
            this.Text = "Modifier les classes nouvelle année";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCsvNouvelleAnnee;
        private System.Windows.Forms.Button btnAddClasseTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelClasseTemp;
        private System.Windows.Forms.ListBox listBoxClassesTemp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDeplacement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddElTemp;
        private System.Windows.Forms.ListBox listBoxElTemp;
        private System.Windows.Forms.Button btnDelElTemp;
        private System.Windows.Forms.Button button1;
    }
}