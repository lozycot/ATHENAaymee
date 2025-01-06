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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CartesAcces2024
{
    public partial class frmCartesParListe : Form
    {
        /// <summary>
        /// Liste des élèves
        /// </summary>
        public static List<Eleve> ListeEleve;
        /// <summary>
        /// Liste des élèves sélectionnés
        /// </summary>
        public static List<string> EleveSelectionner;
        /// <summary>
        /// Liste des noms et prénoms des élèves
        /// </summary>
        public static List<string> NomPrenomEleve;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public frmCartesParListe()
        {
            InitializeComponent();
            //Couleur.setCouleurFenetre(this);
        }

        /// <summary>
        /// Convertit la liste des élèves en une liste de string
        /// </summary>
        public static void EleveEnString()
        {
            foreach (var eleve in ListeEleve)
                NomPrenomEleve.Add(eleve.NomEleve + " " + eleve.PrenomEleve + " " + eleve.ClasseEleve);
        }

        public static class XTrie
        {
            /// <summary>
            /// Cette fonction permet de rechercher un eleve dans la liste des eleves
            /// Elle prend en parametre le filtre de recherche et la liste des eleves
            /// </summary>
            /// <param name="filtre"></param>
            /// <param name="eleves"></param>
            /// <returns></returns>
            public static List<string> Recherche(string filtre, List<Eleve> eleves)
            {
                var listeEleveResultat = new List<string>();
                var regex = new Regex(filtre.ToLower());
                foreach (var eleve in eleves)
                {
                    var nomPrenom = eleve.NomEleve + " " + eleve.PrenomEleve;
                    nomPrenom = nomPrenom.ToLower();
                    var match = regex.Match(nomPrenom);
                    if (match.Success)
                        listeEleveResultat.Add(eleve.NomEleve + " " + eleve.PrenomEleve + " " + eleve.ClasseEleve);
                }

                return listeEleveResultat;
            }
        }

        private void frmCartesParListe_Load(object sender, EventArgs e)
        {
            try
            {
                EleveSelectionner = new List<string>();
                NomPrenomEleve = new List<string>();
                Globale.ListeEleve = OperationsDb.GetEleve();
                ListeEleve = Globale.ListeEleve;
                EleveEnString();
                lblCount.Text = NomPrenomEleve.Count.ToString();
                Eleves.DataSource = NomPrenomEleve;
                btnAjout.Click += AjoutEleve;
                btnRetirer.Click += RetirerEleve;
                txtRecherche.TextChanged += Recheche;
                Globale.ListeEleves6Eme = new List<Eleve>();
                Globale.ListeEleves5Eme = new List<Eleve>();
                Globale.ListeEleves4Eme = new List<Eleve>();
                Globale.ListeEleves3Eme = new List<Eleve>();
                foreach (Control VARIABLE in groupBox1.Controls) (VARIABLE as RadioButton).CheckedChanged += RbChanged;

                Globale.ListeEleves6Eme = OperationsDb.GetEleve("6");
                Globale.ListeEleves5Eme = OperationsDb.GetEleve("5");
                Globale.ListeEleves4Eme = OperationsDb.GetEleve("4");
                Globale.ListeEleves3Eme = OperationsDb.GetEleve("3");
            }
            catch
            {
            }
        }

        private bool VerifDoublon(string ajout)
        {
            foreach (string selectioner in Impression.Items)
                if (selectioner == ajout)
                    return false;

            return true;
        }

        private void AjoutEleve(object sender, EventArgs e)
        {
            try
            {
                var eleve = Eleves.SelectedItem.ToString();
                if (VerifDoublon(eleve))
                {
                    EleveSelectionner.Add(eleve);
                    Impression.DataSource = null;
                    Impression.DataSource = EleveSelectionner;
                    Impression.Refresh();
                }
            }
            catch
            {
            }
        }

        private void RetirerEleve(object sender, EventArgs e)
        {
            try
            {
                EleveSelectionner.Remove(Impression.SelectedItem.ToString());
                Impression.DataSource = null;
                Impression.DataSource = EleveSelectionner;
                Eleves.Refresh();
                Impression.Refresh();
                Impression.ClearSelected();
            }
            catch
            {
            }
        }

        private void Recheche(object sender, EventArgs e)
        {
            try
            {
                var pattern = ".*" + txtRecherche.Text + ".*";
                var el = XTrie.Recherche(pattern, ListeEleve);
                if (el != null)
                {
                    lblCount.Text = el.Count.ToString();
                    Eleves.DataSource = el;
                    Eleves.Refresh();
                }
                else
                {
                    lblCount.Text = ListeEleve.Count.ToString();
                    Eleves.DataSource = NomPrenomEleve;
                    Eleves.Refresh();
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Convertit une liste de string en une liste d'élèves
        /// </summary>
        /// <param name="convertir"></param>
        /// <returns></returns>
        public static List<Eleve> ConvertionListeStringEleveEnEleve(List<string> convertir)
        {
            var e = new List<Eleve>();
            foreach (var ee in convertir)
                foreach (var eee in Globale.ListeEleve)
                {
                    var eeee = eee.NomEleve + " " + eee.PrenomEleve + " " + eee.ClasseEleve;
                    if (ee == eeee) e.Add(eee);
                }

            return e;
        }
        
        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                Globale.ListeEleveImpr = ConvertionListeStringEleveEnEleve(EleveSelectionner);
                Form frmMultipleCarteEdi = new FrmMultiplesCartesEdition();
                frmMultipleCarteEdi.Show();
            }
            catch
            {
            }
        }

        private void RbChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
                if ((sender as RadioButton).Checked)
                    switch ((sender as RadioButton).Name)
                    {
                        case "tout":
                            ToutF();
                            break;
                        case "Seme":
                            SemeF();
                            break;
                        case "Ceme":
                            CemeF();
                            break;
                        case "Qeme":
                            QemeF();
                            break;
                        case "Teme":
                            TemeF();
                            break;
                    }
        }

        private void ToutF()
        {
            ListeEleve = Globale.ListeEleve;
            NomPrenomEleve = new List<string>();
            EleveEnString();
            lblCount.Text = ListeEleve.Count.ToString();
            Eleves.DataSource = NomPrenomEleve;
        }

        private void SemeF()
        {
            ListeEleve = Globale.ListeEleves6Eme;
            NomPrenomEleve = new List<string>();
            EleveEnString();
            lblCount.Text = ListeEleve.Count.ToString();
            Eleves.DataSource = NomPrenomEleve;
        }

        private void CemeF()
        {
            ListeEleve = Globale.ListeEleves5Eme;
            NomPrenomEleve = new List<string>();
            EleveEnString();
            lblCount.Text = ListeEleve.Count.ToString();
            Eleves.DataSource = NomPrenomEleve;
        }

        private void QemeF()
        {
            ListeEleve = Globale.ListeEleves4Eme;
            NomPrenomEleve = new List<string>();
            EleveEnString();
            lblCount.Text = ListeEleve.Count.ToString();
            Eleves.DataSource = NomPrenomEleve;
        }

        private void TemeF()
        {
            ListeEleve = Globale.ListeEleves3Eme;
            NomPrenomEleve = new List<string>();
            EleveEnString();
            lblCount.Text = ListeEleve.Count.ToString();
            Eleves.DataSource = NomPrenomEleve;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            try
            {
                Globale.ListeEleveImpr = ConvertionListeStringEleveEnEleve(EleveSelectionner);
                Globale.carteParListe = true;
                Form frmMultipleCarteEdi = new FrmMultiplesCartesEdition();
                frmMultipleCarteEdi.Show();
            }
            catch
            {
            }
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }

        private void Eleves_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "";
            string Niveau = "";
            string txt = Eleves.SelectedItem.ToString();

            string[] eleve = txt.Split(' ');
            Niveau = eleve[2].Substring(0, 1) + "eme";

            path = Chemin.DossierPhotoEleve + Niveau + "/" + eleve[0] + " " + eleve[1] + ".jpg";
            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (pbPhoto.Image != null)
                pbPhoto.Image.Dispose();
            try
            {
                pbPhoto.Image = Image.FromFile(path);
                corrigeRatioPhoto();
            }
            catch
            {
                pbPhoto.Image = Image.FromFile(Chemin.CheminPhotoDefault);
            }
        }

        private void frmCartesParListe_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pbPhoto.Image != null)
                pbPhoto.Image.Dispose();
        }

        private void corrigeRatioPhoto()
        {
            if (pbPhoto.Image != null)
            {
                double ratio = (double)pbPhoto.Image.Width / (double)pbPhoto.Image.Height;
                pbPhoto.Width = pbPhoto.MaximumSize.Width;
                pbPhoto.Height = (int)((double)pbPhoto.Width / ratio);
                if (pbPhoto.Height >= pbPhoto.MaximumSize.Height)
                {
                    pbPhoto.Height = pbPhoto.MaximumSize.Height;
                    pbPhoto.Width = (int)((double)pbPhoto.Height * ratio);
                }
            }
        }
    }
}
