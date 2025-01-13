using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CartesAcces2024
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
            TailleControle.SetTailleBouton(this);
            TailleControle.SetTailleControleTexte(this);
        }

        public static void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // pour faire stylax
            childForm.Dock = DockStyle.Fill; // le WF appelé va prendre tout l'espace du panel  
            foreach (Control controle in Globale.Accueil.Controls)
                if (controle is Panel && controle.Name == "pnlContent")
                {
                    var pnlContent = (Panel)controle;
                    pnlContent.Controls.Clear();
                    pnlContent.Controls.Add(childForm);
                    pnlContent.Tag = childForm;
                    childForm.BringToFront(); // ramène la WF appélé en avant-plan pour une WF déjà appelé
                    childForm.Show(); // lorsque la WF est appelé pour la première fois
                }
        }
        private void frmAcceuil_Load(object sender, EventArgs e)
        {
            Globale.Accueil = this;
            var etab = new frmEtablissement();
            etab.GetInfosCarte();
            etab.GetLogicielEdt();
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmImport();
            Text = "ATHENA - IMPORTATION";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // A CHANGER
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmImport();
            Text = "ATHENA - Accueil";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }


        private void btnCreerCarte_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmCarteProvisoire();
            Text = "ATHENA - CARTE PROVISOIRE";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }

        private void btnParametres_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmImport();
            Text = "ATHENA - IMPORTATION";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAfficheListeEleve_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmCartesParListe();
            Text = "ATHENA - CARTE PAR LISTE";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }

        private void btnCarteParClasse_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmCarteParClasseNiveau();
            Text = "ATHENA - CARTE PAR LISTE";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }

        private void btnChangeMdp_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            frmOptAvancees opt = new frmOptAvancees();
            OpenChildForm(opt);
        }

        private void btnPlanche_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmPlanches();
            Text = "ATHENA - TROMBINOSCOPES PHOTOS";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }

        private void btnNouvelleAnnee_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmPlanches(frmPlanches.mode.classesNouvelleAnnee);
            Text = "ATHENA - NOUVELLE ANNEE";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }

        private void pnlContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAPropos_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            Globale.Actuelle = new frmAPropos();
            Text = "ATHENA - A PROPOS";
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); }));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
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
