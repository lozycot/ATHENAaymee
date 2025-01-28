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
    partial class frmBienvenue
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenue));
            this.toolTipExcel = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPdf = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPhotos = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFaces = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTrombis = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEtab = new System.Windows.Forms.ToolTip(this.components);
            this.picbFond = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbFond)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipExcel
            // 
            this.toolTipExcel.ToolTipTitle = "Importer une liste d\'élèves";
            // 
            // toolTipPdf
            // 
            this.toolTipPdf.ToolTipTitle = "Importer des emplois du temps PDF";
            // 
            // toolTipPhotos
            // 
            this.toolTipPhotos.ToolTipTitle = "Choisir le dossier qui comporte les photos";
            // 
            // toolTipFaces
            // 
            this.toolTipFaces.ToolTipTitle = "Importer des faces pour les cartes";
            // 
            // toolTipTrombis
            // 
            this.toolTipTrombis.ToolTipTitle = "Importer des trombinoscopes scannés";
            // 
            // toolTipEtab
            // 
            this.toolTipEtab.ToolTipTitle = "Importer un établissement";
            // 
            // picbFond
            // 
            this.picbFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbFond.Image = global::Athena.Properties.Resources.FondAthena2025;
            this.picbFond.Location = new System.Drawing.Point(0, 0);
            this.picbFond.Name = "picbFond";
            this.picbFond.Size = new System.Drawing.Size(882, 499);
            this.picbFond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbFond.TabIndex = 0;
            this.picbFond.TabStop = false;
            // 
            // frmBienvenue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(882, 499);
            this.Controls.Add(this.picbFond);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBienvenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Athena - Bienvenue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBienvenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbFond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipExcel;
        private System.Windows.Forms.ToolTip toolTipEtab;
        private System.Windows.Forms.ToolTip toolTipPdf;
        private System.Windows.Forms.ToolTip toolTipFaces;
        private System.Windows.Forms.ToolTip toolTipPhotos;
        private System.Windows.Forms.ToolTip toolTipTrombis;
        private System.Windows.Forms.PictureBox picbFond;
    }
}