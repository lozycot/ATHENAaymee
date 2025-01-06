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
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.btnEtab = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.btnFaceCartes = new System.Windows.Forms.Button();
            this.btnPhotos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImportEdt = new System.Windows.Forms.Label();
            this.lblImportPhotos = new System.Windows.Forms.Label();
            this.btnImportPlanches = new System.Windows.Forms.Button();
            this.toolTipExcel = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPdf = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPhotos = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipFaces = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTrombis = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEtab = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnEtab
            // 
            this.btnEtab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnEtab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEtab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnEtab.Location = new System.Drawing.Point(118, 107);
            this.btnEtab.Name = "btnEtab";
            this.btnEtab.Size = new System.Drawing.Size(511, 69);
            this.btnEtab.TabIndex = 0;
            this.btnEtab.Text = "🏫 Ajouter les informations sur l\'etablissement et changement des couleurs de la " +
    "carte d\'accès\r\n";
            this.toolTipEtab.SetToolTip(this.btnEtab, "Paramétrer les coordonnées de l\'établissement et les couleurs des différents nive" +
        "aux élèves.");
            this.btnEtab.UseVisualStyleBackColor = false;
            this.btnEtab.Click += new System.EventHandler(this.btnEtab_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnEdt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnEdt.Location = new System.Drawing.Point(118, 407);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(511, 56);
            this.btnEdt.TabIndex = 2;
            this.btnEdt.Text = "📆 Importer des &emplois du temps (PDF)\r\n";
            this.toolTipPdf.SetToolTip(this.btnEdt, "Importer des emplois du temps élèves au format PDF pour récupérer leurs noms, pré" +
        "noms, classes et emplois du temps.");
            this.btnEdt.UseVisualStyleBackColor = false;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // btnFaceCartes
            // 
            this.btnFaceCartes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnFaceCartes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFaceCartes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaceCartes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnFaceCartes.Location = new System.Drawing.Point(118, 182);
            this.btnFaceCartes.Name = "btnFaceCartes";
            this.btnFaceCartes.Size = new System.Drawing.Size(511, 41);
            this.btnFaceCartes.TabIndex = 4;
            this.btnFaceCartes.Text = "💳 Importer des faces pour les cartes";
            this.toolTipFaces.SetToolTip(this.btnFaceCartes, "Importer les images à imprimer sur les faces des cartes.");
            this.btnFaceCartes.UseVisualStyleBackColor = false;
            this.btnFaceCartes.Click += new System.EventHandler(this.btnFaceCartes_Click);
            // 
            // btnPhotos
            // 
            this.btnPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnPhotos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnPhotos.Location = new System.Drawing.Point(118, 469);
            this.btnPhotos.Name = "btnPhotos";
            this.btnPhotos.Size = new System.Drawing.Size(511, 57);
            this.btnPhotos.TabIndex = 3;
            this.btnPhotos.Text = "📸 Importer les &photos des élèves\r\n";
            this.toolTipPhotos.SetToolTip(this.btnPhotos, "Importer les photos individuelles des élèves.");
            this.btnPhotos.UseVisualStyleBackColor = false;
            this.btnPhotos.Click += new System.EventHandler(this.btnPhotos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(635, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dernière importation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(635, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dernière importation :";
            // 
            // lblImportEdt
            // 
            this.lblImportEdt.AutoSize = true;
            this.lblImportEdt.ForeColor = System.Drawing.Color.White;
            this.lblImportEdt.Location = new System.Drawing.Point(832, 424);
            this.lblImportEdt.Name = "lblImportEdt";
            this.lblImportEdt.Size = new System.Drawing.Size(130, 17);
            this.lblImportEdt.TabIndex = 9;
            this.lblImportEdt.Text = "Aucune Importation";
            // 
            // lblImportPhotos
            // 
            this.lblImportPhotos.AutoSize = true;
            this.lblImportPhotos.ForeColor = System.Drawing.Color.White;
            this.lblImportPhotos.Location = new System.Drawing.Point(832, 486);
            this.lblImportPhotos.Name = "lblImportPhotos";
            this.lblImportPhotos.Size = new System.Drawing.Size(130, 17);
            this.lblImportPhotos.TabIndex = 10;
            this.lblImportPhotos.Text = "Aucune Importation";
            // 
            // btnImportPlanches
            // 
            this.btnImportPlanches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.btnImportPlanches.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportPlanches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportPlanches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(131)))));
            this.btnImportPlanches.Location = new System.Drawing.Point(118, 532);
            this.btnImportPlanches.Name = "btnImportPlanches";
            this.btnImportPlanches.Size = new System.Drawing.Size(511, 59);
            this.btnImportPlanches.TabIndex = 11;
            this.btnImportPlanches.Text = "👁‍🗨 Importer des trombinoscopes scannés";
            this.toolTipTrombis.SetToolTip(this.btnImportPlanches, "Importer des photos d\'élèves à partir de trombinoscopes scannés.");
            this.btnImportPlanches.UseVisualStyleBackColor = false;
            this.btnImportPlanches.Click += new System.EventHandler(this.btnImportPlanches_Click);
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
            // frmImport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1284, 922);
            this.Controls.Add(this.btnImportPlanches);
            this.Controls.Add(this.lblImportPhotos);
            this.Controls.Add(this.lblImportEdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFaceCartes);
            this.Controls.Add(this.btnPhotos);
            this.Controls.Add(this.btnEdt);
            this.Controls.Add(this.btnEtab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Imports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEtab;
        private System.Windows.Forms.Button btnEdt;
        private System.Windows.Forms.Button btnFaceCartes;
        private System.Windows.Forms.Button btnPhotos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImportEdt;
        private System.Windows.Forms.Label lblImportPhotos;
        private System.Windows.Forms.Button btnImportPlanches;
        private System.Windows.Forms.ToolTip toolTipExcel;
        private System.Windows.Forms.ToolTip toolTipEtab;
        private System.Windows.Forms.ToolTip toolTipPdf;
        private System.Windows.Forms.ToolTip toolTipFaces;
        private System.Windows.Forms.ToolTip toolTipPhotos;
        private System.Windows.Forms.ToolTip toolTipTrombis;
    }
}