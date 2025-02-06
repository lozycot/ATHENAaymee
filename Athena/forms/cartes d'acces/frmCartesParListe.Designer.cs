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
            this.cbxNiveau3eme = new System.Windows.Forms.CheckBox();
            this.cbxNiveau4eme = new System.Windows.Forms.CheckBox();
            this.cbxNiveau6eme = new System.Windows.Forms.CheckBox();
            this.cbxNiveau5eme = new System.Windows.Forms.CheckBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.gbpElements = new System.Windows.Forms.GroupBox();
            this.clbElements = new System.Windows.Forms.CheckedListBox();
            this.btnToutSelectionner = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.gbpRecherche = new System.Windows.Forms.GroupBox();
            this.lbRecherche = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.gbpElements.SuspendLayout();
            this.gbpRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox1.Controls.Add(this.cbxNiveau3eme);
            this.groupBox1.Controls.Add(this.cbxNiveau4eme);
            this.groupBox1.Controls.Add(this.cbxNiveau6eme);
            this.groupBox1.Controls.Add(this.cbxNiveau5eme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(407, 339);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre de recherche par niveau";
            // 
            // cbxNiveau3eme
            // 
            this.cbxNiveau3eme.AutoSize = true;
            this.cbxNiveau3eme.Location = new System.Drawing.Point(160, 258);
            this.cbxNiveau3eme.Name = "cbxNiveau3eme";
            this.cbxNiveau3eme.Size = new System.Drawing.Size(76, 24);
            this.cbxNiveau3eme.TabIndex = 25;
            this.cbxNiveau3eme.Text = "3eme";
            this.cbxNiveau3eme.UseVisualStyleBackColor = true;
            this.cbxNiveau3eme.CheckedChanged += new System.EventHandler(this.cbxNiveau3eme_CheckedChanged);
            // 
            // cbxNiveau4eme
            // 
            this.cbxNiveau4eme.AutoSize = true;
            this.cbxNiveau4eme.Location = new System.Drawing.Point(160, 198);
            this.cbxNiveau4eme.Name = "cbxNiveau4eme";
            this.cbxNiveau4eme.Size = new System.Drawing.Size(76, 24);
            this.cbxNiveau4eme.TabIndex = 24;
            this.cbxNiveau4eme.Text = "4eme";
            this.cbxNiveau4eme.UseVisualStyleBackColor = true;
            this.cbxNiveau4eme.CheckedChanged += new System.EventHandler(this.cbxNiveau4eme_CheckedChanged);
            // 
            // cbxNiveau6eme
            // 
            this.cbxNiveau6eme.AutoSize = true;
            this.cbxNiveau6eme.Location = new System.Drawing.Point(160, 78);
            this.cbxNiveau6eme.Name = "cbxNiveau6eme";
            this.cbxNiveau6eme.Size = new System.Drawing.Size(76, 24);
            this.cbxNiveau6eme.TabIndex = 22;
            this.cbxNiveau6eme.Text = "6eme";
            this.cbxNiveau6eme.UseVisualStyleBackColor = true;
            this.cbxNiveau6eme.CheckedChanged += new System.EventHandler(this.cbxNiveau6eme_CheckedChanged);
            // 
            // cbxNiveau5eme
            // 
            this.cbxNiveau5eme.AutoSize = true;
            this.cbxNiveau5eme.Location = new System.Drawing.Point(160, 138);
            this.cbxNiveau5eme.Name = "cbxNiveau5eme";
            this.cbxNiveau5eme.Size = new System.Drawing.Size(76, 24);
            this.cbxNiveau5eme.TabIndex = 23;
            this.cbxNiveau5eme.Text = "5eme";
            this.cbxNiveau5eme.UseVisualStyleBackColor = true;
            this.cbxNiveau5eme.CheckedChanged += new System.EventHandler(this.cbxNiveau5eme_CheckedChanged);
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
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
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
            this.lblCount.Text = "aucun";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnValider.Location = new System.Drawing.Point(1063, 588);
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
            this.pbPhoto.Location = new System.Drawing.Point(1063, 57);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPhoto.MaximumSize = new System.Drawing.Size(171, 223);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(171, 223);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPhoto.TabIndex = 20;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // gbpElements
            // 
            this.gbpElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbpElements.Controls.Add(this.clbElements);
            this.gbpElements.ForeColor = System.Drawing.Color.White;
            this.gbpElements.Location = new System.Drawing.Point(436, 12);
            this.gbpElements.Name = "gbpElements";
            this.gbpElements.Size = new System.Drawing.Size(614, 631);
            this.gbpElements.TabIndex = 9;
            this.gbpElements.TabStop = false;
            this.gbpElements.Text = "TexteElementFiltre";
            // 
            // clbElements
            // 
            this.clbElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.clbElements.CheckOnClick = true;
            this.clbElements.ForeColor = System.Drawing.Color.White;
            this.clbElements.FormattingEnabled = true;
            this.clbElements.Location = new System.Drawing.Point(6, 21);
            this.clbElements.Name = "clbElements";
            this.clbElements.Size = new System.Drawing.Size(600, 582);
            this.clbElements.TabIndex = 0;
            this.clbElements.SelectedIndexChanged += new System.EventHandler(this.clbElements_SelectedIndexChanged);
            // 
            // btnToutSelectionner
            // 
            this.btnToutSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnToutSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToutSelectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnToutSelectionner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnToutSelectionner.Location = new System.Drawing.Point(1063, 511);
            this.btnToutSelectionner.Name = "btnToutSelectionner";
            this.btnToutSelectionner.Size = new System.Drawing.Size(171, 70);
            this.btnToutSelectionner.TabIndex = 13;
            this.btnToutSelectionner.Text = "Tout sélectionner";
            this.btnToutSelectionner.UseVisualStyleBackColor = false;
            this.btnToutSelectionner.Click += new System.EventHandler(this.btnToutSelectionner_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReinitialiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnReinitialiser.Location = new System.Drawing.Point(1063, 435);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(171, 70);
            this.btnReinitialiser.TabIndex = 12;
            this.btnReinitialiser.Text = "Réinitialiser la sélection";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // gbpRecherche
            // 
            this.gbpRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbpRecherche.Controls.Add(this.lbRecherche);
            this.gbpRecherche.ForeColor = System.Drawing.Color.White;
            this.gbpRecherche.Location = new System.Drawing.Point(17, 74);
            this.gbpRecherche.Name = "gbpRecherche";
            this.gbpRecherche.Size = new System.Drawing.Size(407, 223);
            this.gbpRecherche.TabIndex = 21;
            this.gbpRecherche.TabStop = false;
            this.gbpRecherche.Text = "Resultat de la Recherche";
            // 
            // lbRecherche
            // 
            this.lbRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lbRecherche.ForeColor = System.Drawing.Color.White;
            this.lbRecherche.FormattingEnabled = true;
            this.lbRecherche.ItemHeight = 16;
            this.lbRecherche.Location = new System.Drawing.Point(8, 20);
            this.lbRecherche.Name = "lbRecherche";
            this.lbRecherche.Size = new System.Drawing.Size(392, 196);
            this.lbRecherche.TabIndex = 1;
            this.lbRecherche.SelectedIndexChanged += new System.EventHandler(this.lbRecherche_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.button1.Location = new System.Drawing.Point(1107, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 41;
            this.button1.Text = "&Tutoriel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCartesParListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1251, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbpRecherche);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.btnToutSelectionner);
            this.Controls.Add(this.gbpElements);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCartesParListe";
            this.Text = "Athena - Carte par liste";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCartesParListe_FormClosed);
            this.Load += new System.EventHandler(this.frmCartesParListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.gbpElements.ResumeLayout(false);
            this.gbpRecherche.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.GroupBox gbpElements;
        private System.Windows.Forms.CheckedListBox clbElements;
        private System.Windows.Forms.Button btnToutSelectionner;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.GroupBox gbpRecherche;
        private System.Windows.Forms.ListBox lbRecherche;
        private System.Windows.Forms.CheckBox cbxNiveau3eme;
        private System.Windows.Forms.CheckBox cbxNiveau4eme;
        private System.Windows.Forms.CheckBox cbxNiveau6eme;
        private System.Windows.Forms.CheckBox cbxNiveau5eme;
        private System.Windows.Forms.Button button1;
    }
}

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