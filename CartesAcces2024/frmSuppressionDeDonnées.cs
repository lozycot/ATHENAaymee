using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using CartesAcces2024;

namespace ATHENA
{
    public partial class frmSuppressionDeDonnées : Form
    {
        public frmSuppressionDeDonnées()
        {
            InitializeComponent();
        }

        private void frmSuppressionDeDonnées_Load(object sender, EventArgs e)
        {

        }

        private void changeAffichage()
        {
            if (rdbClasses.Checked == true)
            {
                foreach (Classe classe in Globale.ListClasses)
                {
                    //
                }
            }
            else if (rdbEleve.Checked == true)
            {
                foreach (Eleve eleve in Globale.ListeEleve)
                {
                    //
                }
            }
            else if (rdbNiveaux.Checked == true)
            {
                foreach (string classe in Globale.Classes6Eme)
                {
                    //
                }
                foreach (string classe in Globale.Classes5Eme)
                {
                    //
                }
                foreach (string classe in Globale.Classes4Eme)
                {
                    //
                }
                foreach (string classe in Globale.Classes3Eme)
                {
                    //
                }
            }
        }

        private void btnSupprimerTouteLesDonnees_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.None;
            res = MessageBox.Show("Voulez-vous vraiment supprimer toutes les données ?\n" +
                "La base de données, les photos et emplois du temps des élèves seront supprimés. Vous devrez" +
                " effectuer de nouvelles importations.", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                return;
            res = MessageBox.Show("La suppression peut prendre quelques secondes. Une fois terminée, l'application" +
                " va se fermer.", "Avertissement", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(Chemin.CheminBdd))
                        File.Delete(Chemin.CheminBdd);
                    if (Directory.Exists(Chemin.DossierEdtClassique))
                        Directory.Delete(Chemin.DossierEdtClassique, true);
                    if (Directory.Exists(Chemin.DossierPhotoEleve))
                        Directory.Delete(Chemin.DossierPhotoEleve, true);
                    if (Directory.Exists(Chemin.DossierTrombi))
                        Directory.Delete(Chemin.DossierTrombi, true);
                }
                catch (Exception err)
                {
                    MessageBox.Show("La suppression n'a pas pu se terminer : " + err.Message);
                }
                Environment.Exit(0);
            }
        }

        private void rdbNiveaux_CheckedChanged(object sender, EventArgs e)
        {
            changeAffichage();
        }

        private void rdbClasses_CheckedChanged(object sender, EventArgs e)
        {
            changeAffichage();
        }

        private void rdbEleve_CheckedChanged(object sender, EventArgs e)
        {
            changeAffichage();
        }

        private void btnToutSelectionner_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbElements.Items.Count - 1; i++)
            {
                clbElements.SetItemChecked(i, true);
            }
        }
    }
}
