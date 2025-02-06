namespace CartesAcces2024
{
    partial class frmCarteProvisoire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarteProvisoire));
            this.label7 = new System.Windows.Forms.Label();
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.cbbSection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnnulerPhoto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbCarteArriere = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdtPerso = new System.Windows.Forms.Button();
            this.pbCarteFace = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAjouterPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbParN = new System.Windows.Forms.RadioButton();
            this.rdbParO = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarteArriere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarteFace)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "L\'élève a-t-il un profil particulier :";
            // 
            // cbbClasse
            // 
            this.cbbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbbClasse.Location = new System.Drawing.Point(311, 105);
            this.cbbClasse.Name = "cbbClasse";
            this.cbbClasse.Size = new System.Drawing.Size(130, 28);
            this.cbbClasse.TabIndex = 26;
            this.cbbClasse.SelectedIndexChanged += new System.EventHandler(this.cbbClasse_SelectedIndexChanged);
            // 
            // cbbSection
            // 
            this.cbbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbbSection.Items.AddRange(new object[] {
            "6eme",
            "5eme",
            "4eme",
            "3eme"});
            this.cbbSection.Location = new System.Drawing.Point(92, 105);
            this.cbbSection.Name = "cbbSection";
            this.cbbSection.Size = new System.Drawing.Size(130, 28);
            this.cbbSection.TabIndex = 25;
            this.cbbSection.SelectedIndexChanged += new System.EventHandler(this.cbbSection_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Classe :";
            // 
            // btnAnnulerPhoto
            // 
            this.btnAnnulerPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAnnulerPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnulerPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnAnnulerPhoto.Location = new System.Drawing.Point(227, 257);
            this.btnAnnulerPhoto.MaximumSize = new System.Drawing.Size(160, 40);
            this.btnAnnulerPhoto.MinimumSize = new System.Drawing.Size(180, 45);
            this.btnAnnulerPhoto.Name = "btnAnnulerPhoto";
            this.btnAnnulerPhoto.Size = new System.Drawing.Size(180, 45);
            this.btnAnnulerPhoto.TabIndex = 14;
            this.btnAnnulerPhoto.Text = "&Effacer la photo\r\n";
            this.btnAnnulerPhoto.UseVisualStyleBackColor = false;
            this.btnAnnulerPhoto.Click += new System.EventHandler(this.btnAnnulerPhoto_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnSave.Location = new System.Drawing.Point(500, 332);
            this.btnSave.MinimumSize = new System.Drawing.Size(180, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(440, 64);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Imprimer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // pbCarteArriere
            // 
            this.pbCarteArriere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCarteArriere.Location = new System.Drawing.Point(605, 0);
            this.pbCarteArriere.Margin = new System.Windows.Forms.Padding(2);
            this.pbCarteArriere.MaximumSize = new System.Drawing.Size(601, 425);
            this.pbCarteArriere.Name = "pbCarteArriere";
            this.pbCarteArriere.Size = new System.Drawing.Size(601, 381);
            this.pbCarteArriere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarteArriere.TabIndex = 16;
            this.pbCarteArriere.TabStop = false;
            this.pbCarteArriere.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCarteArriere_MouseDown_1);
            this.pbCarteArriere.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCarteArriere_MouseMove);
            this.pbCarteArriere.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCarteArriere_MouseUp_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Niveau :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.White;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrenom.Location = new System.Drawing.Point(311, 151);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(130, 26);
            this.txtPrenom.TabIndex = 22;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNom.Location = new System.Drawing.Point(92, 151);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(130, 26);
            this.txtNom.TabIndex = 21;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnReset.Location = new System.Drawing.Point(41, 249);
            this.btnReset.MinimumSize = new System.Drawing.Size(180, 45);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 61);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Réinitialiser la carte";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnEdtPerso
            // 
            this.btnEdtPerso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEdtPerso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdtPerso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnEdtPerso.Location = new System.Drawing.Point(261, 249);
            this.btnEdtPerso.MinimumSize = new System.Drawing.Size(180, 45);
            this.btnEdtPerso.Name = "btnEdtPerso";
            this.btnEdtPerso.Size = new System.Drawing.Size(180, 61);
            this.btnEdtPerso.TabIndex = 19;
            this.btnEdtPerso.Text = "Ajouter un emploi du temps personnalisé";
            this.btnEdtPerso.UseVisualStyleBackColor = false;
            this.btnEdtPerso.Click += new System.EventHandler(this.btnEdtPerso_Click_1);
            // 
            // pbCarteFace
            // 
            this.pbCarteFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCarteFace.Enabled = false;
            this.pbCarteFace.Location = new System.Drawing.Point(0, 0);
            this.pbCarteFace.Margin = new System.Windows.Forms.Padding(2);
            this.pbCarteFace.MaximumSize = new System.Drawing.Size(601, 425);
            this.pbCarteFace.Name = "pbCarteFace";
            this.pbCarteFace.Size = new System.Drawing.Size(601, 381);
            this.pbCarteFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarteFace.TabIndex = 18;
            this.pbCarteFace.TabStop = false;
            this.pbCarteFace.Click += new System.EventHandler(this.pbCarteFace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btnAjouterPhoto);
            this.groupBox3.Controls.Add(this.btnAnnulerPhoto);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(501, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 319);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ajout et Edition Photo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 41);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(173, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAjouterPhoto
            // 
            this.btnAjouterPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAjouterPhoto.Enabled = false;
            this.btnAjouterPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnAjouterPhoto.Location = new System.Drawing.Point(31, 257);
            this.btnAjouterPhoto.MaximumSize = new System.Drawing.Size(180, 45);
            this.btnAjouterPhoto.MinimumSize = new System.Drawing.Size(180, 45);
            this.btnAjouterPhoto.Name = "btnAjouterPhoto";
            this.btnAjouterPhoto.Size = new System.Drawing.Size(180, 45);
            this.btnAjouterPhoto.TabIndex = 17;
            this.btnAjouterPhoto.Text = "&Choisir une photo";
            this.btnAjouterPhoto.UseVisualStyleBackColor = false;
            this.btnAjouterPhoto.Click += new System.EventHandler(this.btnAjouterPhoto_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbPhoto.Image")));
            this.pbPhoto.Location = new System.Drawing.Point(850, 207);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(108, 142);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 17;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Visible = false;
            this.pbPhoto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPhoto_MouseDown);
            this.pbPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPhoto_MouseMove);
            this.pbPhoto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPhoto_MouseUp_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox1.Controls.Add(this.rdbParN);
            this.groupBox1.Controls.Add(this.rdbParO);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbClasse);
            this.groupBox1.Controls.Add(this.cbbSection);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnEdtPerso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 398);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renseignements Élève";
            // 
            // rdbParN
            // 
            this.rdbParN.AutoSize = true;
            this.rdbParN.Checked = true;
            this.rdbParN.Location = new System.Drawing.Point(386, 32);
            this.rdbParN.Name = "rdbParN";
            this.rdbParN.Size = new System.Drawing.Size(55, 21);
            this.rdbParN.TabIndex = 35;
            this.rdbParN.TabStop = true;
            this.rdbParN.Text = "Non";
            this.rdbParN.UseVisualStyleBackColor = true;
            this.rdbParN.CheckedChanged += new System.EventHandler(this.rdbParN_CheckedChanged);
            // 
            // rdbParO
            // 
            this.rdbParO.AutoSize = true;
            this.rdbParO.Location = new System.Drawing.Point(284, 32);
            this.rdbParO.Name = "rdbParO";
            this.rdbParO.Size = new System.Drawing.Size(51, 21);
            this.rdbParO.TabIndex = 34;
            this.rdbParO.Text = "Oui";
            this.rdbParO.UseVisualStyleBackColor = true;
            this.rdbParO.CheckedChanged += new System.EventHandler(this.rdbParO_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Les nouveau emploi du temps doivent être en PDF";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbPhoto);
            this.panel1.Controls.Add(this.pbCarteFace);
            this.panel1.Controls.Add(this.pbCarteArriere);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 457);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(112, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 404);
            this.panel2.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.button1.Location = new System.Drawing.Point(1315, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 41;
            this.button1.Text = "&Tutoriel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCarteProvisoire
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1475, 934);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1472, 862);
            this.Name = "frmCarteProvisoire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Athena - Carte provisoire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCarteProvisoire_FormClosed);
            this.Load += new System.EventHandler(this.frmCarteProvisoire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarteArriere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarteFace)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.ComboBox cbbSection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnnulerPhoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbCarteArriere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdtPerso;
        private System.Windows.Forms.PictureBox pbCarteFace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAjouterPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbParN;
        private System.Windows.Forms.RadioButton rdbParO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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