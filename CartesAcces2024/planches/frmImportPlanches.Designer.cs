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
    partial class frmImportPlanches
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
            this.lblExplications = new System.Windows.Forms.Label();
            this.btnPdfNormal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJpeg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnJpegNA = new System.Windows.Forms.Button();
            this.btnImporterPDFnA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExplications
            // 
            this.lblExplications.AutoSize = true;
            this.lblExplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblExplications.ForeColor = System.Drawing.Color.White;
            this.lblExplications.Location = new System.Drawing.Point(41, 39);
            this.lblExplications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExplications.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblExplications.Name = "lblExplications";
            this.lblExplications.Size = new System.Drawing.Size(598, 36);
            this.lblExplications.TabIndex = 1;
            this.lblExplications.Text = "Importer un fichier PDF comportant des trombinoscopes pour en importer les photos" +
    " des élèves individuellement.";
            // 
            // btnPdfNormal
            // 
            this.btnPdfNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnPdfNormal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdfNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdfNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnPdfNormal.Location = new System.Drawing.Point(60, 56);
            this.btnPdfNormal.Margin = new System.Windows.Forms.Padding(2);
            this.btnPdfNormal.Name = "btnPdfNormal";
            this.btnPdfNormal.Size = new System.Drawing.Size(254, 72);
            this.btnPdfNormal.TabIndex = 6;
            this.btnPdfNormal.Text = "📄 Importer un PDF...";
            this.btnPdfNormal.UseVisualStyleBackColor = false;
            this.btnPdfNormal.Click += new System.EventHandler(this.btnPdfNormal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJpeg);
            this.groupBox1.Controls.Add(this.btnPdfNormal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(44, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(374, 286);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes de l\'année EN COURS";
            // 
            // btnJpeg
            // 
            this.btnJpeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnJpeg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJpeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJpeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnJpeg.Location = new System.Drawing.Point(60, 168);
            this.btnJpeg.Margin = new System.Windows.Forms.Padding(2);
            this.btnJpeg.Name = "btnJpeg";
            this.btnJpeg.Size = new System.Drawing.Size(254, 72);
            this.btnJpeg.TabIndex = 7;
            this.btnJpeg.Text = "🖼 Importer une page au format JPEG...";
            this.btnJpeg.UseVisualStyleBackColor = false;
            this.btnJpeg.Click += new System.EventHandler(this.btnJpeg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.groupBox2.Controls.Add(this.btnJpegNA);
            this.groupBox2.Controls.Add(this.btnImporterPDFnA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(422, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(374, 286);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classes de l\'année PROCHAINE";
            // 
            // btnJpegNA
            // 
            this.btnJpegNA.BackColor = System.Drawing.Color.Gold;
            this.btnJpegNA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJpegNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJpegNA.Location = new System.Drawing.Point(60, 168);
            this.btnJpegNA.Margin = new System.Windows.Forms.Padding(2);
            this.btnJpegNA.Name = "btnJpegNA";
            this.btnJpegNA.Size = new System.Drawing.Size(254, 72);
            this.btnJpegNA.TabIndex = 7;
            this.btnJpegNA.Text = "🖼 Importer une page au format JPEG... (nouvelle année)";
            this.btnJpegNA.UseVisualStyleBackColor = false;
            this.btnJpegNA.Click += new System.EventHandler(this.btnJpegNA_Click);
            // 
            // btnImporterPDFnA
            // 
            this.btnImporterPDFnA.BackColor = System.Drawing.Color.Gold;
            this.btnImporterPDFnA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImporterPDFnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImporterPDFnA.Location = new System.Drawing.Point(60, 56);
            this.btnImporterPDFnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnImporterPDFnA.Name = "btnImporterPDFnA";
            this.btnImporterPDFnA.Size = new System.Drawing.Size(254, 72);
            this.btnImporterPDFnA.TabIndex = 6;
            this.btnImporterPDFnA.Text = "📄 Importer un PDF (nouvelle année)...";
            this.btnImporterPDFnA.UseVisualStyleBackColor = false;
            this.btnImporterPDFnA.Click += new System.EventHandler(this.btnImporterPDFnA_Click);
            // 
            // frmImportPlanches
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(811, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblExplications);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmImportPlanches";
            this.Text = "Athena - Importation de planches";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblExplications;
        private System.Windows.Forms.Button btnPdfNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImporterPDFnA;
        private System.Windows.Forms.Button btnJpeg;
        private System.Windows.Forms.Button btnJpegNA;
    }
}