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
    public partial class frmModifClassesTemporaires : Form
    {
        public frmModifClassesTemporaires()
        {
            InitializeComponent();
            updateClassesTemp();
            cbDeplacement.Enabled = false;
        }

        private void updateClassesTemp()
        {
            cbClassesTemp.Items.Clear();
            cbDeplacement.Items.Clear();
            List<string> classesNA = OperationsDb.GetClassesNouvelleAnnee();
            foreach (string cl in classesNA)
            {
                cbClassesTemp.Items.Add(cl);
                cbDeplacement.Items.Add(cl);
            }
            if (cbClassesTemp.Items.Count > 0)
            {
                cbClassesTemp.SelectedIndex = 0;
                cbDeplacement.SelectedIndex = 0;
                cbDeplacement.Enabled = true;
                btnAddElTemp.Enabled = true;
                btnDelClasseTemp.Enabled = true;
            }
            else
            {
                btnAddElTemp.Enabled = false;
                btnDelClasseTemp.Enabled = false;
                btnDelElTemp.Enabled = false;
            }

            if (cbClassesTemp.Items.Count > 0) // si il y as au moins une classes temporaires
            {
                if (cbClassesTemp.SelectedItem.ToString() == Globale.nom6emeSansClasse)
                {
                    btnDelClasseTemp.Enabled = false;
                }
            }
        }

        private void btnAddClasseTemp_Click(object sender, EventArgs e)
        {
            frmClasseTemporaire frm = new frmClasseTemporaire();
            frm.ShowDialog();
            if (frmClasseTemporaire.annulation || frmClasseTemporaire.classeTemp == null)
                return;

            OperationsDb.InsertUneClasseNouvelleAnneeDansBdd(frmClasseTemporaire.classeTemp);
            updateClassesTemp();

            //listBoxClassesTemp.Items.Add(frmClasseTemporaire.classeTemp + "_temp");
            //classesTemp.Add(frmClasseTemporaire.classeTemp + "_temp", new List<Eleve>());

            cbClassesTemp.SelectedItem = frmClasseTemporaire.classeTemp;
            btnDelClasseTemp.Enabled = true;
            btnAddElTemp.Enabled = true;
        }

        private void updateListBoxElTemp()
        {
            listBoxElTemp.Items.Clear();

            if (cbClassesTemp.SelectedIndex != -1)
            {
                List<Eleve> eleves = OperationsDb.GetEleveNouvelleAnnee(new Classe(cbClassesTemp.SelectedItem.ToString()));
                foreach (Eleve el in eleves)
                {
                    string fullName = el.NomEleve + " " + el.PrenomEleve;
                    listBoxElTemp.Items.Add(fullName);
                }
                listBoxElTemp.SelectedIndex = -1;
                cbDeplacement.Enabled = false;
                cbDeplacement.SelectedIndex = cbClassesTemp.SelectedIndex;
                if (listBoxElTemp.Items.Count > 0)
                {
                    btnDelElTemp.Enabled = true;
                }
                else
                {
                    btnDelElTemp.Enabled = false;
                }
            }

        }

        private void btnAddElTemp_Click(object sender, EventArgs e)
        {
            frmEleveTemporaire frm = new frmEleveTemporaire();
            frm.ShowDialog();
            if (frmEleveTemporaire.annulation)
                return;
            string nom = frmEleveTemporaire.nomTemp;
            string prenom = frmEleveTemporaire.prenomTemp;
            string fullName = nom + " " + prenom;
            string classe = cbClassesTemp.SelectedItem.ToString();

            OperationsDb.InsertUnEleveNouvelleAnneeDansBdd(new Eleve(nom, prenom, classe, classe[0] + "eme"));
            updateListBoxElTemp();
            btnDelElTemp.Enabled = true;
        }

        private void listBoxClassesTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxElTemp.Items.Clear();
            if (cbClassesTemp.SelectedIndex == -1)
            {
                if (cbClassesTemp.Items.Count == 0)
                    return;
                else
                {
                    cbClassesTemp.SelectedIndex = 0;
                    return;
                }
            }
            string classe = cbClassesTemp.SelectedItem.ToString();
            updateListBoxElTemp();
            if (listBoxElTemp.Items.Count == 0)
            {
                btnDelElTemp.Enabled = false;
            }
            else
            {
                btnDelElTemp.Enabled = true;
            }

            if (cbClassesTemp.SelectedItem.ToString() == Globale.nom6emeSansClasse)
                btnDelClasseTemp.Enabled = false;
            else
                btnDelClasseTemp.Enabled = true;
        }

        private void btnDelClasseTemp_Click(object sender, EventArgs e)
        {
            if (cbClassesTemp.Items.Count == 0 || cbClassesTemp.SelectedIndex == -1)
                return;
            string classe = cbClassesTemp.SelectedItem.ToString();
            OperationsDb.DeleteUneClasseNouvelleAnneeDansBdd(classe);
            updateClassesTemp();
        }

        private void btnDelElTemp_Click(object sender, EventArgs e)
        {
            if (listBoxElTemp.SelectedItems.Count == 0 || cbClassesTemp.Items.Count == 0)
                return;
            ListBox.SelectedObjectCollection selected = listBoxElTemp.SelectedItems;
            int nbSelected = selected.Count;
            Classe classe = new Classe(cbClassesTemp.SelectedItem.ToString());
            List<Eleve> elevesClasse = OperationsDb.GetEleveNouvelleAnnee(classe);
            for (int i = 0; i < nbSelected; i++)
            {
                int index = listBoxElTemp.Items.IndexOf(selected[i]);
                OperationsDb.DeleteUnEleveNouvelleAnneeDansBdd(elevesClasse[index]);
            }
            updateListBoxElTemp();
        }

        private void cbDeplacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDeplacement.SelectedIndex == -1 || listBoxElTemp.SelectedIndex == -1)
                return;
            ListBox.SelectedObjectCollection selected = listBoxElTemp.SelectedItems;
            int nbSelected = selected.Count;
            Classe classe = new Classe(cbClassesTemp.SelectedItem.ToString());
            List<Eleve> elevesClasse = OperationsDb.GetEleveNouvelleAnnee(classe);
            for (int i = 0; i < nbSelected; i++)
            {
                int index = listBoxElTemp.Items.IndexOf(selected[i]);
                OperationsDb.UpdateClasseUnEleveNouvelleAnneeDansBdd(elevesClasse[index], cbDeplacement.SelectedItem.ToString());
            }
            updateListBoxElTemp();
        }

        private void listBoxElTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxElTemp.SelectedIndex != -1)
            {
                cbDeplacement.Enabled = true;
            }
            else
                cbDeplacement.Enabled = false;
        }

        private void btnCsvNouvelleAnnee_Click(object sender, EventArgs e)
        {
            I_ImportService fileDialog = new ImportCsv();
            string path = fileDialog.setCheminImportation();
            Globale.CheminCsv = path;
            if (path != "failed")
            {
                readCsv.ExtraireDoneesCsv(path);
                readCsv.SetLesElevesNouvelleAnnee();
                Globale.Cas = Globale.CodeCas.insertElevesNouvelleAnneeBdd;
                frmChargement chg = new frmChargement();
                chg.updateLabel("Enregistrement des élèves, veuillez patienter...");
                chg.ShowDialog();
                if (Globale.MessageFinFrmChargement != "")
                    MessageBox.Show(Globale.MessageFinFrmChargement);
                else
                    MessageBox.Show("Opération terminée !");
            }
            cbClassesTemp.SelectedItem = Globale.nom6emeSansClasse;
            cbDeplacement.SelectedItem = Globale.nom6emeSansClasse;
            updateListBoxElTemp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
