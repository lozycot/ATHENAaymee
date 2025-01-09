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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbImprSection = new System.Windows.Forms.ComboBox();
            this.btnValiderImpr = new System.Windows.Forms.Button();
            this.lsbListeEleve = new System.Windows.Forms.ListBox();
            this.NbComptageEleveCS = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbImprClasse = new System.Windows.Forms.ComboBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imprimer une classe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imprimer par niveau";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbImprSection
            // 
            this.cbbImprSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbImprSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbbImprSection.FormattingEnabled = true;
            this.cbbImprSection.Items.AddRange(new object[] {
            "6eme",
            "5eme",
            "4eme",
            "3eme"});
            this.cbbImprSection.Location = new System.Drawing.Point(329, 186);
            this.cbbImprSection.MaximumSize = new System.Drawing.Size(180, 0);
            this.cbbImprSection.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbbImprSection.Name = "cbbImprSection";
            this.cbbImprSection.Size = new System.Drawing.Size(180, 37);
            this.cbbImprSection.TabIndex = 4;
            this.cbbImprSection.SelectionChangeCommitted += new System.EventHandler(this.cbbImprSection_SelectedIndexChanged);
            // 
            // btnValiderImpr
            // 
            this.btnValiderImpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnValiderImpr.Enabled = false;
            this.btnValiderImpr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValiderImpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnValiderImpr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnValiderImpr.Location = new System.Drawing.Point(805, 588);
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
            this.lsbListeEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.lsbListeEleve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbListeEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lsbListeEleve.ForeColor = System.Drawing.Color.White;
            this.lsbListeEleve.FormattingEnabled = true;
            this.lsbListeEleve.ItemHeight = 29;
            this.lsbListeEleve.Location = new System.Drawing.Point(805, 160);
            this.lsbListeEleve.MaximumSize = new System.Drawing.Size(350, 410);
            this.lsbListeEleve.MinimumSize = new System.Drawing.Size(350, 410);
            this.lsbListeEleve.Name = "lsbListeEleve";
            this.lsbListeEleve.Size = new System.Drawing.Size(350, 408);
            this.lsbListeEleve.TabIndex = 7;
            this.lsbListeEleve.SelectedIndexChanged += new System.EventHandler(this.lsbListeEleve_SelectedIndexChanged);
            // 
            // NbComptageEleveCS
            // 
            this.NbComptageEleveCS.AutoSize = true;
            this.NbComptageEleveCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NbComptageEleveCS.ForeColor = System.Drawing.Color.White;
            this.NbComptageEleveCS.Location = new System.Drawing.Point(58, 266);
            this.NbComptageEleveCS.Name = "NbComptageEleveCS";
            this.NbComptageEleveCS.Size = new System.Drawing.Size(555, 29);
            this.NbComptageEleveCS.TabIndex = 25;
            this.NbComptageEleveCS.Text = "Nombre d\'élève de la liste de la classe ou section :";
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(619, 266);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(112, 43);
            this.lblCount.TabIndex = 27;
            this.lblCount.Text = "None";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "OU";
            // 
            // cbbImprClasse
            // 
            this.cbbImprClasse.BackColor = System.Drawing.SystemColors.Window;
            this.cbbImprClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbImprClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbbImprClasse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbbImprClasse.FormattingEnabled = true;
            this.cbbImprClasse.Items.AddRange(new object[] {
            "5eme",
            "3eme",
            "test"});
            this.cbbImprClasse.Location = new System.Drawing.Point(329, 119);
            this.cbbImprClasse.MaximumSize = new System.Drawing.Size(180, 0);
            this.cbbImprClasse.MinimumSize = new System.Drawing.Size(180, 0);
            this.cbbImprClasse.Name = "cbbImprClasse";
            this.cbbImprClasse.Size = new System.Drawing.Size(180, 37);
            this.cbbImprClasse.TabIndex = 30;
            this.cbbImprClasse.SelectedIndexChanged += new System.EventHandler(this.cbbImprClasse_SelectedIndexChanged_1);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(63, 311);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(652, 344);
            this.pbPhoto.TabIndex = 31;
            this.pbPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(800, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Liste à imprimer :";
            // 
            // frmCarteParClasseNiveau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1476, 936);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.cbbImprClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.NbComptageEleveCS);
            this.Controls.Add(this.lsbListeEleve);
            this.Controls.Add(this.btnValiderImpr);
            this.Controls.Add(this.cbbImprSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarteParClasseNiveau";
            this.Text = "frmCreationCarteParClasse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarteParClasseNiveau_FormClosed);
            this.Load += new System.EventHandler(this.frmCarteParClasseNiveau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label lblCount;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbImprSection;
        private System.Windows.Forms.Button btnValiderImpr;
        private System.Windows.Forms.ListBox lsbListeEleve;
        private System.Windows.Forms.Label NbComptageEleveCS;
        private System.Windows.Forms.ComboBox cbbImprClasse;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label label4;
    }
}