using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CartesAcces2024
{
    /// <summary>
    /// Permet de créer des cartes d'accès par classe et niveau
    /// </summary>
    public partial class frmCarteParClasseNiveau : Form
    {
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public frmCarteParClasseNiveau()
        {
            InitializeComponent();
            //Couleur.setCouleurFenetre(this);

        }

        private void btnValiderImpr_Click(object sender, EventArgs e)
        {
            try
            {
                var frmMultiplesCartesEdition = new FrmMultiplesCartesEdition();

                frmMultiplesCartesEdition.Show();

            }
            catch
            {
            }
        }

        private void gpbTriParClasses_Enter(object sender, EventArgs e)
        {
        }
        private void frmCarteParClasseNiveau_Load(object sender, EventArgs e)
        {
            List<string> ListClasses = OperationsDb.GetClasses();

            foreach (var classe in ListClasses)
            {
                if (classe.StartsWith("3"))
                    clbClasse3eme.Items.Add(classe);
                else if (classe.StartsWith("4"))
                    clbClasse4eme.Items.Add(classe);
                else if (classe.StartsWith("5"))
                    clbClasse5eme.Items.Add(classe);
                else if (classe.StartsWith("6"))
                    clbClasse6eme.Items.Add(classe);
            }
        }

        private void lsbListeEleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            List<Eleve> lstEl = new List<Eleve>();
            string txt = lsbListeEleve.SelectedItem.ToString();

            foreach (var eleve in Globale.ListeEleve)
                if (eleve.NomEleve + " " + eleve.PrenomEleve == txt)
                {
                    lstEl.Add(eleve);
                }
            string path = Chemin.DossierPhotoEleve + lstEl[0].NiveauEleve + "/";
            var rc = new Recherche_Image(path);
            if (pbPhoto.Image != null)
                pbPhoto.Image.Dispose();
            try
            {
                pbPhoto.Image = rc.SearchImageByName(lstEl[0].NomEleve, lstEl[0].PrenomEleve);
                if (pbPhoto.Image != null)
                {
                    double ratio = (double)pbPhoto.Image.Width / (double)pbPhoto.Image.Height;
                    pbPhoto.Width = (int)((double)pbPhoto.Height * ratio);
                }
            }
            catch
            {
                pbPhoto.Image = Image.FromFile(Chemin.CheminPhotoDefault);
            }
        }

        private void frmCarteParClasseNiveau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pbPhoto.Image != null)
                pbPhoto.Image.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e) // groupbox type de filtrage classe ou niveau
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void clbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParClasse = new List<string>();

            foreach (var classe in clbClasse6eme.CheckedItems)
            {
                foreach (var eleve in Globale.ListeEleve)
                    if (eleve.ClasseEleve == classe.ToString())
                    {
                        listeEleveParClasse.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                        Globale.ListeEleveImpr.Add(eleve);
                    }
            }

            if (clbClasse6eme.CheckedItems.Count > 0)
            {
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
        }

        private void clbClasse5eme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParClasse = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
                if (eleve.ClasseEleve == clbClasse5eme.Text)
                {
                    listeEleveParClasse.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }

            if (clbClasse5eme.SelectedItem != null)
            {
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
        }
        private void clbClasse4eme_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParClasse = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
                if (eleve.ClasseEleve == clbClasse4eme.Text)
                {
                    listeEleveParClasse.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }

            if (clbClasse4eme.SelectedItem != null)
            {
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
        }

        private void clbClasse3eme_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParClasse = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
                if (eleve.ClasseEleve == clbClasse3eme.Text)
                {
                    listeEleveParClasse.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }

            if (clbClasse3eme.SelectedItem != null)
            {
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
        }

        private void NbComptageEleveCS_Click(object sender, EventArgs e)
        {

        }

        private void cbxNiveau6eme_CheckedChanged(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParSection = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
            {
                if (eleve.NiveauEleve == cbxNiveau6eme.Text)
                {
                    listeEleveParSection.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }
            }


            if (cbxNiveau6eme.Checked == true)
            {
                listeEleveParSection.Sort();
                Globale.ImprNiveau = true;
                lblCount.Text = listeEleveParSection.Count.ToString();
                for (int i = 0; i < clbClasse6eme.Items.Count; i++)
                    clbClasse6eme.SetItemChecked(i, true);

                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
            }
            else
            {
                for (int i = 0; i < clbClasse6eme.Items.Count; i++)
                    clbClasse6eme.SetItemChecked(i, false);
            }
        }

        private void cbxNiveau5eme_CheckedChanged(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParSection = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
            {
                if (eleve.NiveauEleve == cbxNiveau5eme.Text)
                {
                    listeEleveParSection.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }
            }


            if (cbxNiveau5eme.Checked == true)
            {
                listeEleveParSection.Sort();
                Globale.ImprNiveau = true;
                lblCount.Text = listeEleveParSection.Count.ToString();
                for (int i = 0; i < clbClasse5eme.Items.Count; i++)
                    clbClasse5eme.SetItemChecked(i, true);

                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
            }
            else
            {
                for (int i = 0; i < clbClasse5eme.Items.Count; i++)
                    clbClasse5eme.SetItemChecked(i, false);
            }
        }

        private void cbxNiveau4eme_CheckedChanged(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParSection = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
            {
                if (eleve.NiveauEleve == cbxNiveau4eme.Text)
                {
                    listeEleveParSection.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }
            }


            if (cbxNiveau4eme.Checked == true)
            {
                listeEleveParSection.Sort();
                Globale.ImprNiveau = true;
                lblCount.Text = listeEleveParSection.Count.ToString();
                for (int i = 0; i < clbClasse4eme.Items.Count; i++)
                    clbClasse4eme.SetItemChecked(i, true);

                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
            }
            else
            {
                for (int i = 0; i < clbClasse4eme.Items.Count; i++)
                    clbClasse4eme.SetItemChecked(i, false);
            }
        }

        private void cbxNiveau3eme_CheckedChanged(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParSection = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
            {
                if (eleve.NiveauEleve == cbxNiveau3eme.Text)
                {
                    listeEleveParSection.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }
            }


            if (cbxNiveau3eme.Checked == true)
            {
                listeEleveParSection.Sort();
                Globale.ImprNiveau = true;
                lblCount.Text = listeEleveParSection.Count.ToString();
                for (int i = 0; i < clbClasse3eme.Items.Count; i++)
                    clbClasse3eme.SetItemChecked(i, true);

                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
            }
            else
            {
                for (int i = 0; i < clbClasse3eme.Items.Count; i++)
                    clbClasse3eme.SetItemChecked(i, false);
            }
        }

    }
}