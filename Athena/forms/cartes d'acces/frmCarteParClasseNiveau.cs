using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace CartesAcces2024
{
    public partial class frmCarteParClasseNiveau : Form
    {
        private Dictionary<string, (CheckBox niveau, CheckedListBox classes)> niveauControls;

        public frmCarteParClasseNiveau()
        {
            InitializeComponent();

            // Détacher les anciens événements du designer si nécessaire
            cbxNiveau6eme.CheckedChanged -= cbxNiveau6eme_CheckedChanged;
            cbxNiveau5eme.CheckedChanged -= cbxNiveau5eme_CheckedChanged;
            cbxNiveau4eme.CheckedChanged -= cbxNiveau4eme_CheckedChanged;
            cbxNiveau3eme.CheckedChanged -= cbxNiveau3eme_CheckedChanged;

            clbClasse6eme.SelectedIndexChanged -= clbClasses_SelectedIndexChanged;
            clbClasse5eme.SelectedIndexChanged -= clbClasse5eme_SelectedIndexChanged;
            clbClasse4eme.SelectedIndexChanged -= clbClasse4eme_SelectedIndexChanged_1;
            clbClasse3eme.SelectedIndexChanged -= clbClasse3eme_SelectedIndexChanged;

            InitializeNiveauControls();
        }

        private void InitializeNiveauControls()
        {
            // Associe chaque niveau avec ses contrôles correspondants
            niveauControls = new Dictionary<string, (CheckBox niveau, CheckedListBox classes)>
            {
                { "6eme", (cbxNiveau6eme, clbClasse6eme) },
                { "5eme", (cbxNiveau5eme, clbClasse5eme) },
                { "4eme", (cbxNiveau4eme, clbClasse4eme) },
                { "3eme", (cbxNiveau3eme, clbClasse3eme) }
            };

            // Attache les nouveaux événements pour tous les contrôles
            foreach (var kvp in niveauControls)
            {
                var controls = kvp.Value;
                controls.niveau.CheckedChanged += NiveauCheckBox_CheckedChanged;
                controls.classes.ItemCheck += ClassesCheckedListBox_ItemCheck;
            }
        }

        private void frmCarteParClasseNiveau_Load(object sender, EventArgs e)
        {
            List<string> ListClasses = OperationsDb.GetClasses();

            foreach (var classe in ListClasses)
            {
                foreach (var kvp in niveauControls)
                {
                    string niveau = kvp.Key;
                    // On convertit "6eme" en "6" pour la comparaison
                    char niveauChar = niveau[0];
                    if (classe.StartsWith(niveauChar.ToString()))
                    {
                        kvp.Value.classes.Items.Add(classe);
                        break;
                    }
                }
            }
        }

        private void NiveauCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var cbxNiveau = (CheckBox)sender;
            var niveau = niveauControls.First(x => x.Value.niveau == cbxNiveau);
            var clbClasses = niveau.Value.classes;

            // Coche/décoche toutes les classes du niveau
            for (int i = 0; i < clbClasses.Items.Count; i++)
            {
                clbClasses.SetItemChecked(i, cbxNiveau.Checked);
            }

            // Met à jour le statut d'impression par niveau
            Globale.ImprNiveau = cbxNiveau.Checked;

            RefreshListeEleves();
        }

        private void ClassesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Utilise BeginInvoke pour s'assurer que l'état des cases est à jour
            BeginInvoke(new Action(() =>
            {
                var clbClasses = (CheckedListBox)sender;
                var niveau = niveauControls.First(x => x.Value.classes == clbClasses);
                var cbxNiveau = niveau.Value.niveau;

                // Vérifie si toutes les classes sont cochées/décochées
                bool allChecked = true;
                bool allUnchecked = true;

                for (int i = 0; i < clbClasses.Items.Count; i++)
                {
                    bool isChecked = i == e.Index ? e.NewValue == CheckState.Checked : clbClasses.GetItemChecked(i);
                    allChecked &= isChecked;
                    allUnchecked &= !isChecked;
                }

                // Met à jour l'état du checkbox niveau
                cbxNiveau.Checked = allChecked;
                if (allUnchecked) cbxNiveau.Checked = false;

                // Met à jour le statut d'impression par niveau
                Globale.ImprNiveau = false;

                RefreshListeEleves();
            }));
        }

        private void RefreshListeEleves()
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParClasse = new List<string>();

            // Parcourt tous les niveaux et leurs classes cochées
            foreach (var kvp in niveauControls)
            {
                foreach (var classe in kvp.Value.classes.CheckedItems)
                {
                    foreach (var eleve in Globale.ListeEleve)
                    {
                        if (eleve.ClasseEleve == classe.ToString())
                        {
                            listeEleveParClasse.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                            Globale.ListeEleveImpr.Add(eleve);
                        }
                    }
                }
            }

            if (listeEleveParClasse.Count > 0)
            {
                listeEleveParClasse.Sort();
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
            else
            {
                lsbListeEleve.DataSource = null;
                lblCount.Text = "0";
                btnValiderImpr.Enabled = false;
            }
        }

        private void lsbListeEleve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbListeEleve.SelectedItem == null) return;

            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            string txt = lsbListeEleve.SelectedItem.ToString();
            var selectedEleve = Globale.ListeEleve.FirstOrDefault(
                eleve => eleve.NomEleve + " " + eleve.PrenomEleve == txt);

            if (selectedEleve != null)
            {
                UpdatePhotoEleve(selectedEleve);
            }
        }

        private void UpdatePhotoEleve(Eleve eleve)
        {
            if (pbPhoto.Image != null)
            {
                pbPhoto.Image.Dispose();
                pbPhoto.Image = null;
            }

            try
            {
                string path = Chemin.DossierPhotoEleve + eleve.NiveauEleve + "/";
                var rc = new Recherche_Image(path);
                pbPhoto.Image = rc.SearchImageByName(eleve.NomEleve, eleve.PrenomEleve);

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

        private void btnValiderImpr_Click(object sender, EventArgs e)
        {
            try
            {
                var frmMultiplesCartesEdition = new FrmMultiplesCartesEdition();
                frmMultiplesCartesEdition.Show();
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue lors de l'ouverture de la fenêtre d'impression.",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCarteParClasseNiveau_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pbPhoto.Image != null)
            {
                pbPhoto.Image.Dispose();
            }
        }

        // Ces méthodes vides sont nécessaires si elles sont liées dans le designer
        private void gpbTriParClasses_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void lblCount_Click(object sender, EventArgs e) { }
        private void NbComptageEleveCS_Click(object sender, EventArgs e) { }

        // Gardez ces méthodes si elles sont liées dans le designer, mais elles ne feront rien
        private void cbxNiveau6eme_CheckedChanged(object sender, EventArgs e) { }
        private void cbxNiveau5eme_CheckedChanged(object sender, EventArgs e) { }
        private void cbxNiveau4eme_CheckedChanged(object sender, EventArgs e) { }
        private void cbxNiveau3eme_CheckedChanged(object sender, EventArgs e) { }
        private void clbClasses_SelectedIndexChanged(object sender, EventArgs e) { }
        private void clbClasse5eme_SelectedIndexChanged(object sender, EventArgs e) { }
        private void clbClasse4eme_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void clbClasse3eme_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}