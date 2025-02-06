namespace CartesAcces2024
{
    partial class frmCarteParClasseNiveau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarteParClasseNiveau));
            this.btnValiderImpr = new System.Windows.Forms.Button();
            this.lsbListeEleve = new System.Windows.Forms.ListBox();
            this.NbComptageEleveCS = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxTriParNiveau = new System.Windows.Forms.GroupBox();
            this.cbxNiveau3eme = new System.Windows.Forms.CheckBox();
            this.cbxNiveau4eme = new System.Windows.Forms.CheckBox();
            this.cbxNiveau5eme = new System.Windows.Forms.CheckBox();
            this.cbxNiveau6eme = new System.Windows.Forms.CheckBox();
            this.clbClasse6eme = new System.Windows.Forms.CheckedListBox();
            this.clbClasse5eme = new System.Windows.Forms.CheckedListBox();
            this.clbClasse4eme = new System.Windows.Forms.CheckedListBox();
            this.clbClasse3eme = new System.Windows.Forms.CheckedListBox();
            this.gpbTriParClasses = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.gbxTriParNiveau.SuspendLayout();
            this.gpbTriParClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValiderImpr
            // 
            this.btnValiderImpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnValiderImpr.Enabled = false;
            this.btnValiderImpr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValiderImpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnValiderImpr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnValiderImpr.Location = new System.Drawing.Point(1184, 614);
            this.btnValiderImpr.MaximumSize = new System.Drawing.Size(300, 70);
            this.btnValiderImpr.MinimumSize = new System.Drawing.Size(300, 70);
            this.btnValiderImpr.Name = "btnValiderImpr";
            this.btnValiderImpr.Size = new System.Drawing.Size(300, 70);
            this.btnValiderImpr.TabIndex = 6;
            this.btnValiderImpr.Text = "&Valider la liste à imprimer";
            this.btnValiderImpr.UseVisualStyleBackColor = false;
            this.btnValiderImpr.Click += new System.EventHandler(this.btnValiderImpr_Click);
            // 
            // lsbListeEleve
            // 
            this.lsbListeEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lsbListeEleve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbListeEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lsbListeEleve.ForeColor = System.Drawing.Color.White;
            this.lsbListeEleve.FormattingEnabled = true;
            this.lsbListeEleve.ItemHeight = 20;
            this.lsbListeEleve.Location = new System.Drawing.Point(808, 82);
            this.lsbListeEleve.Name = "lsbListeEleve";
            this.lsbListeEleve.Size = new System.Drawing.Size(346, 602);
            this.lsbListeEleve.TabIndex = 7;
            this.lsbListeEleve.SelectedIndexChanged += new System.EventHandler(this.lsbListeEleve_SelectedIndexChanged);
            // 
            // NbComptageEleveCS
            // 
            this.NbComptageEleveCS.AutoSize = true;
            this.NbComptageEleveCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NbComptageEleveCS.ForeColor = System.Drawing.Color.White;
            this.NbComptageEleveCS.Location = new System.Drawing.Point(35, 36);
            this.NbComptageEleveCS.Name = "NbComptageEleveCS";
            this.NbComptageEleveCS.Size = new System.Drawing.Size(149, 20);
            this.NbComptageEleveCS.TabIndex = 25;
            this.NbComptageEleveCS.Text = "Nombre d\'élèves : ";
            this.NbComptageEleveCS.Click += new System.EventHandler(this.NbComptageEleveCS_Click);
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(255, 36);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(112, 43);
            this.lblCount.TabIndex = 27;
            this.lblCount.Text = "None";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbPhoto.Location = new System.Drawing.Point(1218, 95);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(233, 305);
            this.pbPhoto.TabIndex = 31;
            this.pbPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(803, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Liste à imprimer :";
            // 
            // gbxTriParNiveau
            // 
            this.gbxTriParNiveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gbxTriParNiveau.Controls.Add(this.cbxNiveau3eme);
            this.gbxTriParNiveau.Controls.Add(this.cbxNiveau4eme);
            this.gbxTriParNiveau.Controls.Add(this.cbxNiveau5eme);
            this.gbxTriParNiveau.Controls.Add(this.cbxNiveau6eme);
            this.gbxTriParNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTriParNiveau.ForeColor = System.Drawing.Color.White;
            this.gbxTriParNiveau.Location = new System.Drawing.Point(40, 88);
            this.gbxTriParNiveau.Name = "gbxTriParNiveau";
            this.gbxTriParNiveau.Size = new System.Drawing.Size(743, 123);
            this.gbxTriParNiveau.TabIndex = 35;
            this.gbxTriParNiveau.TabStop = false;
            this.gbxTriParNiveau.Text = "Recherche par niveaux : ";
            this.gbxTriParNiveau.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxNiveau3eme
            // 
            this.cbxNiveau3eme.AutoSize = true;
            this.cbxNiveau3eme.Location = new System.Drawing.Point(593, 56);
            this.cbxNiveau3eme.Name = "cbxNiveau3eme";
            this.cbxNiveau3eme.Size = new System.Drawing.Size(65, 21);
            this.cbxNiveau3eme.TabIndex = 3;
            this.cbxNiveau3eme.Text = "3eme";
            this.cbxNiveau3eme.UseVisualStyleBackColor = true;
            this.cbxNiveau3eme.CheckedChanged += new System.EventHandler(this.cbxNiveau3eme_CheckedChanged);
            // 
            // cbxNiveau4eme
            // 
            this.cbxNiveau4eme.AutoSize = true;
            this.cbxNiveau4eme.Location = new System.Drawing.Point(424, 56);
            this.cbxNiveau4eme.Name = "cbxNiveau4eme";
            this.cbxNiveau4eme.Size = new System.Drawing.Size(65, 21);
            this.cbxNiveau4eme.TabIndex = 2;
            this.cbxNiveau4eme.Text = "4eme";
            this.cbxNiveau4eme.UseVisualStyleBackColor = true;
            this.cbxNiveau4eme.CheckedChanged += new System.EventHandler(this.cbxNiveau4eme_CheckedChanged);
            // 
            // cbxNiveau5eme
            // 
            this.cbxNiveau5eme.AutoSize = true;
            this.cbxNiveau5eme.Location = new System.Drawing.Point(248, 56);
            this.cbxNiveau5eme.Name = "cbxNiveau5eme";
            this.cbxNiveau5eme.Size = new System.Drawing.Size(65, 21);
            this.cbxNiveau5eme.TabIndex = 1;
            this.cbxNiveau5eme.Text = "5eme";
            this.cbxNiveau5eme.UseVisualStyleBackColor = true;
            this.cbxNiveau5eme.CheckedChanged += new System.EventHandler(this.cbxNiveau5eme_CheckedChanged);
            // 
            // cbxNiveau6eme
            // 
            this.cbxNiveau6eme.AutoSize = true;
            this.cbxNiveau6eme.Location = new System.Drawing.Point(68, 56);
            this.cbxNiveau6eme.Name = "cbxNiveau6eme";
            this.cbxNiveau6eme.Size = new System.Drawing.Size(65, 21);
            this.cbxNiveau6eme.TabIndex = 0;
            this.cbxNiveau6eme.Text = "6eme";
            this.cbxNiveau6eme.UseVisualStyleBackColor = true;
            this.cbxNiveau6eme.CheckedChanged += new System.EventHandler(this.cbxNiveau6eme_CheckedChanged);
            // 
            // clbClasse6eme
            // 
            this.clbClasse6eme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clbClasse6eme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbClasse6eme.CheckOnClick = true;
            this.clbClasse6eme.ForeColor = System.Drawing.SystemColors.Window;
            this.clbClasse6eme.FormattingEnabled = true;
            this.clbClasse6eme.Location = new System.Drawing.Point(29, 45);
            this.clbClasse6eme.Name = "clbClasse6eme";
            this.clbClasse6eme.Size = new System.Drawing.Size(167, 391);
            this.clbClasse6eme.TabIndex = 0;
            this.clbClasse6eme.SelectedIndexChanged += new System.EventHandler(this.clbClasses_SelectedIndexChanged);
            // 
            // clbClasse5eme
            // 
            this.clbClasse5eme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clbClasse5eme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbClasse5eme.CheckOnClick = true;
            this.clbClasse5eme.ForeColor = System.Drawing.SystemColors.Window;
            this.clbClasse5eme.FormattingEnabled = true;
            this.clbClasse5eme.Location = new System.Drawing.Point(202, 45);
            this.clbClasse5eme.Name = "clbClasse5eme";
            this.clbClasse5eme.Size = new System.Drawing.Size(167, 391);
            this.clbClasse5eme.TabIndex = 36;
            this.clbClasse5eme.SelectedIndexChanged += new System.EventHandler(this.clbClasse5eme_SelectedIndexChanged);
            // 
            // clbClasse4eme
            // 
            this.clbClasse4eme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clbClasse4eme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbClasse4eme.CheckOnClick = true;
            this.clbClasse4eme.ForeColor = System.Drawing.SystemColors.Window;
            this.clbClasse4eme.FormattingEnabled = true;
            this.clbClasse4eme.Location = new System.Drawing.Point(375, 45);
            this.clbClasse4eme.Name = "clbClasse4eme";
            this.clbClasse4eme.Size = new System.Drawing.Size(167, 391);
            this.clbClasse4eme.TabIndex = 37;
            this.clbClasse4eme.SelectedIndexChanged += new System.EventHandler(this.clbClasse4eme_SelectedIndexChanged_1);
            // 
            // clbClasse3eme
            // 
            this.clbClasse3eme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clbClasse3eme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbClasse3eme.CheckOnClick = true;
            this.clbClasse3eme.ForeColor = System.Drawing.SystemColors.Window;
            this.clbClasse3eme.FormattingEnabled = true;
            this.clbClasse3eme.Location = new System.Drawing.Point(548, 45);
            this.clbClasse3eme.Name = "clbClasse3eme";
            this.clbClasse3eme.Size = new System.Drawing.Size(167, 391);
            this.clbClasse3eme.TabIndex = 38;
            this.clbClasse3eme.SelectedIndexChanged += new System.EventHandler(this.clbClasse3eme_SelectedIndexChanged);
            // 
            // gpbTriParClasses
            // 
            this.gpbTriParClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gpbTriParClasses.Controls.Add(this.clbClasse3eme);
            this.gpbTriParClasses.Controls.Add(this.clbClasse4eme);
            this.gpbTriParClasses.Controls.Add(this.clbClasse5eme);
            this.gpbTriParClasses.Controls.Add(this.clbClasse6eme);
            this.gpbTriParClasses.ForeColor = System.Drawing.Color.White;
            this.gpbTriParClasses.Location = new System.Drawing.Point(40, 217);
            this.gpbTriParClasses.Name = "gpbTriParClasses";
            this.gpbTriParClasses.Size = new System.Drawing.Size(743, 467);
            this.gpbTriParClasses.TabIndex = 39;
            this.gpbTriParClasses.TabStop = false;
            this.gpbTriParClasses.Text = "Recherche par classes : ";
            this.gpbTriParClasses.Enter += new System.EventHandler(this.gpbTriParClasses_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.button1.Location = new System.Drawing.Point(1357, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 40;
            this.button1.Text = "&Tutoriel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCarteParClasseNiveau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1510, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbTriParClasses);
            this.Controls.Add(this.gbxTriParNiveau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.NbComptageEleveCS);
            this.Controls.Add(this.lsbListeEleve);
            this.Controls.Add(this.btnValiderImpr);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarteParClasseNiveau";
            this.Text = "Athena - Cartes par Classe / Niveau";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarteParClasseNiveau_FormClosed);
            this.Load += new System.EventHandler(this.frmCarteParClasseNiveau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.gbxTriParNiveau.ResumeLayout(false);
            this.gbxTriParNiveau.PerformLayout();
            this.gpbTriParClasses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCount;

        #endregion
        private System.Windows.Forms.Button btnValiderImpr;
        private System.Windows.Forms.ListBox lsbListeEleve;
        private System.Windows.Forms.Label NbComptageEleveCS;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxTriParNiveau;
        private System.Windows.Forms.CheckedListBox clbClasse6eme;
        private System.Windows.Forms.CheckedListBox clbClasse5eme;
        private System.Windows.Forms.CheckedListBox clbClasse4eme;
        private System.Windows.Forms.CheckedListBox clbClasse3eme;
        private System.Windows.Forms.GroupBox gpbTriParClasses;
        private System.Windows.Forms.CheckBox cbxNiveau3eme;
        private System.Windows.Forms.CheckBox cbxNiveau4eme;
        private System.Windows.Forms.CheckBox cbxNiveau5eme;
        private System.Windows.Forms.CheckBox cbxNiveau6eme;
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