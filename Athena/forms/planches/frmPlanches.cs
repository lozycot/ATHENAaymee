/**
 * MIT License
 * 
 * Copyright (c) 2023, 2024 Collège Caroline Aigle
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
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using Athena.forms.autre;

namespace CartesAcces2024
{
    public partial class frmPlanches : Form
    {
        private static bool planchesVidesGenerees { get; set; } = false;
        private static bool trombisGeneres { get; set; } = false;

        //public static Dictionary<string, List<Eleve>> classesTemp = new Dictionary<string, List<Eleve>>();

        /// <summary>
        /// Permet de savoir si on génère des planches sur les élèves de l'année en cours ou de l'année prochaine
        /// (dossiers et tables de la base de données séparées).
        /// </summary>
        public enum mode
        {
            classesNormales,
            classesNouvelleAnnee
        }

        public static mode modeActuel = mode.classesNormales;

        public static EditionPlanche.formatPage format = EditionPlanche.formatPage.A4;

        public frmPlanches()
        {
            init();
            modeActuel = mode.classesNormales;
            updateClassesNormales();
        }

        public frmPlanches(mode mode)
        {
            init();
            if (mode == mode.classesNormales)
            {
                cbSource.SelectedIndex = 0;
                mode = mode.classesNormales;
                cbProfils.Enabled = false;
                updateClassesNormales();
            }
            else
            {
                cbSource.SelectedIndex = 1;
                mode = mode.classesNouvelleAnnee;
                cbProfils.Enabled = true;
                updateClassesTemp();
            }
        }

        private void init()
        {
            InitializeComponent();

            // Debug.Assert(Directory.GetCreationTime(Chemin.DossierTrombi) == Directory.GetCreationTime("./data/planches/"));
            if (!Directory.Exists(Chemin.DossierTrombi))
            {
                try
                {
                    Directory.CreateDirectory(Chemin.DossierTrombi);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Close();
                    return;
                }
            }            
            EditionPlanche.CreerPlanche(EditionPlanche.formatPage.A4);
            using (Image img = new Bitmap(EditionPlanche.pageWidth, EditionPlanche.pageHeight))
            {
                EditionPlanche.ResetPlanche(img, EditionPlanche.formatPage.A4);
                EditionPlanche.DessinerGrille(img, EditionPlanche.formatPage.A4);
                try
                {
                    img.Save(Chemin.CheminTrombiTemplate, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Close();
                    return;
                }
            }

            EditionPlanche.CreerPlanche(EditionPlanche.formatPage.A3);
            using (Image img = new Bitmap(EditionPlanche.pageWidthA3, EditionPlanche.pageHeightA3))
            {
                EditionPlanche.ResetPlanche(img, EditionPlanche.formatPage.A3);
                EditionPlanche.DessinerGrille(img, EditionPlanche.formatPage.A3);
                try
                {
                    img.Save(Chemin.CheminTrombiTemplateA3, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Close();
                    return;
                }
            }

            // taille d'une image A4 150ppp
            pbDocument.Size = new Size(EditionPlanche.pageWidth, EditionPlanche.pageHeight);
            pbDocument.MaximumSize = pbDocument.Size;
            pbDocument.Refresh();

            cbSource.Items.Add("Année en cours");
            cbSource.Items.Add("Nouvelle année");
            cbSource.SelectedIndex = 0;

            cbFormat.Items.Add("A4");
            cbFormat.Items.Add("A3");
            cbFormat.SelectedIndex = 0;
        }

        /// <summary>
        /// Met à jour la liste de classes pour l'année en cours.
        /// </summary>
        public void updateClassesNormales()
        {
            Globale.ListeClasses.Clear();
            Globale.ListeClasses = OperationsDb.GetClasses();
            clbElements.Items.Clear();
            foreach (var classe in Globale.ListeClasses)
            {
                clbElements.Items.Add(classe);
            }
        }

        /// <summary>
        /// Met à jour la liste des classes pour l'année prochaine.
        /// </summary>
        private void updateClassesTemp()
        {
            clbElements.Items.Clear();
            List<string> classesNA = OperationsDb.GetClassesNouvelleAnnee();
            foreach (string cl in classesNA)
            {
                clbElements.Items.Add(cl);
            }
            if (clbElements.Items.Count > 0)
            {
                clbElements.SelectedIndex = 0;
            }
        }

        private void comboBox_SelectionIndexChanged(object sender, EventArgs e)
        {
            pbDocument.Image.Dispose();
            try
            {
                pbDocument.Image = new Bitmap(Globale.DossierPlanches + cbClasse.SelectedItem + ".jpg");
                pbDocument.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// Générer les planches pour les classes sélectionnées.
        /// </summary>
        /// <param name="type">Le type de planches (vides ou trombi avec photos).</param>
        private void GenererPlanches(EditionPlanche.typePlanche type)
        {
            if (clbElements.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Vous devez d'abord sélectionner des classes !");
                return;
            }
            List<string> classes = new List<string>();
            foreach (var el in clbElements.CheckedItems)
            {
                classes.Add(el.ToString());
            }

            // libère les ressources pour pouvoir vider le dossier des images
            if (pbDocument.Image != null)
                pbDocument.Image.Dispose();
            try
            {
                pbDocument.Image = new Bitmap(Chemin.CheminTrombiTemplate);
                pbDocument.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            switch(modeActuel)
            {
                case mode.classesNormales:
                    // Debug.Assert(Directory.GetCreationTime(Chemin.DossierTrombiNorm) == Directory.GetCreationTime("./data/planches/normales/"));
                    Globale.DossierPlanches = Chemin.DossierTrombiNorm;
                    break;
                case mode.classesNouvelleAnnee:
                    // Debug.Assert(Directory.GetCreationTime(Chemin.DossierTrombiNA) == Directory.GetCreationTime("./data/planches/nouvelleAnnee/"));
                    Globale.DossierPlanches = Chemin.DossierTrombiNA;
                    break;
            }

            switch(type)
            {
                case EditionPlanche.typePlanche.plancheVide:
                    lblTitre.Text = "Planches vides :";
                    Globale.DossierPlanches += "vides/";
                    break;
                case EditionPlanche.typePlanche.trombinoscope:
                    lblTitre.Text = "Trombinoscopes :";
                    Globale.DossierPlanches += "trombinoscopes/";
                    break;
            }

            if(Globale.NomsFichiersPlanches != null)
                Globale.NomsFichiersPlanches.Clear();
            try
            {
                Globale.NomsFichiersPlanches = EditionPlanche.GenererPlanches(classes, type, format, cbProfils.Checked);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }


            // remplir le combobox classes (permet de choisir la planche à afficher)
            cbClasse.Items.Clear();
            foreach (string nm in Globale.NomsFichiersPlanches)
            {
                cbClasse.Items.Add(nm);
            }
            cbClasse.SelectedIndex = 0; // sélectionne le 1er élément
            cbClasse.Enabled = true;
            // afficher la planche
            pbDocument.Image.Dispose();
            try
            {
                pbDocument.Image = new Bitmap(Globale.DossierPlanches + cbClasse.SelectedItem + ".jpg");
                pbDocument.Refresh();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            switch(type)
            {
                case EditionPlanche.typePlanche.plancheVide:
                    planchesVidesGenerees = true;
                    break;
                case EditionPlanche.typePlanche.trombinoscope:
                    trombisGeneres = true;
                    break;
            }
            btnEnregistrer.Enabled = true;
        }

        /// <summary>
        /// Générer les planches vides des classes sélectionnées avec noms + prénoms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerer_Click(object sender, EventArgs e)
        {
            GenererPlanches(EditionPlanche.typePlanche.plancheVide);
        }

        private void frmPlanches_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(pbDocument.Image != null)
                pbDocument.Image.Dispose();
        }

        private void btnTrombi_Click(object sender, EventArgs e)
        {
            GenererPlanches(EditionPlanche.typePlanche.trombinoscope);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files Only | *.pdf";
                sfd.Title = "Enregistrer sous...";
                if (sfd.ShowDialog() == DialogResult.OK)
                    Globale.CheminDestination = sfd.FileName;
                else
                    return;
            }

            Globale.Cas = Globale.CodeCas.sauvegarderPlanchesPdf;
            frmChargement chg = new frmChargement();
            chg.StartPosition = FormStartPosition.CenterScreen;
            chg.TopMost = true;
            chg.ShowDialog();
            if (Globale.MessageFinFrmChargement != "")
                MessageBox.Show(Globale.MessageFinFrmChargement);
            else
                MessageBox.Show("Opération terminée !");
        }

        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSource.SelectedIndex == 0)
            {
                cbSource.BackColor = System.Drawing.Color.FromArgb(129, 193, 232);
                panelBdd.BackColor = System.Drawing.Color.FromArgb(0,115,186);
                modeActuel = mode.classesNormales;
                updateClassesNormales();
                btnValider.Enabled = false;
                btnValider.Visible = false;
                cbProfils.Enabled = false;
                cbProfils.Checked = false;
            }
            else
            {
                cbSource.BackColor = System.Drawing.Color.FromArgb(247, 202, 131);
                panelBdd.BackColor = System.Drawing.Color.FromArgb(247,202,131);
                modeActuel = mode.classesNouvelleAnnee;
                updateClassesTemp();
                btnValider.Enabled = true;
                btnValider.Visible = true;
                cbProfils.Enabled = true;
            }
        }

        private void btnGererClassesTemp_Click(object sender, EventArgs e)
        {
            frmModifClassesTemporaires frmmod = new frmModifClassesTemporaires();
            frmmod.StartPosition = FormStartPosition.CenterScreen;
            frmmod.ShowDialog();
            updateClassesTemp();
        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbFormat.SelectedItem)
            {
                case "A4":
                    format = EditionPlanche.formatPage.A4;
                    // taille d'une image A4 150ppp
                    pbDocument.MaximumSize = new Size(EditionPlanche.pageWidth, EditionPlanche.pageHeight);
                    pbDocument.Size = pbDocument.MaximumSize;
                    pbDocument.Refresh();
                    break;
                case "A3":
                    format = EditionPlanche.formatPage.A3;
                    // taille d'une image A3 150ppp
                    pbDocument.MaximumSize = new Size(EditionPlanche.pageWidthA3, EditionPlanche.pageHeightA3);
                    pbDocument.Size = pbDocument.MaximumSize;
                    pbDocument.Refresh();
                    break;
            }
        }

        private void tkbZoom_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (pbDocument != null)
                {
                    // redimensionne le PictureBox
                    pbDocument.Size = new Size(
                        (int)(pbDocument.MaximumSize.Width * ((float)tkbZoom.Value / 100.0)),
                        (int)(pbDocument.MaximumSize.Height * ((float)tkbZoom.Value / 100.0))
                    );
                    pbDocument.Refresh();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void clbElements_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbElements.Items.Count; i++) // déselectionné chque éléments de la liste
            {
                clbElements.SetItemChecked(i, false);
            }
        }

        private void btnToutSelectionner_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbElements.Items.Count; i++)   // sélectionner chaque éléments de la liste
            {
                clbElements.SetItemChecked(i, true);
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            frmModifClassesTemporaires frmmod = new frmModifClassesTemporaires();
            frmmod.StartPosition = FormStartPosition.CenterScreen;
            frmmod.ShowDialog();
            updateClassesTemp();
        }

        private void frmPlanches_Load(object sender, EventArgs e)
        {

        }

        private void listBoxNonSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxSel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTuto_Click(object sender, EventArgs e)
        {
            string frmName = this.GetType().Name;
            if (cbSource.SelectedIndex == 0)
            {
                frmName = frmName + 0;
            }
            else
            {
                frmName = frmName + 1;
            }
            frmTuto Tuto2 = new frmTuto(frmName);
            Tuto2.Show();
        }
    }
}
