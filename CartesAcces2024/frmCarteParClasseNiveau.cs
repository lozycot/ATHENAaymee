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

        private void cbbImprSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParSection = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
            {
                if (eleve.NiveauEleve == cbbImprSection.Text)
                {
                    listeEleveParSection.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }
            }


            if (cbbImprSection.SelectedItem != null)
            {
                listeEleveParSection.Sort();
                Globale.ImprNiveau = true;
                lblCount.Text = listeEleveParSection.Count.ToString();
                cbbImprClasse.SelectedItem = null;
                lsbListeEleve.DataSource = listeEleveParSection;
                btnValiderImpr.Enabled = true;
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
            }
        }

        private void frmCarteParClasseNiveau_Load(object sender, EventArgs e)
        {
            List<string> ListClasses = OperationsDb.GetClasses();
            cbbImprClasse.Items.Clear();

            foreach (var classe in ListClasses)
            {
                cbbImprClasse.Items.Add(classe);
            }
            cbbImprClasse.SelectedItem = null;
            lblCount.Text = "";
        }

        private void cbbImprClasse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();
            var listeEleveParClasse = new List<string>();
            foreach (var eleve in Globale.ListeEleve)
                if (eleve.ClasseEleve == cbbImprClasse.Text)
                {
                    listeEleveParClasse.Add(eleve.NomEleve + " " + eleve.PrenomEleve);
                    Globale.ListeEleveImpr.Add(eleve);
                }

            if (cbbImprClasse.SelectedItem != null)
            {
                cbbImprSection.SelectedItem = null;
                listeEleveParClasse.Sort();
                Globale.ImprNiveau = false;
                lblCount.Text = listeEleveParClasse.Count.ToString();
                lsbListeEleve.DataSource = listeEleveParClasse;
                btnValiderImpr.Enabled = true;
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
 