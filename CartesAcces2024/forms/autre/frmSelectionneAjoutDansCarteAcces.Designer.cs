
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
            this.btnValider = new System.Windows.Forms.Button();
            this.rdbText = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbCodeBarre = new System.Windows.Forms.RadioButton();
            this.rdbQRCode = new System.Windows.Forms.RadioButton();
            this.pnlChampsPersonnalises = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(1159, 609);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(200, 35);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // rdbText
            // 
            this.rdbText.AutoSize = true;
            this.rdbText.Checked = true;
            this.rdbText.ForeColor = System.Drawing.Color.White;
            this.rdbText.Location = new System.Drawing.Point(1, 115);
            this.rdbText.Name = "rdbText";
            this.rdbText.Size = new System.Drawing.Size(56, 21);
            this.rdbText.TabIndex = 10;
            this.rdbText.TabStop = true;
            this.rdbText.Text = "Text";
            this.rdbText.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1159, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Choisir une image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rdbCodeBarre
            // 
            this.rdbCodeBarre.AutoSize = true;
            this.rdbCodeBarre.ForeColor = System.Drawing.Color.White;
            this.rdbCodeBarre.Location = new System.Drawing.Point(1, 77);
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
            this.rdbQRCode.Location = new System.Drawing.Point(1, 41);
            this.rdbQRCode.Name = "rdbQRCode";
            this.rdbQRCode.Size = new System.Drawing.Size(87, 21);
            this.rdbQRCode.TabIndex = 7;
            this.rdbQRCode.Text = "Code QR";
            this.rdbQRCode.UseVisualStyleBackColor = true;
            // 
            // pnlChampsPersonnalises
            // 
            this.pnlChampsPersonnalises.Location = new System.Drawing.Point(5, 8);
            this.pnlChampsPersonnalises.Name = "pnlChampsPersonnalises";
            this.pnlChampsPersonnalises.Size = new System.Drawing.Size(1148, 661);
            this.pnlChampsPersonnalises.TabIndex = 6;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.rdbText);
            this.pnlOptions.Controls.Add(this.rdbCodeBarre);
            this.pnlOptions.Controls.Add(this.rdbQRCode);
            this.pnlOptions.Location = new System.Drawing.Point(1158, 72);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(200, 145);
            this.pnlOptions.TabIndex = 12;
            // 
            // frmSelectionneAjoutDansCarteAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1481, 681);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlChampsPersonnalises);
            this.Name = "frmSelectionneAjoutDansCarteAcces";
            this.Text = "frmSelectionneAjoutDansCarteAcces";
            this.Load += new System.EventHandler(this.frmSelectionneAjoutDansCarteAcces_Load);
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.RadioButton rdbText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbCodeBarre;
        private System.Windows.Forms.RadioButton rdbQRCode;
        private System.Windows.Forms.Panel pnlChampsPersonnalises;
        private System.Windows.Forms.Panel pnlOptions;
    }
}