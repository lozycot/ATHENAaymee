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
    partial class frmSelectionNiveauPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectionNiveauPhoto));
            this.btnValider = new System.Windows.Forms.Button();
            this.gpbClasse = new System.Windows.Forms.GroupBox();
            this.rdb3eme = new System.Windows.Forms.RadioButton();
            this.rdb4eme = new System.Windows.Forms.RadioButton();
            this.rdb5eme = new System.Windows.Forms.RadioButton();
            this.rdb6eme = new System.Windows.Forms.RadioButton();
            this.gpdChoixImage = new System.Windows.Forms.GroupBox();
            this.rdbDossier = new System.Windows.Forms.RadioButton();
            this.rdbImage = new System.Windows.Forms.RadioButton();
            this.gpbClasse.SuspendLayout();
            this.gpdChoixImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnValider.Location = new System.Drawing.Point(518, 169);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(140, 49);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // gpbClasse
            // 
            this.gpbClasse.Controls.Add(this.rdb3eme);
            this.gpbClasse.Controls.Add(this.rdb4eme);
            this.gpbClasse.Controls.Add(this.rdb5eme);
            this.gpbClasse.Controls.Add(this.rdb6eme);
            this.gpbClasse.ForeColor = System.Drawing.Color.White;
            this.gpbClasse.Location = new System.Drawing.Point(250, 12);
            this.gpbClasse.Name = "gpbClasse";
            this.gpbClasse.Size = new System.Drawing.Size(237, 206);
            this.gpbClasse.TabIndex = 3;
            this.gpbClasse.TabStop = false;
            this.gpbClasse.Text = "Classe";
            // 
            // rdb3eme
            // 
            this.rdb3eme.AutoSize = true;
            this.rdb3eme.Location = new System.Drawing.Point(21, 162);
            this.rdb3eme.Name = "rdb3eme";
            this.rdb3eme.Size = new System.Drawing.Size(64, 21);
            this.rdb3eme.TabIndex = 3;
            this.rdb3eme.Text = "3ème";
            this.rdb3eme.UseVisualStyleBackColor = true;
            // 
            // rdb4eme
            // 
            this.rdb4eme.AutoSize = true;
            this.rdb4eme.Location = new System.Drawing.Point(21, 120);
            this.rdb4eme.Name = "rdb4eme";
            this.rdb4eme.Size = new System.Drawing.Size(64, 21);
            this.rdb4eme.TabIndex = 2;
            this.rdb4eme.Text = "4ème";
            this.rdb4eme.UseVisualStyleBackColor = true;
            // 
            // rdb5eme
            // 
            this.rdb5eme.AutoSize = true;
            this.rdb5eme.Location = new System.Drawing.Point(21, 78);
            this.rdb5eme.Name = "rdb5eme";
            this.rdb5eme.Size = new System.Drawing.Size(64, 21);
            this.rdb5eme.TabIndex = 1;
            this.rdb5eme.Text = "5ème";
            this.rdb5eme.UseVisualStyleBackColor = true;
            // 
            // rdb6eme
            // 
            this.rdb6eme.AutoSize = true;
            this.rdb6eme.Checked = true;
            this.rdb6eme.Location = new System.Drawing.Point(21, 36);
            this.rdb6eme.Name = "rdb6eme";
            this.rdb6eme.Size = new System.Drawing.Size(64, 21);
            this.rdb6eme.TabIndex = 0;
            this.rdb6eme.TabStop = true;
            this.rdb6eme.Text = "6ème";
            this.rdb6eme.UseVisualStyleBackColor = true;
            // 
            // gpdChoixImage
            // 
            this.gpdChoixImage.Controls.Add(this.rdbDossier);
            this.gpdChoixImage.Controls.Add(this.rdbImage);
            this.gpdChoixImage.ForeColor = System.Drawing.Color.White;
            this.gpdChoixImage.Location = new System.Drawing.Point(12, 12);
            this.gpdChoixImage.Name = "gpdChoixImage";
            this.gpdChoixImage.Size = new System.Drawing.Size(232, 206);
            this.gpdChoixImage.TabIndex = 5;
            this.gpdChoixImage.TabStop = false;
            this.gpdChoixImage.Text = "Image";
            this.gpdChoixImage.Enter += new System.EventHandler(this.gpdChoixImage_Enter);
            // 
            // rdbDossier
            // 
            this.rdbDossier.AutoSize = true;
            this.rdbDossier.Checked = true;
            this.rdbDossier.Location = new System.Drawing.Point(21, 36);
            this.rdbDossier.Name = "rdbDossier";
            this.rdbDossier.Size = new System.Drawing.Size(154, 21);
            this.rdbDossier.TabIndex = 1;
            this.rdbDossier.TabStop = true;
            this.rdbDossier.Text = "Un dossier d\'image ";
            this.rdbDossier.UseVisualStyleBackColor = true;
            // 
            // rdbImage
            // 
            this.rdbImage.AutoSize = true;
            this.rdbImage.Location = new System.Drawing.Point(21, 78);
            this.rdbImage.Name = "rdbImage";
            this.rdbImage.Size = new System.Drawing.Size(135, 21);
            this.rdbImage.TabIndex = 0;
            this.rdbImage.Text = "Une image seule\r\n";
            this.rdbImage.UseVisualStyleBackColor = true;
            this.rdbImage.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // frmSelectionNiveauPhoto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(671, 235);
            this.Controls.Add(this.gpdChoixImage);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.gpbClasse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectionNiveauPhoto";
            this.Text = "Selection Niveau";
            this.Load += new System.EventHandler(this.frmSelectionNiveauPhoto_Load);
            this.gpbClasse.ResumeLayout(false);
            this.gpbClasse.PerformLayout();
            this.gpdChoixImage.ResumeLayout(false);
            this.gpdChoixImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gpbClasse;
        private System.Windows.Forms.RadioButton rdb3eme;
        private System.Windows.Forms.RadioButton rdb4eme;
        private System.Windows.Forms.RadioButton rdb5eme;
        private System.Windows.Forms.RadioButton rdb6eme;
        private System.Windows.Forms.GroupBox gpdChoixImage;
        private System.Windows.Forms.RadioButton rdbDossier;
        private System.Windows.Forms.RadioButton rdbImage;
    }
}