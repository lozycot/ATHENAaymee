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
        // Constructeur du formulaire
        public frmAccueil()
        {
            InitializeComponent(); // Initialisation des composants du formulaire
            TailleControle.SetTailleBouton(this); // Ajustement de la taille des boutons
            TailleControle.SetTailleControleTexte(this); // Ajustement de la taille du texte des contrôles
        }

        // Méthode statique pour ouvrir un formulaire enfant
        public static void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false; // Indique que le formulaire enfant n'est pas de niveau supérieur
            childForm.FormBorderStyle = FormBorderStyle.None; // Supprime la bordure du formulaire
            childForm.Dock = DockStyle.None; // Permet le défilement

            // Recherche le panneau de contenu dans le formulaire principal
            foreach (Control controle in Globale.Accueil.Controls)
            {
                if (controle is Panel && controle.Name == "pnlContent")
                {
                    var pnlContent = (Panel)controle;
                    pnlContent.Controls.Clear(); // Efface les contrôles existants dans le panneau
                    pnlContent.Controls.Add(childForm); // Ajoute le nouveau formulaire enfant
                    pnlContent.Tag = childForm; // Stocke le formulaire enfant dans le tag du panneau

                    // Positionne le formulaire au début du panneau
                    childForm.Location = new Point(0, 0);
                    childForm.AutoSize = true; // Assure que le formulaire garde sa taille d'origine
                    childForm.BringToFront(); // Amène le formulaire au premier plan
                    childForm.Show(); // Affiche le formulaire
                }
            }
        }

        // Gestionnaire d'événements pour le chargement du formulaire
        private void frmAcceuil_Load(object sender, EventArgs e)
        {
            Globale.Accueil = this; // Définit le formulaire actuel dans la classe Globale
            var etab = new frmEtablissement(); // Crée une instance du formulaire d'établissement
            etab.GetInfosCarte(); // Récupère les informations de la carte
            etab.GetLogicielEdt(); // Récupère les informations du logiciel

            this.MaximizeBox = true; // Permet de maximiser le formulaire
            this.MinimizeBox = true; // Permet de minimiser le formulaire

            // Ferme le formulaire actuel s'il existe
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();

            // Ouvre le formulaire d'importation directement
            // OuvrirFormulaire(new frmBienvenue(), "Athena - Accueil");
        }

        // Méthode pour ouvrir un formulaire
        private void OuvrirFormulaire(Form nouveauFormulaire, string titre)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close(); // Ferme le formulaire actuel
            Globale.Actuelle = nouveauFormulaire; // Définit le nouveau formulaire comme actuel
            Text = Application.ProductName + " - " + titre; // Définit le titre du formulaire
            Globale.Accueil.Invoke(new MethodInvoker(delegate { OpenChildForm(Globale.Actuelle); })); // Ouvre le nouveau formulaire
        }

        // Section Importation : Gestionnaire d'événements pour le bouton d'importation
        private void picLogo_Click(object sender, EventArgs e)
        {
            // OuvrirFormulaire(new frmBienvenue(), "Athena - Accueil");
        }

        private void btnImpInformations_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmImport(), "Importation d'Informations");
        }

        // Section Cartes d'accès : Gestionnaires d'événements pour les boutons de cartes
        private void btnCartesClasseNiveau_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmCarteParClasseNiveau(), "Carte par Classe / Niveau");
        }

        private void btnCartesListePerso_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmCartesParListe(), "Carte par Liste Personnalisée");
        }

        private void btnCarteProvisoire_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmCarteProvisoire(), "Carte Provisoire");
        }

        // Section Trombinoscopes : Gestionnaires d'événements pour les boutons de trombinoscopes
        private void btnPlancheClasse_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmPlanches(), "Planches par Classe");
        }

        // Section Autre : Gestionnaires d'événements pour les autres options
        private void btnOptions_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmOptAvancees(), "Options");
        }

        private void btnAPropos_Click(object sender, EventArgs e)
        {
            OuvrirFormulaire(new frmAPropos(), "A Propos");
        }

        // Méthodes vides : Gestionnaires d'événements non utilisés pour le moment
        private void pnlMenu_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pnlContent_Paint_1(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
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