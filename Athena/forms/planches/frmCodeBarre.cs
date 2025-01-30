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
using ZXing;
using ZXing.Common;

namespace CartesAcces2024
{
    public partial class frmCodeBarre : Form
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
        public frmCodeBarre()
        {
            InitializeComponent();
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

        private void frmCodeBarre_Load(object sender, EventArgs e)
        {
            changeAffichage();
        }

        /// <summary>
        /// rafraichit l'affichage selon les options cochées et les éléments présents dans la base de données.
        /// </summary>
        private void changeAffichage()
        {
            // On récupère tout les élèves
            Globale.ListeEleve.Clear();
            Globale.ListeEleve = OperationsDb.GetEleve();

            // Pour les niveaux de base, on les ajoute manuellement
            Globale.ListeEleves6Eme = OperationsDb.GetEleve("6");
            Globale.ListeEleves5Eme = OperationsDb.GetEleve("5");
            Globale.ListeEleves4Eme = OperationsDb.GetEleve("4");
            Globale.ListeEleves3Eme = OperationsDb.GetEleve("3");

            // Selon l'option sélectionnée
            clbElements.Items.Clear();
            List<Eleve> listeAUtiliser = rdbTout.Checked ? Globale.ListeEleve :
                                          rdb6eme.Checked ? Globale.ListeEleves6Eme :
                                          rdb5eme.Checked ? Globale.ListeEleves5Eme :
                                          rdb4eme.Checked ? Globale.ListeEleves4Eme :
                                          Globale.ListeEleves3Eme;

            foreach (Eleve elv in listeAUtiliser)
            {
                string element = $"{elv.NomEleve} {elv.PrenomEleve} {elv.ClasseEleve}";
                if (!string.IsNullOrWhiteSpace(element) && element.Split(' ').Length == 3)
                {
                    clbElements.Items.Add(element);
                }
            }
        }

        //private bool VerifDoublon(string ajout)
        //{
        //    foreach (string selectioner in Impression.Items)
        //        if (selectioner == ajout)
        //            return false;

        //    return true;
        //}

        // A FAIRE
        private void Recheche(object sender, EventArgs e)
        {
            //try
            //{
            //    var pattern = ".*" + txtRecherche.Text + ".*";
            //    var el = XTrie.Recherche(pattern, ListeEleve);
            //    if (el != null)
            //    {
            //        lblCount.Text = el.Count.ToString();
            //        Eleves.DataSource = el;
            //        Eleves.Refresh();
            //    }
            //    else
            //    {
            //        lblCount.Text = ListeEleve.Count.ToString();
            //        Eleves.DataSource = NomPrenomEleve;
            //        Eleves.Refresh();
            //    }
            //}
            //catch
            //{
            //}
        }

        /// <summary>
        /// Convertit une liste de string en une liste d'élèves
        /// </summary>
        /// <param name="convertir"></param>
        /// <returns></returns>
        public static List<Eleve> ConvertionListeStringEleveEnEleve(List<string> convertir)
        {
            if (convertir == null)
                return new List<Eleve>(); // Retourne une liste vide si convertir est null

            var e = new List<Eleve>();
            foreach (var ee in convertir)
            {
                foreach (var eee in Globale.ListeEleve)
                {
                    var eeee = $"{eee.NomEleve} {eee.PrenomEleve} {eee.ClasseEleve}";
                    if (ee == eeee) e.Add(eee);
                }
            }

            return e;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (clbElements.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins un élément.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.Title = "Enregistrer le fichier PDF";
                sfd.DefaultExt = "pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Préparer les données pour le traitement
                    List<string> codesBarres = new List<string>();
                    foreach (var item in clbElements.CheckedItems)
                    {
                        string elementText = item.ToString();
                        string codeBarre = RemoveAccents(elementText.Split(' ')[0] + " " + elementText.Split(' ')[1]);
                        codesBarres.Add(codeBarre);
                    }

                    // Configurer les variables globales
                    Globale.CheminDestination = sfd.FileName;
                    Globale.ListeElevesString = codesBarres;
                    Globale.ListeCas.Clear();
                    Globale.ListeCas.Add(Globale.CodeCas.genererCodesBarres);
                    Globale.ListeCas.Add(Globale.CodeCas.sauvegarderCodesBarres);

                    // Lancer le formulaire de chargement
                    using (frmChargement frm = new frmChargement())
                    {
                        frm.ShowDialog();
                        if (Globale.wokerFinished)
                        {
                            MessageBox.Show("Le PDF a été généré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            txtRecherche.Text = "";
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            // Code pour gérer le clic sur l'image
        }

        private void frmCodeBarre_FormClosed(object sender, FormClosedEventArgs e)
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

        private void rdbTout_CheckedChanged(object sender, EventArgs e)
        {
            changeAffichage();
        }

        private void rdb6eme_CheckedChanged(object sender, EventArgs e)
        {
            changeAffichage();
        }

        private void rdb5eme_CheckedChanged(object sender, EventArgs e)
        {
            changeAffichage();
        }

        private void rdb4eme_CheckedChanged(object sender, EventArgs e)
        {
            changeAffichage();
        }

        private void rdb3eme_CheckedChanged(object sender, EventArgs e)
        {
            changeAffichage();
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

        private void clbElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbElements.SelectedItem != null)
            {
                string selectedText = clbElements.SelectedItem.ToString();
                string[] eleve = selectedText.Split(' ');

                if (eleve.Length >= 3)
                {
                    string niveau = eleve[2].Substring(0, 1) + "eme";
                    string path = Chemin.DossierPhotoEleve + niveau + "/" + eleve[0] + " " + eleve[1] + ".jpg";
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

                    EditionCodeBarre.AfficherCodeBarre(RemoveAccents($"{eleve[0]} {eleve[1]}"), pbCodeBarre);

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
                else
                {
                    MessageBox.Show("Le format de l'élément sélectionné est incorrect. Assurez-vous qu'il contient le nom, le prénom et la classe.");
                }
            }
        }


        public static string RemoveAccents(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder normalizedString = new StringBuilder();
            foreach (char c in input)
            {
                // Convertir les caractères accentués en non accentués
                switch (c)
                {
                    case 'É': normalizedString.Append('E'); break;
                    case 'È': normalizedString.Append('E'); break;
                    case 'Ê': normalizedString.Append('E'); break;
                    case 'Ë': normalizedString.Append('E'); break;
                    case 'À': normalizedString.Append('A'); break;
                    case 'Â': normalizedString.Append('A'); break;
                    case 'Ä': normalizedString.Append('A'); break;
                    case 'Î': normalizedString.Append('I'); break;
                    case 'Ï': normalizedString.Append('I'); break;
                    case 'Ô': normalizedString.Append('O'); break;
                    case 'Ö': normalizedString.Append('O'); break;
                    case 'Ù': normalizedString.Append('U'); break;
                    case 'Û': normalizedString.Append('U'); break;
                    case 'Ü': normalizedString.Append('U'); break;
                    case 'Ç': normalizedString.Append('C'); break;

                    case 'é': normalizedString.Append('e'); break;
                    case 'è': normalizedString.Append('e'); break;
                    case 'ê': normalizedString.Append('e'); break;
                    case 'ë': normalizedString.Append('e'); break;
                    case 'à': normalizedString.Append('a'); break;
                    case 'â': normalizedString.Append('a'); break;
                    case 'ä': normalizedString.Append('a'); break;
                    case 'î': normalizedString.Append('i'); break;
                    case 'ï': normalizedString.Append('i'); break;
                    case 'ô': normalizedString.Append('o'); break;
                    case 'ö': normalizedString.Append('o'); break;
                    case 'ù': normalizedString.Append('u'); break;
                    case 'û': normalizedString.Append('u'); break;
                    case 'ü': normalizedString.Append('u'); break;
                    case 'ç': normalizedString.Append('c'); break;
                    
                    default: normalizedString.Append(c); break;
                }
            }
            return normalizedString.ToString();
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtRecherche.Text.ToLower();
            for (int i = 0; i < clbElements.Items.Count; i++)
            {
                string itemText = clbElements.Items[i].ToString().ToLower();
                if (itemText.Contains(searchText))
                {
                    clbElements.SelectedIndex = i; // Mettre à jour l'index sélectionné
                    break; // Sortir de la boucle après avoir trouvé le premier élément correspondant
                }
                else
                {
                    clbElements.SetItemChecked(i, false); // Désélectionner les autres éléments
                }
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
