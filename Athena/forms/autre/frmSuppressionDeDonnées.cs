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
            //Globale.ListeClasses.Clear();       // on récupère tout les élèves et toute les classes
            //Globale.ListeEleve.Clear();           // fait dans changeAffichage(), comme c'est systématique
            //Globale.ListeClasses = OperationsDb.GetClasses();
            //Globale.ListeEleve = OperationsDb.GetEleve();
            changeAffichage(); // on met a jour l'affichage
        }

        /// <summary>
        /// rafraichit l'affichage selon les options cochées et les éléments présents dans la base de données.
        /// </summary>
        private void changeAffichage()
        {
            Globale.ListeClasses.Clear();       // on récupère tout les élèves et toute les classes
            Globale.ListeEleve.Clear();
            Globale.ListeClasses = OperationsDb.GetClasses();
            Globale.ListeEleve = OperationsDb.GetEleve();

            if (rdbClasses.Checked == true) //selon l'option sélectionnée
            {
                clbElements.Items.Clear();  //on vide les éléments affiché
                                            // pour ne pas supprimer des éléments qui ne sont pas affichés
                foreach (string clss in Globale.ListeClasses)   // on ajouter les éléments concernés
                {
                    clbElements.Items.Add(clss);
                }
            }
            else if (rdbEleve.Checked == true)
            {
                clbElements.Items.Clear();
                foreach (Eleve elv in Globale.ListeEleve)
                {
                    clbElements.Items.Add(elv.NomEleve + " " + elv.PrenomEleve);
                }
            }
            else if (rdbNiveaux.Checked == true)
            {
                clbElements.Items.Clear();      //pour les niveaux de base, on les ajoutes manuellements
                Globale.ListeEleves6Eme = OperationsDb.GetEleve("6");
                Globale.ListeEleves5Eme = OperationsDb.GetEleve("5");
                Globale.ListeEleves4Eme = OperationsDb.GetEleve("4");
                Globale.ListeEleves3Eme = OperationsDb.GetEleve("3");
                if (Globale.ListeEleves6Eme.Count > 0)
                {
                    clbElements.Items.Add("6eme");  // le formas des strings ('6eme') doit correspondre à ce format; nNiveau + 'eme'
                                                    // c'est de cette manière qu'il sont enregistrés dans la base de données SQLite
                }
                if (Globale.ListeEleves5Eme.Count > 0)
                {
                    clbElements.Items.Add("5eme");
                }
                if (Globale.ListeEleves4Eme.Count > 0)
                {
                    clbElements.Items.Add("4eme");
                }
                if (Globale.ListeEleves3Eme.Count > 0)
                {
                    clbElements.Items.Add("3eme");
                }
                // rajouter les dispositifs spéciaux?
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
            changeAffichage();  // recharge l'affichage à chaque coche d'un radiobouton
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
            for (int i = 0; i < clbElements.Items.Count - 1; i++)   // sélectionner chaque éléments de la liste
            {
                clbElements.SetItemChecked(i, true);
            }
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbElements.Items.Count - 1; i++) // déselectionné chque éléments de la liste
            {
                clbElements.SetItemChecked(i, false);
            }
        }

        private void btnSupprimerLesDonneesSelectionnees_Click(object sender, EventArgs e)
        {
            if (rdbClasses.Checked == true) // selon le radiobouton sélectionné
            {
                foreach(string clss in clbElements.CheckedItems)    // on regarde chaque élément concerné qui est coché
                {
                    OperationsDb.deleteUneClasse(clss); // on effectue les opérations
                }
            }
            else if (rdbEleve.Checked == true)
            {
                for(int i = 0; i < Globale.ListeEleve.Count - 1; i++)   // pour chaque élève dans la base de donnée
                {
                    // si les éléments cochés continents l'élève (son nom + prénom comme dans la methode changeAffichage)
                    if (clbElements.CheckedItems.Contains(Globale.ListeEleve[i].NomEleve + " " + Globale.ListeEleve[i].PrenomEleve))
                    {
                        // on supprime cet élève
                        OperationsDb.DeleteUnEleve(Globale.ListeEleve[i]);
                    }
                }
            }
            else if (rdbNiveaux.Checked == true)
            {
                foreach(string niv in clbElements.CheckedItems)
                {
                    OperationsDb.deleteUnNiveau(niv);
                }
            }

            // puis on met à jour l'affichage à la fin de la suppression
            changeAffichage();
        }
    }
}
