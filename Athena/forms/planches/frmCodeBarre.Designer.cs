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
    partial class frmCodeBarre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeBarre));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb5eme = new System.Windows.Forms.RadioButton();
            this.rdbTout = new System.Windows.Forms.RadioButton();
            this.rdb3eme = new System.Windows.Forms.RadioButton();
            this.rdb4eme = new System.Windows.Forms.RadioButton();
            this.rdb6eme = new System.Windows.Forms.RadioButton();
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
            this.pbCodeBarre = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.gbpElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodeBarre)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox1.Controls.Add(this.rdb5eme);
            this.groupBox1.Controls.Add(this.rdbTout);
            this.groupBox1.Controls.Add(this.rdb3eme);
            this.groupBox1.Controls.Add(this.rdb4eme);
            this.groupBox1.Controls.Add(this.rdb6eme);
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
            // rdb5eme
            // 
            this.rdb5eme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb5eme.Location = new System.Drawing.Point(44, 144);
            this.rdb5eme.Margin = new System.Windows.Forms.Padding(4);
            this.rdb5eme.Name = "rdb5eme";
            this.rdb5eme.Size = new System.Drawing.Size(125, 27);
            this.rdb5eme.TabIndex = 4;
            this.rdb5eme.Text = "5eme";
            this.rdb5eme.UseVisualStyleBackColor = true;
            this.rdb5eme.CheckedChanged += new System.EventHandler(this.rdb5eme_CheckedChanged);
            // 
            // rdbTout
            // 
            this.rdbTout.Checked = true;
            this.rdbTout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTout.Location = new System.Drawing.Point(44, 54);
            this.rdbTout.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTout.Name = "rdbTout";
            this.rdbTout.Size = new System.Drawing.Size(169, 27);
            this.rdbTout.TabIndex = 3;
            this.rdbTout.TabStop = true;
            this.rdbTout.Text = "tous les niveaux";
            this.rdbTout.UseVisualStyleBackColor = true;
            this.rdbTout.CheckedChanged += new System.EventHandler(this.rdbTout_CheckedChanged);
            // 
            // rdb3eme
            // 
            this.rdb3eme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3eme.Location = new System.Drawing.Point(44, 234);
            this.rdb3eme.Margin = new System.Windows.Forms.Padding(4);
            this.rdb3eme.Name = "rdb3eme";
            this.rdb3eme.Size = new System.Drawing.Size(125, 27);
            this.rdb3eme.TabIndex = 2;
            this.rdb3eme.Text = "3eme";
            this.rdb3eme.UseVisualStyleBackColor = true;
            this.rdb3eme.CheckedChanged += new System.EventHandler(this.rdb3eme_CheckedChanged);
            // 
            // rdb4eme
            // 
            this.rdb4eme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb4eme.Location = new System.Drawing.Point(44, 189);
            this.rdb4eme.Margin = new System.Windows.Forms.Padding(4);
            this.rdb4eme.Name = "rdb4eme";
            this.rdb4eme.Size = new System.Drawing.Size(125, 27);
            this.rdb4eme.TabIndex = 1;
            this.rdb4eme.Text = "4eme";
            this.rdb4eme.UseVisualStyleBackColor = true;
            this.rdb4eme.CheckedChanged += new System.EventHandler(this.rdb4eme_CheckedChanged);
            // 
            // rdb6eme
            // 
            this.rdb6eme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb6eme.Location = new System.Drawing.Point(44, 99);
            this.rdb6eme.Margin = new System.Windows.Forms.Padding(4);
            this.rdb6eme.Name = "rdb6eme";
            this.rdb6eme.Size = new System.Drawing.Size(125, 27);
            this.rdb6eme.TabIndex = 0;
            this.rdb6eme.Text = "6eme";
            this.rdb6eme.UseVisualStyleBackColor = true;
            this.rdb6eme.CheckedChanged += new System.EventHandler(this.rdb6eme_CheckedChanged);
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
            this.lblCount.Text = "none";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnValider.Location = new System.Drawing.Point(1119, 588);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.MaximumSize = new System.Drawing.Size(171, 55);
            this.btnValider.MinimumSize = new System.Drawing.Size(171, 55);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(171, 55);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
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
            this.pbPhoto.Location = new System.Drawing.Point(1120, 54);
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
            this.clbElements.Size = new System.Drawing.Size(600, 599);
            this.clbElements.TabIndex = 0;
            this.clbElements.SelectedIndexChanged += new System.EventHandler(this.clbElements_SelectedIndexChanged);
            // 
            // btnToutSelectionner
            // 
            this.btnToutSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnToutSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToutSelectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnToutSelectionner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnToutSelectionner.Location = new System.Drawing.Point(1119, 526);
            this.btnToutSelectionner.Name = "btnToutSelectionner";
            this.btnToutSelectionner.Size = new System.Drawing.Size(171, 55);
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
            this.btnReinitialiser.Location = new System.Drawing.Point(1119, 450);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(171, 70);
            this.btnReinitialiser.TabIndex = 12;
            this.btnReinitialiser.Text = "Réinitialiser la sélection";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // pbCodeBarre
            // 
            this.pbCodeBarre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbCodeBarre.Location = new System.Drawing.Point(1069, 304);
            this.pbCodeBarre.Name = "pbCodeBarre";
            this.pbCodeBarre.Size = new System.Drawing.Size(269, 122);
            this.pbCodeBarre.TabIndex = 21;
            this.pbCodeBarre.TabStop = false;
            // 
            // frmCodeBarre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1356, 662);
            this.Controls.Add(this.pbCodeBarre);
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
            this.Name = "frmCodeBarre";
            this.Text = "Athena - Code Barre d\'Eleves";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCodeBarre_FormClosed);
            this.Load += new System.EventHandler(this.frmCodeBarre_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.gbpElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCodeBarre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb5eme;
        private System.Windows.Forms.RadioButton rdbTout;
        private System.Windows.Forms.RadioButton rdb3eme;
        private System.Windows.Forms.RadioButton rdb4eme;
        private System.Windows.Forms.RadioButton rdb6eme;
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
        private System.Windows.Forms.PictureBox pbCodeBarre;
    }
}