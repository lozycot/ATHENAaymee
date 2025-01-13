
namespace ATHENA
{
    partial class frmSuppressionDeDonnées
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnToutSelectionner = new System.Windows.Forms.Button();
            this.btnSupprimerTouteLesDonnees = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.gbpElements = new System.Windows.Forms.GroupBox();
            this.clbElements = new System.Windows.Forms.CheckedListBox();
            this.gbpFiltres = new System.Windows.Forms.GroupBox();
            this.rdbNiveaux = new System.Windows.Forms.RadioButton();
            this.rdbClasses = new System.Windows.Forms.RadioButton();
            this.rdbEleve = new System.Windows.Forms.RadioButton();
            this.gbpElements.SuspendLayout();
            this.gbpFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(857, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(436, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "🗑 Supprimer les données sélectionnées";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnToutSelectionner
            // 
            this.btnToutSelectionner.Location = new System.Drawing.Point(857, 204);
            this.btnToutSelectionner.Name = "btnToutSelectionner";
            this.btnToutSelectionner.Size = new System.Drawing.Size(198, 23);
            this.btnToutSelectionner.TabIndex = 11;
            this.btnToutSelectionner.Text = "Tout sélectionner";
            this.btnToutSelectionner.UseVisualStyleBackColor = true;
            this.btnToutSelectionner.Click += new System.EventHandler(this.btnToutSelectionner_Click);
            // 
            // btnSupprimerTouteLesDonnees
            // 
            this.btnSupprimerTouteLesDonnees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupprimerTouteLesDonnees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupprimerTouteLesDonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSupprimerTouteLesDonnees.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimerTouteLesDonnees.Location = new System.Drawing.Point(857, 134);
            this.btnSupprimerTouteLesDonnees.Name = "btnSupprimerTouteLesDonnees";
            this.btnSupprimerTouteLesDonnees.Size = new System.Drawing.Size(341, 49);
            this.btnSupprimerTouteLesDonnees.TabIndex = 10;
            this.btnSupprimerTouteLesDonnees.Text = "🗑 Supprimer toutes les données";
            this.btnSupprimerTouteLesDonnees.UseVisualStyleBackColor = false;
            this.btnSupprimerTouteLesDonnees.Click += new System.EventHandler(this.btnSupprimerTouteLesDonnees_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(857, 105);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(89, 23);
            this.btnReinitialiser.TabIndex = 9;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            // 
            // gbpElements
            // 
            this.gbpElements.Controls.Add(this.clbElements);
            this.gbpElements.ForeColor = System.Drawing.Color.White;
            this.gbpElements.Location = new System.Drawing.Point(74, 213);
            this.gbpElements.Name = "gbpElements";
            this.gbpElements.Size = new System.Drawing.Size(575, 270);
            this.gbpElements.TabIndex = 8;
            this.gbpElements.TabStop = false;
            this.gbpElements.Text = "TexteElementFiltre";
            // 
            // clbElements
            // 
            this.clbElements.FormattingEnabled = true;
            this.clbElements.Location = new System.Drawing.Point(6, 21);
            this.clbElements.Name = "clbElements";
            this.clbElements.Size = new System.Drawing.Size(563, 242);
            this.clbElements.TabIndex = 0;
            // 
            // gbpFiltres
            // 
            this.gbpFiltres.Controls.Add(this.rdbNiveaux);
            this.gbpFiltres.Controls.Add(this.rdbClasses);
            this.gbpFiltres.Controls.Add(this.rdbEleve);
            this.gbpFiltres.ForeColor = System.Drawing.Color.White;
            this.gbpFiltres.Location = new System.Drawing.Point(74, 57);
            this.gbpFiltres.Name = "gbpFiltres";
            this.gbpFiltres.Size = new System.Drawing.Size(575, 150);
            this.gbpFiltres.TabIndex = 7;
            this.gbpFiltres.TabStop = false;
            this.gbpFiltres.Text = "Filtres";
            // 
            // rdbNiveaux
            // 
            this.rdbNiveaux.AutoSize = true;
            this.rdbNiveaux.Location = new System.Drawing.Point(181, 31);
            this.rdbNiveaux.Name = "rdbNiveaux";
            this.rdbNiveaux.Size = new System.Drawing.Size(79, 21);
            this.rdbNiveaux.TabIndex = 2;
            this.rdbNiveaux.TabStop = true;
            this.rdbNiveaux.Text = "Niveaux";
            this.rdbNiveaux.UseVisualStyleBackColor = true;
            this.rdbNiveaux.CheckedChanged += new System.EventHandler(this.rdbNiveaux_CheckedChanged);
            // 
            // rdbClasses
            // 
            this.rdbClasses.AutoSize = true;
            this.rdbClasses.Location = new System.Drawing.Point(97, 31);
            this.rdbClasses.Name = "rdbClasses";
            this.rdbClasses.Size = new System.Drawing.Size(78, 21);
            this.rdbClasses.TabIndex = 1;
            this.rdbClasses.TabStop = true;
            this.rdbClasses.Text = "Classes";
            this.rdbClasses.UseVisualStyleBackColor = true;
            this.rdbClasses.CheckedChanged += new System.EventHandler(this.rdbClasses_CheckedChanged);
            // 
            // rdbEleve
            // 
            this.rdbEleve.AutoSize = true;
            this.rdbEleve.Location = new System.Drawing.Point(20, 31);
            this.rdbEleve.Name = "rdbEleve";
            this.rdbEleve.Size = new System.Drawing.Size(71, 21);
            this.rdbEleve.TabIndex = 0;
            this.rdbEleve.TabStop = true;
            this.rdbEleve.Text = "Eleves";
            this.rdbEleve.UseVisualStyleBackColor = true;
            this.rdbEleve.CheckedChanged += new System.EventHandler(this.rdbEleve_CheckedChanged);
            // 
            // frmSuppressionDeDonnées
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1366, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnToutSelectionner);
            this.Controls.Add(this.btnSupprimerTouteLesDonnees);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.gbpElements);
            this.Controls.Add(this.gbpFiltres);
            this.Name = "frmSuppressionDeDonnées";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuppressionDeDonnées";
            this.Load += new System.EventHandler(this.frmSuppressionDeDonnées_Load);
            this.gbpElements.ResumeLayout(false);
            this.gbpFiltres.ResumeLayout(false);
            this.gbpFiltres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnToutSelectionner;
        private System.Windows.Forms.Button btnSupprimerTouteLesDonnees;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.GroupBox gbpElements;
        private System.Windows.Forms.CheckedListBox clbElements;
        private System.Windows.Forms.GroupBox gbpFiltres;
        private System.Windows.Forms.RadioButton rdbNiveaux;
        private System.Windows.Forms.RadioButton rdbClasses;
        private System.Windows.Forms.RadioButton rdbEleve;
    }
}