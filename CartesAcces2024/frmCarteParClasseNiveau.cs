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
        // A ENLEVER !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void cbbImprSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Globale.ListeEleveImpr.Clear();
            //Globale.ListeEleve = OperationsDb.GetEleve();
            //var listeEleveParSection = new List<string>();
            //foreach (var eleve in Globale.ListeEleve)
            //{
            //    if (eleve.NiveauEleve == cbbImprSection.Text)
            //    {
            //        listeEleveParSection.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
            //        Globale.ListeEleveImpr.Add(eleve);
            //    }
            //}


            //if (cbbImprSection.SelectedItem != null)
            //{
            //    listeEleveParSection.Sort();
            //    Globale.ImprNiveau = true;
            //    lblCount.Text = listeEleveParSection.Count.ToString();
            //    cbbImprClasse.SelectedItem = null;
            //    lsbListeEleve.DataSource = listeEleveParSection;
            //    btnValiderImpr.Enabled = true;
            //}
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

        //private void frmcarteparclasseniveau_load(object sender, eventargs e)
        //{
        //    list<string> listclasses = operationsdb.getclasses();
        //    cbbimprclasse.items.clear();

        //    foreach (var classe in listclasses)
        //    {
        //        cbbimprclasse.items.add(classe);
        //    }
        //    cbbimprclasse.selecteditem = null;
        //    lblcount.text = "";
        //}
        //// tentative
        private void gpbTriParClasses_Enter(object sender, EventArgs e)
        {
        }
        private void frmCarteParClasseNiveau_Load(object sender, EventArgs e)
        {
            List<string> ListClasses = OperationsDb.GetClasses();
            clbClasse3eme.Items.Clear();
            clbClasse4eme.Items.Clear();
            clbClasse5eme.Items.Clear();
            clbClasse6eme.Items.Clear();

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
        // fin tentative

        // A ENLEVER !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void cbbImprClasse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Globale.ListeEleveImpr.Clear();
            //Globale.ListeEleve = OperationsDb.GetEleve();
            //var listeEleveParClasse = new List<string>();
            //foreach (var eleve in Globale.ListeEleve)
            //    if (eleve.ClasseEleve == cbbImprClasse.Text)
            //    {
            //        listeEleveParClasse.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
            //        Globale.ListeEleveImpr.Add(eleve);
            //    }

            //if (cbbImprClasse.SelectedItem != null)
            //{
            //    cbbImprSection.SelectedItem = null;
            //    listeEleveParClasse.Sort();
            //    Globale.ImprNiveau = false;
            //    lblCount.Text = listeEleveParClasse.Count.ToString();
            //    lsbListeEleve.DataSource = listeEleveParClasse;
            //    btnValiderImpr.Enabled = true;  
            //}
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
                if(pbPhoto.Image != null)
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

        private void label2_Click(object sender, EventArgs e)
        {

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
            foreach (var eleve in Globale.ListeEleve)
                if (eleve.ClasseEleve == clbClasse6eme.Text)
                {
                    listeEleveParClasse.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }

            if (clbClasse6eme.SelectedItem != null)
            {
                cbbImprSection.SelectedItem = null;
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
            while (clbClasse5eme.CheckedIndices.Count > 0)
                clbClasse5eme.SetItemChecked(clbClasse5eme.CheckedIndices[0], false);
            while (clbClasse4eme.CheckedIndices.Count > 0)
                clbClasse4eme.SetItemChecked(clbClasse4eme.CheckedIndices[0], false);
            while (clbClasse3eme.CheckedIndices.Count > 0)
                clbClasse3eme.SetItemChecked(clbClasse3eme.CheckedIndices[0], false);
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
                cbbImprSection.SelectedItem = null;
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
            while (clbClasse6eme.CheckedIndices.Count > 0)
                clbClasse6eme.SetItemChecked(clbClasse6eme.CheckedIndices[0], false);
            while (clbClasse4eme.CheckedIndices.Count > 0)
                clbClasse4eme.SetItemChecked(clbClasse4eme.CheckedIndices[0], false);
            while (clbClasse3eme.CheckedIndices.Count > 0)
                clbClasse3eme.SetItemChecked(clbClasse3eme.CheckedIndices[0], false);
        }

        private void clbClasse4eme_SelectedIndexChanged(object sender, EventArgs e)
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
                cbbImprSection.SelectedItem = null;
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
            while (clbClasse6eme.CheckedIndices.Count > 0)
                clbClasse6eme.SetItemChecked(clbClasse6eme.CheckedIndices[0], false);
            while (clbClasse5eme.CheckedIndices.Count > 0)
                clbClasse5eme.SetItemChecked(clbClasse5eme.CheckedIndices[0], false);
            while (clbClasse3eme.CheckedIndices.Count > 0)
                clbClasse3eme.SetItemChecked(clbClasse3eme.CheckedIndices[0], false);
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
                cbbImprSection.SelectedItem = null;
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
            }
            while (clbClasse6eme.CheckedIndices.Count > 0)
                clbClasse6eme.SetItemChecked(clbClasse6eme.CheckedIndices[0], false);
            while (clbClasse5eme.CheckedIndices.Count > 0)
                clbClasse5eme.SetItemChecked(clbClasse5eme.CheckedIndices[0], false);
            while (clbClasse4eme.CheckedIndices.Count > 0)
                clbClasse4eme.SetItemChecked(clbClasse4eme.CheckedIndices[0], false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbImprSection_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
                while (clbClasse6eme.CheckedIndices.Count > 0)
                    clbClasse6eme.SetItemChecked(clbClasse6eme.CheckedIndices[0], false);
                while (clbClasse5eme.CheckedIndices.Count > 0)
                    clbClasse5eme.SetItemChecked(clbClasse5eme.CheckedIndices[0], false);
                while (clbClasse4eme.CheckedIndices.Count > 0)
                    clbClasse4eme.SetItemChecked(clbClasse4eme.CheckedIndices[0], false);
                while (clbClasse3eme.CheckedIndices.Count > 0)
                    clbClasse3eme.SetItemChecked(clbClasse3eme.CheckedIndices[0], false);
                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
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
                while (clbClasse6eme.CheckedIndices.Count > 0)
                    clbClasse6eme.SetItemChecked(clbClasse6eme.CheckedIndices[0], false);
                while (clbClasse5eme.CheckedIndices.Count > 0)
                    clbClasse5eme.SetItemChecked(clbClasse5eme.CheckedIndices[0], false);
                while (clbClasse4eme.CheckedIndices.Count > 0)
                    clbClasse4eme.SetItemChecked(clbClasse4eme.CheckedIndices[0], false);
                while (clbClasse3eme.CheckedIndices.Count > 0)
                    clbClasse3eme.SetItemChecked(clbClasse3eme.CheckedIndices[0], false);
                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
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
                while (clbClasse6eme.CheckedIndices.Count > 0)
                    clbClasse6eme.SetItemChecked(clbClasse6eme.CheckedIndices[0], false);
                while (clbClasse5eme.CheckedIndices.Count > 0)
                    clbClasse5eme.SetItemChecked(clbClasse5eme.CheckedIndices[0], false);
                while (clbClasse4eme.CheckedIndices.Count > 0)
                    clbClasse4eme.SetItemChecked(clbClasse4eme.CheckedIndices[0], false);
                while (clbClasse3eme.CheckedIndices.Count > 0)
                    clbClasse3eme.SetItemChecked(clbClasse3eme.CheckedIndices[0], false);
                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
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
                while (clbClasse6eme.CheckedIndices.Count > 0)
                    clbClasse6eme.SetItemChecked(clbClasse6eme.CheckedIndices[0], false);
                while (clbClasse5eme.CheckedIndices.Count > 0)
                    clbClasse5eme.SetItemChecked(clbClasse5eme.CheckedIndices[0], false);
                while (clbClasse4eme.CheckedIndices.Count > 0)
                    clbClasse4eme.SetItemChecked(clbClasse4eme.CheckedIndices[0], false);
                while (clbClasse3eme.CheckedIndices.Count > 0)
                    clbClasse3eme.SetItemChecked(clbClasse3eme.CheckedIndices[0], false);
                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
            }
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
 