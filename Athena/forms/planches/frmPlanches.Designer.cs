namespace CartesAcces2024
{
    partial class frmPlanches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanches));
            this.pbDocument = new System.Windows.Forms.PictureBox();
            this.btnGenererVide = new System.Windows.Forms.Button();
            this.btnTrombi = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.panelBdd = new System.Windows.Forms.Panel();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnToutSelectionner = new System.Windows.Forms.Button();
            this.gbpElements = new System.Windows.Forms.GroupBox();
            this.clbElements = new System.Windows.Forms.CheckedListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTipSource = new System.Windows.Forms.ToolTip(this.components);
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProfils = new System.Windows.Forms.CheckBox();
            this.tkbZoom = new System.Windows.Forms.TrackBar();
            this.btnTuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocument)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBdd.SuspendLayout();
            this.gbpElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDocument
            // 
            this.pbDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pbDocument.Location = new System.Drawing.Point(2, 2);
            this.pbDocument.Margin = new System.Windows.Forms.Padding(2);
            this.pbDocument.Name = "pbDocument";
            this.pbDocument.Size = new System.Drawing.Size(1316, 1008);
            this.pbDocument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDocument.TabIndex = 0;
            this.pbDocument.TabStop = false;
            // 
            // btnGenererVide
            // 
            this.btnGenererVide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGenererVide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenererVide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnGenererVide.Location = new System.Drawing.Point(372, 660);
            this.btnGenererVide.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenererVide.Name = "btnGenererVide";
            this.btnGenererVide.Size = new System.Drawing.Size(346, 32);
            this.btnGenererVide.TabIndex = 3;
            this.btnGenererVide.Text = "Générer les planches sans photos";
            this.btnGenererVide.UseVisualStyleBackColor = false;
            this.btnGenererVide.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // btnTrombi
            // 
            this.btnTrombi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTrombi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrombi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnTrombi.Location = new System.Drawing.Point(372, 711);
            this.btnTrombi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrombi.Name = "btnTrombi";
            this.btnTrombi.Size = new System.Drawing.Size(346, 32);
            this.btnTrombi.TabIndex = 12;
            this.btnTrombi.Text = "Générer les trombinoscopes avec photos enregistrées";
            this.btnTrombi.UseVisualStyleBackColor = false;
            this.btnTrombi.Click += new System.EventHandler(this.btnTrombi_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(369, 32);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(37, 17);
            this.lblTitre.TabIndex = 13;
            this.lblTitre.Text = "Titre";
            // 
            // cbClasse
            // 
            this.cbClasse.Enabled = false;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(410, 28);
            this.cbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(269, 24);
            this.cbClasse.TabIndex = 14;
            this.cbClasse.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectionIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbDocument);
            this.panel1.Location = new System.Drawing.Point(372, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 502);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(704, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "🔎 Zoom :";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEnregistrer.Enabled = false;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnEnregistrer.Location = new System.Drawing.Point(763, 660);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(266, 32);
            this.btnEnregistrer.TabIndex = 18;
            this.btnEnregistrer.Text = "💾 Enregistrer le document";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // panelBdd
            // 
            this.panelBdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelBdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBdd.Controls.Add(this.btnReinitialiser);
            this.panelBdd.Controls.Add(this.btnToutSelectionner);
            this.panelBdd.Controls.Add(this.gbpElements);
            this.panelBdd.Controls.Add(this.btnValider);
            this.panelBdd.Location = new System.Drawing.Point(41, 58);
            this.panelBdd.Margin = new System.Windows.Forms.Padding(2);
            this.panelBdd.Name = "panelBdd";
            this.panelBdd.Size = new System.Drawing.Size(309, 685);
            this.panelBdd.TabIndex = 19;
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReinitialiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReinitialiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnReinitialiser.Location = new System.Drawing.Point(9, 475);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(289, 70);
            this.btnReinitialiser.TabIndex = 15;
            this.btnReinitialiser.Text = "Réinitialiser la sélection";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnToutSelectionner
            // 
            this.btnToutSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnToutSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToutSelectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnToutSelectionner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnToutSelectionner.Location = new System.Drawing.Point(9, 551);
            this.btnToutSelectionner.Name = "btnToutSelectionner";
            this.btnToutSelectionner.Size = new System.Drawing.Size(289, 55);
            this.btnToutSelectionner.TabIndex = 16;
            this.btnToutSelectionner.Text = "Tout sélectionner";
            this.btnToutSelectionner.UseVisualStyleBackColor = false;
            this.btnToutSelectionner.Click += new System.EventHandler(this.btnToutSelectionner_Click);
            // 
            // gbpElements
            // 
            this.gbpElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbpElements.Controls.Add(this.clbElements);
            this.gbpElements.ForeColor = System.Drawing.Color.White;
            this.gbpElements.Location = new System.Drawing.Point(3, 3);
            this.gbpElements.Name = "gbpElements";
            this.gbpElements.Size = new System.Drawing.Size(301, 459);
            this.gbpElements.TabIndex = 26;
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
            this.clbElements.Size = new System.Drawing.Size(405, 565);
            this.clbElements.TabIndex = 0;
            this.clbElements.SelectedIndexChanged += new System.EventHandler(this.clbElements_SelectedIndexChanged);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnValider.Location = new System.Drawing.Point(10, 613);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(288, 55);
            this.btnValider.TabIndex = 17;
            this.btnValider.Text = "Gérer les classes temporaires";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cbSource
            // 
            this.cbSource.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(40, 26);
            this.cbSource.Margin = new System.Windows.Forms.Padding(2);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(309, 28);
            this.cbSource.TabIndex = 20;
            this.toolTipSource.SetToolTip(this.cbSource, resources.GetString("cbSource.ToolTip"));
            this.cbSource.SelectedIndexChanged += new System.EventHandler(this.cbSource_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Source des élèves :";
            this.toolTipSource.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // toolTipSource
            // 
            this.toolTipSource.ToolTipTitle = "Sélectionner la source";
            // 
            // cbFormat
            // 
            this.cbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(523, 615);
            this.cbFormat.Margin = new System.Windows.Forms.Padding(2);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(61, 28);
            this.cbFormat.TabIndex = 22;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(373, 620);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Format des pages :";
            // 
            // cbProfils
            // 
            this.cbProfils.AutoSize = true;
            this.cbProfils.ForeColor = System.Drawing.Color.White;
            this.cbProfils.Location = new System.Drawing.Point(611, 620);
            this.cbProfils.Margin = new System.Windows.Forms.Padding(2);
            this.cbProfils.Name = "cbProfils";
            this.cbProfils.Size = new System.Drawing.Size(413, 21);
            this.cbProfils.TabIndex = 24;
            this.cbProfils.Text = "Colorier différemment les noms en fonction des profils élèves";
            this.cbProfils.UseVisualStyleBackColor = true;
            // 
            // tkbZoom
            // 
            this.tkbZoom.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tkbZoom.Location = new System.Drawing.Point(782, 30);
            this.tkbZoom.Margin = new System.Windows.Forms.Padding(4);
            this.tkbZoom.Maximum = 100;
            this.tkbZoom.Minimum = 30;
            this.tkbZoom.Name = "tkbZoom";
            this.tkbZoom.Size = new System.Drawing.Size(247, 56);
            this.tkbZoom.TabIndex = 25;
            this.tkbZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tkbZoom.UseWaitCursor = true;
            this.tkbZoom.Value = 50;
            this.tkbZoom.Scroll += new System.EventHandler(this.tkbZoom_Scroll);
            // 
            // btnTuto
            // 
            this.btnTuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnTuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnTuto.Location = new System.Drawing.Point(1077, 16);
            this.btnTuto.Name = "btnTuto";
            this.btnTuto.Size = new System.Drawing.Size(101, 40);
            this.btnTuto.TabIndex = 26;
            this.btnTuto.Text = "Tutoriel";
            this.btnTuto.UseVisualStyleBackColor = false;
            this.btnTuto.Click += new System.EventHandler(this.btnTuto_Click);
            // 
            // frmPlanches
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1190, 784);
            this.Controls.Add(this.btnTuto);
            this.Controls.Add(this.tkbZoom);
            this.Controls.Add(this.cbProfils);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSource);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnTrombi);
            this.Controls.Add(this.btnGenererVide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPlanches";
            this.Text = "Athena - Creation de planches";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPlanches_FormClosed);
            this.Load += new System.EventHandler(this.frmPlanches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDocument)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBdd.ResumeLayout(false);
            this.gbpElements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tkbZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDocument;
        private System.Windows.Forms.Button btnGenererVide;
        private System.Windows.Forms.Button btnTrombi;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Panel panelBdd;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ToolTip toolTipSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbProfils;
        private System.Windows.Forms.TrackBar tkbZoom;
        private System.Windows.Forms.GroupBox gbpElements;
        private System.Windows.Forms.CheckedListBox clbElements;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnToutSelectionner;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnTuto;
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