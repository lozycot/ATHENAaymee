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
    partial class frmCartesParListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartesParListe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ceme = new System.Windows.Forms.RadioButton();
            this.tout = new System.Windows.Forms.RadioButton();
            this.Teme = new System.Windows.Forms.RadioButton();
            this.Qeme = new System.Windows.Forms.RadioButton();
            this.Seme = new System.Windows.Forms.RadioButton();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.Impression = new System.Windows.Forms.ListBox();
            this.Eleves = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox1.Controls.Add(this.Ceme);
            this.groupBox1.Controls.Add(this.tout);
            this.groupBox1.Controls.Add(this.Teme);
            this.groupBox1.Controls.Add(this.Qeme);
            this.groupBox1.Controls.Add(this.Seme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(407, 568);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre de recherche par niveau";
            // 
            // Ceme
            // 
            this.Ceme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ceme.Location = new System.Drawing.Point(31, 88);
            this.Ceme.Margin = new System.Windows.Forms.Padding(4);
            this.Ceme.Name = "Ceme";
            this.Ceme.Size = new System.Drawing.Size(125, 27);
            this.Ceme.TabIndex = 4;
            this.Ceme.Text = "5eme";
            this.Ceme.UseVisualStyleBackColor = true;
            // 
            // tout
            // 
            this.tout.Checked = true;
            this.tout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tout.Location = new System.Drawing.Point(31, 223);
            this.tout.Margin = new System.Windows.Forms.Padding(4);
            this.tout.Name = "tout";
            this.tout.Size = new System.Drawing.Size(169, 27);
            this.tout.TabIndex = 3;
            this.tout.TabStop = true;
            this.tout.Text = "tous les niveaux";
            this.tout.UseVisualStyleBackColor = true;
            // 
            // Teme
            // 
            this.Teme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teme.Location = new System.Drawing.Point(31, 178);
            this.Teme.Margin = new System.Windows.Forms.Padding(4);
            this.Teme.Name = "Teme";
            this.Teme.Size = new System.Drawing.Size(125, 27);
            this.Teme.TabIndex = 2;
            this.Teme.Text = "3eme";
            this.Teme.UseVisualStyleBackColor = true;
            // 
            // Qeme
            // 
            this.Qeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qeme.Location = new System.Drawing.Point(31, 133);
            this.Qeme.Margin = new System.Windows.Forms.Padding(4);
            this.Qeme.Name = "Qeme";
            this.Qeme.Size = new System.Drawing.Size(125, 27);
            this.Qeme.TabIndex = 1;
            this.Qeme.Text = "4eme";
            this.Qeme.UseVisualStyleBackColor = true;
            // 
            // Seme
            // 
            this.Seme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seme.Location = new System.Drawing.Point(31, 43);
            this.Seme.Margin = new System.Windows.Forms.Padding(4);
            this.Seme.Name = "Seme";
            this.Seme.Size = new System.Drawing.Size(125, 27);
            this.Seme.TabIndex = 0;
            this.Seme.Text = "6eme";
            this.Seme.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.BackColor = System.Drawing.Color.White;
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(154, 41);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(270, 26);
            this.txtRecherche.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rechercher : ";
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(182, 9);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(133, 28);
            this.lblCount.TabIndex = 15;
            this.lblCount.Text = "none";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnValider.Location = new System.Drawing.Point(1255, 588);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.MaximumSize = new System.Drawing.Size(171, 55);
            this.btnValider.MinimumSize = new System.Drawing.Size(171, 55);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(171, 55);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // btnRetirer
            // 
            this.btnRetirer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnRetirer.Location = new System.Drawing.Point(1255, 525);
            this.btnRetirer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetirer.MaximumSize = new System.Drawing.Size(171, 55);
            this.btnRetirer.MinimumSize = new System.Drawing.Size(171, 55);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(171, 55);
            this.btnRetirer.TabIndex = 13;
            this.btnRetirer.Text = "<= Retirer";
            this.btnRetirer.UseVisualStyleBackColor = false;
            // 
            // btnAjout
            // 
            this.btnAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnAjout.Location = new System.Drawing.Point(1255, 462);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjout.MaximumSize = new System.Drawing.Size(171, 55);
            this.btnAjout.MinimumSize = new System.Drawing.Size(171, 55);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(171, 55);
            this.btnAjout.TabIndex = 12;
            this.btnAjout.Text = "Ajouter =>";
            this.btnAjout.UseVisualStyleBackColor = false;
            // 
            // Impression
            // 
            this.Impression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Impression.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Impression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impression.ForeColor = System.Drawing.Color.White;
            this.Impression.FormattingEnabled = true;
            this.Impression.ItemHeight = 20;
            this.Impression.Location = new System.Drawing.Point(843, 43);
            this.Impression.Margin = new System.Windows.Forms.Padding(4);
            this.Impression.MaximumSize = new System.Drawing.Size(399, 614);
            this.Impression.MinimumSize = new System.Drawing.Size(399, 614);
            this.Impression.Name = "Impression";
            this.Impression.Size = new System.Drawing.Size(399, 602);
            this.Impression.TabIndex = 11;
            // 
            // Eleves
            // 
            this.Eleves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Eleves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Eleves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eleves.ForeColor = System.Drawing.Color.White;
            this.Eleves.FormattingEnabled = true;
            this.Eleves.ItemHeight = 20;
            this.Eleves.Location = new System.Drawing.Point(436, 41);
            this.Eleves.Margin = new System.Windows.Forms.Padding(4);
            this.Eleves.MaximumSize = new System.Drawing.Size(399, 614);
            this.Eleves.MinimumSize = new System.Drawing.Size(399, 614);
            this.Eleves.Name = "Eleves";
            this.Eleves.Size = new System.Drawing.Size(399, 602);
            this.Eleves.TabIndex = 10;
            this.Eleves.SelectedIndexChanged += new System.EventHandler(this.Eleves_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre d\'élèves :";
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbPhoto.Location = new System.Drawing.Point(1255, 57);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPhoto.MaximumSize = new System.Drawing.Size(171, 223);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(171, 223);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPhoto.TabIndex = 20;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Élèves non sélectionnés :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(839, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Élèves sélectionnés :";
            // 
            // frmCartesParListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1439, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnRetirer);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.Impression);
            this.Controls.Add(this.Eleves);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCartesParListe";
            this.Text = "Athena - Carte par liste";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCartesParListe_FormClosed);
            this.Load += new System.EventHandler(this.frmCartesParListe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ceme;
        private System.Windows.Forms.RadioButton tout;
        private System.Windows.Forms.RadioButton Teme;
        private System.Windows.Forms.RadioButton Qeme;
        private System.Windows.Forms.RadioButton Seme;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.ListBox Impression;
        private System.Windows.Forms.ListBox Eleves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}