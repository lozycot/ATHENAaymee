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
    partial class frmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.btnChangeMdp = new System.Windows.Forms.Button();
            this.btnParametres = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreerCarte = new System.Windows.Forms.Button();
            this.btnAfficheListeEleve = new System.Windows.Forms.Button();
            this.btnCarteParClasse = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAPropos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlanche = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeMdp
            // 
            this.btnChangeMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChangeMdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnChangeMdp.Location = new System.Drawing.Point(8, 641);
            this.btnChangeMdp.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeMdp.Name = "btnChangeMdp";
            this.btnChangeMdp.Size = new System.Drawing.Size(247, 52);
            this.btnChangeMdp.TabIndex = 25;
            this.btnChangeMdp.Text = "🛠 Options avancées";
            this.btnChangeMdp.UseVisualStyleBackColor = false;
            this.btnChangeMdp.Click += new System.EventHandler(this.btnChangeMdp_Click);
            // 
            // btnParametres
            // 
            this.btnParametres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnParametres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParametres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnParametres.Location = new System.Drawing.Point(8, 48);
            this.btnParametres.Margin = new System.Windows.Forms.Padding(4);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(249, 52);
            this.btnParametres.TabIndex = 24;
            this.btnParametres.Text = "Importer des informations";
            this.btnParametres.UseVisualStyleBackColor = false;
            this.btnParametres.Click += new System.EventHandler(this.btnParametres_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Importation ⤵️";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreerCarte
            // 
            this.btnCreerCarte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCreerCarte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreerCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerCarte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnCreerCarte.Location = new System.Drawing.Point(10, 279);
            this.btnCreerCarte.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreerCarte.Name = "btnCreerCarte";
            this.btnCreerCarte.Size = new System.Drawing.Size(247, 52);
            this.btnCreerCarte.TabIndex = 22;
            this.btnCreerCarte.Text = "Cartes provisoire";
            this.btnCreerCarte.UseVisualStyleBackColor = false;
            this.btnCreerCarte.Click += new System.EventHandler(this.btnCreerCarte_Click);
            // 
            // btnAfficheListeEleve
            // 
            this.btnAfficheListeEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAfficheListeEleve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAfficheListeEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficheListeEleve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnAfficheListeEleve.Location = new System.Drawing.Point(10, 219);
            this.btnAfficheListeEleve.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficheListeEleve.Name = "btnAfficheListeEleve";
            this.btnAfficheListeEleve.Size = new System.Drawing.Size(247, 52);
            this.btnAfficheListeEleve.TabIndex = 21;
            this.btnAfficheListeEleve.Text = "Cartes par liste personnalisé";
            this.btnAfficheListeEleve.UseVisualStyleBackColor = false;
            this.btnAfficheListeEleve.Click += new System.EventHandler(this.btnAfficheListeEleve_Click);
            // 
            // btnCarteParClasse
            // 
            this.btnCarteParClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCarteParClasse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCarteParClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarteParClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnCarteParClasse.Location = new System.Drawing.Point(8, 159);
            this.btnCarteParClasse.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarteParClasse.Name = "btnCarteParClasse";
            this.btnCarteParClasse.Size = new System.Drawing.Size(249, 52);
            this.btnCarteParClasse.TabIndex = 20;
            this.btnCarteParClasse.Text = "Cartes par classe / niveau";
            this.btnCarteParClasse.UseVisualStyleBackColor = false;
            this.btnCarteParClasse.Click += new System.EventHandler(this.btnCarteParClasse_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 40);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cartes d\'accès 🪪";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnChangeMdp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAPropos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCarteParClasse);
            this.panel1.Controls.Add(this.btnCreerCarte);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPlanche);
            this.panel1.Controls.Add(this.btnParametres);
            this.panel1.Controls.Add(this.btnAfficheListeEleve);
            this.panel1.Location = new System.Drawing.Point(2, 294);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 757);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 608);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Autre ℹ️";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAPropos
            // 
            this.btnAPropos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAPropos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAPropos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAPropos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAPropos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnAPropos.Location = new System.Drawing.Point(8, 701);
            this.btnAPropos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAPropos.Name = "btnAPropos";
            this.btnAPropos.Size = new System.Drawing.Size(247, 52);
            this.btnAPropos.TabIndex = 36;
            this.btnAPropos.Text = "ℹ À Propos";
            this.btnAPropos.UseVisualStyleBackColor = false;
            this.btnAPropos.Click += new System.EventHandler(this.btnAPropos_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(278, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 680);
            this.panel2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 360);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Trombinoscopes 🖼️";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlanche
            // 
            this.btnPlanche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPlanche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnPlanche.Location = new System.Drawing.Point(10, 393);
            this.btnPlanche.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlanche.Name = "btnPlanche";
            this.btnPlanche.Size = new System.Drawing.Size(247, 52);
            this.btnPlanche.TabIndex = 33;
            this.btnPlanche.Text = "Planches par classe";
            this.btnPlanche.UseVisualStyleBackColor = false;
            this.btnPlanche.Click += new System.EventHandler(this.btnPlanche_Click);
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.lblNom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(49, 9);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(171, 29);
            this.lblNom.TabIndex = 37;
            this.lblNom.Text = "Athena";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlMenu.Controls.Add(this.lblNom);
            this.pnlMenu.Controls.Add(this.pictureBox3);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(272, 1053);
            this.pnlMenu.TabIndex = 32;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.AutoSize = true;
            this.pnlContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(272, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1210, 1053);
            this.pnlContent.TabIndex = 33;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint_1);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1482, 1053);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAccueil";
            this.Text = "Athena";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAcceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChangeMdp;
        private System.Windows.Forms.Button btnParametres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreerCarte;
        private System.Windows.Forms.Button btnAfficheListeEleve;
        private System.Windows.Forms.Button btnCarteParClasse;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnPlanche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAPropos;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label4;
    }
}