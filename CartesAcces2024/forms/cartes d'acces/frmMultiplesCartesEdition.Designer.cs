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
    partial class FrmMultiplesCartesEdition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMultiplesCartesEdition));
            this.pnlEdtPhoto = new System.Windows.Forms.Panel();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.pbCarteArriere = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.labelEnCoursValidation = new System.Windows.Forms.Label();
            this.btnValiderImpr = new System.Windows.Forms.Button();
            this.tkbTaillePhoto = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCompteur = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1_compteur = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbA5 = new System.Windows.Forms.RadioButton();
            this.rdbA4 = new System.Windows.Forms.RadioButton();
            this.pnlEdtPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarteArriere)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTaillePhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEdtPhoto
            // 
            this.pnlEdtPhoto.Controls.Add(this.pbPhoto);
            this.pnlEdtPhoto.Controls.Add(this.pbCarteArriere);
            this.pnlEdtPhoto.Location = new System.Drawing.Point(16, 15);
            this.pnlEdtPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEdtPhoto.Name = "pnlEdtPhoto";
            this.pnlEdtPhoto.Size = new System.Drawing.Size(720, 457);
            this.pnlEdtPhoto.TabIndex = 14;
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(297, 255);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(112, 121);
            this.pbPhoto.TabIndex = 10;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Visible = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            this.pbPhoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPhoto_MouseDown);
            this.pbPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPhoto_MouseMove);
            this.pbPhoto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPhoto_MouseUp);
            // 
            // pbCarteArriere
            // 
            this.pbCarteArriere.Location = new System.Drawing.Point(0, 0);
            this.pbCarteArriere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCarteArriere.Name = "pbCarteArriere";
            this.pbCarteArriere.Size = new System.Drawing.Size(720, 457);
            this.pbCarteArriere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarteArriere.TabIndex = 7;
            this.pbCarteArriere.TabStop = false;
            this.pbCarteArriere.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCarteArriere_MouseDown);
            this.pbCarteArriere.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCarteArriere_MouseMove);
            this.pbCarteArriere.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCarteArriere_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox3.Controls.Add(this.btnOpenFolder);
            this.groupBox3.Controls.Add(this.labelEnCoursValidation);
            this.groupBox3.Controls.Add(this.btnValiderImpr);
            this.groupBox3.Controls.Add(this.tkbTaillePhoto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(744, 172);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(687, 300);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajout et Edition Photo";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnOpenFolder.Location = new System.Drawing.Point(390, 225);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(141, 67);
            this.btnOpenFolder.TabIndex = 16;
            this.btnOpenFolder.Text = "📁 &Ouvrir le dossier d\'enregistrement";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // labelEnCoursValidation
            // 
            this.labelEnCoursValidation.AutoSize = true;
            this.labelEnCoursValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnCoursValidation.ForeColor = System.Drawing.Color.Red;
            this.labelEnCoursValidation.Location = new System.Drawing.Point(3, 234);
            this.labelEnCoursValidation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnCoursValidation.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelEnCoursValidation.Name = "labelEnCoursValidation";
            this.labelEnCoursValidation.Size = new System.Drawing.Size(389, 50);
            this.labelEnCoursValidation.TabIndex = 17;
            this.labelEnCoursValidation.Text = "En cours, veuillez attendre le message de validation";
            this.labelEnCoursValidation.Click += new System.EventHandler(this.labelEnCoursValidation_Click);
            // 
            // btnValiderImpr
            // 
            this.btnValiderImpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnValiderImpr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValiderImpr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnValiderImpr.Location = new System.Drawing.Point(538, 225);
            this.btnValiderImpr.Margin = new System.Windows.Forms.Padding(4);
            this.btnValiderImpr.Name = "btnValiderImpr";
            this.btnValiderImpr.Size = new System.Drawing.Size(140, 67);
            this.btnValiderImpr.TabIndex = 16;
            this.btnValiderImpr.Text = "💾 &Créer les fichiers à imprimer";
            this.btnValiderImpr.UseVisualStyleBackColor = false;
            this.btnValiderImpr.Click += new System.EventHandler(this.btnValiderImpr_Click);
            // 
            // tkbTaillePhoto
            // 
            this.tkbTaillePhoto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tkbTaillePhoto.Location = new System.Drawing.Point(100, 58);
            this.tkbTaillePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.tkbTaillePhoto.Maximum = 300;
            this.tkbTaillePhoto.Minimum = 30;
            this.tkbTaillePhoto.Name = "tkbTaillePhoto";
            this.tkbTaillePhoto.Size = new System.Drawing.Size(563, 56);
            this.tkbTaillePhoto.TabIndex = 7;
            this.tkbTaillePhoto.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbTaillePhoto.UseWaitCursor = true;
            this.tkbTaillePhoto.Value = 130;
            this.tkbTaillePhoto.Scroll += new System.EventHandler(this.tkbTaillePhoto_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Taille";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Redefinir la taille";
            // 
            // lblCompteur
            // 
            this.lblCompteur.AutoSize = true;
            this.lblCompteur.Enabled = false;
            this.lblCompteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompteur.ForeColor = System.Drawing.Color.White;
            this.lblCompteur.Location = new System.Drawing.Point(213, 10);
            this.lblCompteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompteur.Name = "lblCompteur";
            this.lblCompteur.Size = new System.Drawing.Size(50, 29);
            this.lblCompteur.TabIndex = 18;
            this.lblCompteur.Text = "0%";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox2.Controls.Add(this.progressBar1_compteur);
            this.groupBox2.Controls.Add(this.lblCompteur);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(744, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(687, 85);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edition Emploi du Temps";
            // 
            // progressBar1_compteur
            // 
            this.progressBar1_compteur.Enabled = false;
            this.progressBar1_compteur.Location = new System.Drawing.Point(212, 42);
            this.progressBar1_compteur.Name = "progressBar1_compteur";
            this.progressBar1_compteur.Size = new System.Drawing.Size(225, 23);
            this.progressBar1_compteur.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1_compteur.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnCancel.Location = new System.Drawing.Point(450, 23);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "❌ &Annuler le rognagne";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnSelect.Location = new System.Drawing.Point(8, 23);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(197, 50);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "✂ &Sélectionnez la zone à rogner";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox1.Controls.Add(this.rdbA5);
            this.groupBox1.Controls.Add(this.rdbA4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(744, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 58);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format de l\'impression";
            // 
            // rdbA5
            // 
            this.rdbA5.AutoSize = true;
            this.rdbA5.Location = new System.Drawing.Point(430, 21);
            this.rdbA5.Name = "rdbA5";
            this.rdbA5.Size = new System.Drawing.Size(46, 21);
            this.rdbA5.TabIndex = 1;
            this.rdbA5.Text = "A5";
            this.rdbA5.UseVisualStyleBackColor = true;
            // 
            // rdbA4
            // 
            this.rdbA4.AutoSize = true;
            this.rdbA4.Checked = true;
            this.rdbA4.Location = new System.Drawing.Point(179, 21);
            this.rdbA4.Name = "rdbA4";
            this.rdbA4.Size = new System.Drawing.Size(46, 21);
            this.rdbA4.TabIndex = 0;
            this.rdbA4.TabStop = true;
            this.rdbA4.Text = "A4";
            this.rdbA4.UseVisualStyleBackColor = true;
            // 
            // FrmMultiplesCartesEdition
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1446, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlEdtPhoto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMultiplesCartesEdition";
            this.Text = "Athena - Création des fichier a imprimer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMultipleCartesEdition_FormClosed);
            this.Load += new System.EventHandler(this.frmMultiplesCartesEdition_Load);
            this.pnlEdtPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarteArriere)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTaillePhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblCompteur;

        #endregion

        private System.Windows.Forms.Panel pnlEdtPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.PictureBox pbCarteArriere;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tkbTaillePhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnValiderImpr;
        private System.Windows.Forms.Label labelEnCoursValidation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbA5;
        private System.Windows.Forms.RadioButton rdbA4;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.ProgressBar progressBar1_compteur;
    }
}