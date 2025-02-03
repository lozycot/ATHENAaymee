namespace CartesAcces2024
{
    partial class frmSelectionNiveauEdt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectionNiveauEdt));
            this.gpbClasse = new System.Windows.Forms.GroupBox();
            this.rdbTousEleves = new System.Windows.Forms.RadioButton();
            this.rdbClasses = new System.Windows.Forms.RadioButton();
            this.rdb3eme = new System.Windows.Forms.RadioButton();
            this.rdb4eme = new System.Windows.Forms.RadioButton();
            this.rdb5eme = new System.Windows.Forms.RadioButton();
            this.rdb6eme = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.gpbClasse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbClasse
            // 
            this.gpbClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.gpbClasse.Controls.Add(this.rdbTousEleves);
            this.gpbClasse.Controls.Add(this.rdbClasses);
            this.gpbClasse.Controls.Add(this.rdb3eme);
            this.gpbClasse.Controls.Add(this.rdb4eme);
            this.gpbClasse.Controls.Add(this.rdb5eme);
            this.gpbClasse.Controls.Add(this.rdb6eme);
            this.gpbClasse.ForeColor = System.Drawing.Color.White;
            this.gpbClasse.Location = new System.Drawing.Point(12, 29);
            this.gpbClasse.Name = "gpbClasse";
            this.gpbClasse.Size = new System.Drawing.Size(278, 283);
            this.gpbClasse.TabIndex = 0;
            this.gpbClasse.TabStop = false;
            this.gpbClasse.Text = "Classe";
            // 
            // rdbTousEleves
            // 
            this.rdbTousEleves.AutoSize = true;
            this.rdbTousEleves.Location = new System.Drawing.Point(21, 226);
            this.rdbTousEleves.Name = "rdbTousEleves";
            this.rdbTousEleves.Size = new System.Drawing.Size(128, 21);
            this.rdbTousEleves.TabIndex = 5;
            this.rdbTousEleves.Text = "Tous les élèves";
            this.rdbTousEleves.UseVisualStyleBackColor = true;
            // 
            // rdbClasses
            // 
            this.rdbClasses.AutoSize = true;
            this.rdbClasses.Location = new System.Drawing.Point(21, 188);
            this.rdbClasses.Name = "rdbClasses";
            this.rdbClasses.Size = new System.Drawing.Size(245, 21);
            this.rdbClasses.TabIndex = 4;
            this.rdbClasses.Text = "Classes uniquement (sans élèves)";
            this.rdbClasses.UseVisualStyleBackColor = true;
            // 
            // rdb3eme
            // 
            this.rdb3eme.AutoSize = true;
            this.rdb3eme.Location = new System.Drawing.Point(21, 150);
            this.rdb3eme.Name = "rdb3eme";
            this.rdb3eme.Size = new System.Drawing.Size(64, 21);
            this.rdb3eme.TabIndex = 3;
            this.rdb3eme.Text = "3ème";
            this.rdb3eme.UseVisualStyleBackColor = true;
            // 
            // rdb4eme
            // 
            this.rdb4eme.AutoSize = true;
            this.rdb4eme.Location = new System.Drawing.Point(21, 112);
            this.rdb4eme.Name = "rdb4eme";
            this.rdb4eme.Size = new System.Drawing.Size(64, 21);
            this.rdb4eme.TabIndex = 2;
            this.rdb4eme.Text = "4ème";
            this.rdb4eme.UseVisualStyleBackColor = true;
            // 
            // rdb5eme
            // 
            this.rdb5eme.AutoSize = true;
            this.rdb5eme.Location = new System.Drawing.Point(21, 74);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quel niveau est concerné par ce fichier ?";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnValider.Location = new System.Drawing.Point(316, 263);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(140, 49);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmSelectionNiveauEdt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(466, 323);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbClasse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectionNiveauEdt";
            this.Text = "Selection Niveau";
            this.gpbClasse.ResumeLayout(false);
            this.gpbClasse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbClasse;
        private System.Windows.Forms.RadioButton rdbClasses;
        private System.Windows.Forms.RadioButton rdb3eme;
        private System.Windows.Forms.RadioButton rdb4eme;
        private System.Windows.Forms.RadioButton rdb5eme;
        private System.Windows.Forms.RadioButton rdb6eme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.RadioButton rdbTousEleves;
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