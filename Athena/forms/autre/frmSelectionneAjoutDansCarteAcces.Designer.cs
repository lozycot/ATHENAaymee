
namespace Athena.forms.autre
{
    partial class frmSelectionneAjoutDansCarteAcces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectionneAjoutDansCarteAcces));
            this.rdbText = new System.Windows.Forms.RadioButton();
            this.rdbCodeBarre = new System.Windows.Forms.RadioButton();
            this.rdbQRCode = new System.Windows.Forms.RadioButton();
            this.pnlChampsPersonnalises = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.numPoliceChampAjoutee = new System.Windows.Forms.NumericUpDown();
            this.btnChoisirImage = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceChampAjoutee)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbText
            // 
            this.rdbText.AutoSize = true;
            this.rdbText.Checked = true;
            this.rdbText.ForeColor = System.Drawing.Color.White;
            this.rdbText.Location = new System.Drawing.Point(3, 77);
            this.rdbText.Name = "rdbText";
            this.rdbText.Size = new System.Drawing.Size(56, 21);
            this.rdbText.TabIndex = 10;
            this.rdbText.TabStop = true;
            this.rdbText.Text = "Text";
            this.rdbText.UseVisualStyleBackColor = true;
            // 
            // rdbCodeBarre
            // 
            this.rdbCodeBarre.AutoSize = true;
            this.rdbCodeBarre.ForeColor = System.Drawing.Color.White;
            this.rdbCodeBarre.Location = new System.Drawing.Point(3, 39);
            this.rdbCodeBarre.Name = "rdbCodeBarre";
            this.rdbCodeBarre.Size = new System.Drawing.Size(101, 21);
            this.rdbCodeBarre.TabIndex = 8;
            this.rdbCodeBarre.Text = "Code Barre";
            this.rdbCodeBarre.UseVisualStyleBackColor = true;
            // 
            // rdbQRCode
            // 
            this.rdbQRCode.AutoSize = true;
            this.rdbQRCode.ForeColor = System.Drawing.Color.White;
            this.rdbQRCode.Location = new System.Drawing.Point(3, 3);
            this.rdbQRCode.Name = "rdbQRCode";
            this.rdbQRCode.Size = new System.Drawing.Size(87, 21);
            this.rdbQRCode.TabIndex = 7;
            this.rdbQRCode.Text = "Code QR";
            this.rdbQRCode.UseVisualStyleBackColor = true;
            // 
            // pnlChampsPersonnalises
            // 
            this.pnlChampsPersonnalises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlChampsPersonnalises.Location = new System.Drawing.Point(10, 8);
            this.pnlChampsPersonnalises.Name = "pnlChampsPersonnalises";
            this.pnlChampsPersonnalises.Size = new System.Drawing.Size(1148, 661);
            this.pnlChampsPersonnalises.TabIndex = 6;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlOptions.Controls.Add(this.numPoliceChampAjoutee);
            this.pnlOptions.Controls.Add(this.rdbText);
            this.pnlOptions.Controls.Add(this.rdbCodeBarre);
            this.pnlOptions.Controls.Add(this.rdbQRCode);
            this.pnlOptions.Location = new System.Drawing.Point(1174, 49);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(206, 107);
            this.pnlOptions.TabIndex = 12;
            // 
            // numPoliceChampAjoutee
            // 
            this.numPoliceChampAjoutee.Location = new System.Drawing.Point(79, 77);
            this.numPoliceChampAjoutee.Name = "numPoliceChampAjoutee";
            this.numPoliceChampAjoutee.Size = new System.Drawing.Size(120, 22);
            this.numPoliceChampAjoutee.TabIndex = 11;
            this.numPoliceChampAjoutee.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // btnChoisirImage
            // 
            this.btnChoisirImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChoisirImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoisirImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChoisirImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnChoisirImage.Location = new System.Drawing.Point(1174, 174);
            this.btnChoisirImage.Name = "btnChoisirImage";
            this.btnChoisirImage.Size = new System.Drawing.Size(206, 55);
            this.btnChoisirImage.TabIndex = 14;
            this.btnChoisirImage.Text = "Choisir une image";
            this.btnChoisirImage.UseVisualStyleBackColor = false;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(135)))));
            this.btnValider.Location = new System.Drawing.Point(1174, 596);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(206, 55);
            this.btnValider.TabIndex = 15;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmSelectionneAjoutDansCarteAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1396, 681);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnChoisirImage);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlChampsPersonnalises);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectionneAjoutDansCarteAcces";
            this.Text = "Athena - Selectionne Ajout Dans Carte d\'Acces";
            this.Load += new System.EventHandler(this.frmSelectionneAjoutDansCarteAcces_Load);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPoliceChampAjoutee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbText;
        private System.Windows.Forms.RadioButton rdbCodeBarre;
        private System.Windows.Forms.RadioButton rdbQRCode;
        private System.Windows.Forms.Panel pnlChampsPersonnalises;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.NumericUpDown numPoliceChampAjoutee;
        private System.Windows.Forms.Button btnChoisirImage;
        private System.Windows.Forms.Button btnValider;
    }
}