using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace CartesAcces2024
{

    /// <summary>
    /// Permet de créer une carte provisoire
    /// </summary>
    public partial class frmCarteProvisoire : Form
    {
        public static int defPhotoX = 0;
        public static int defPhotoY = 0;
        public static int defPhotoW = 0;
        public static int defPhotoH = 0;
        public static double photoRatio = 0;

        public frmCarteProvisoire()
        {
            InitializeComponent();
            //Couleur.setCouleurFenetre(this);
            pbPhoto.Visible = true;
            defPhotoX = (int)(0.4127 * (double)pbCarteArriere.Width);
            defPhotoY = (int)(0.45 * (double)pbCarteArriere.Height);
            defPhotoW = (int)(0.1539 * (double)pbCarteArriere.Width);
            defPhotoH = (int)(0.379 * (double)pbCarteArriere.Height);
            pictureBox1.MaximumSize = new Size(155, 160);
        }

        private string directoryPath = "";
        private int classeEleve = 0;


        private void ChangementTexte(object sender, EventArgs e)
        {
            var prenom = txtPrenom.Text;
            var nom = txtNom.Text;
            string classex = "0";
            if (cbbSection.SelectedIndex != -1)
                classex = cbbSection.Text;
            else if (cbbClasse.SelectedIndex != -1)
                classex = cbbClasse.Text;

            if (Globale.InfosCarte == true)
            {
                Edition.FondCarteNiveauInfos(pbCarteFace, cbbSection, nom, prenom, classex);
            }
            else
            {
                Edition.fondCarteNiveau(pbCarteFace, cbbSection, nom, prenom, classex);
            }

            //if (nom.Length < 15)
            //{
            //    var font = new Font("Calibri", 28, FontStyle.Bold);
            //    Edition.dessineTexteCarteFace(font, 250, 960, nom, pbCarteFace, cbbSection);
            //    pbCarteFace.Refresh();
            //}
            //else
            //{
            //    var font = new Font("Calibri", 25, FontStyle.Bold);
            //    Edition.dessineTexteCarteFace(font, 250, 960, nom, pbCarteFace, cbbSection);
            //    pbCarteFace.Refresh();
            //}

            //if (prenom.Length < 15)
            //{
            //    var font = new Font("Calibri", 28, FontStyle.Bold);
            //    Edition.dessineTexteCarteFace(font, 325, 1075, prenom, pbCarteFace, cbbSection);
            //    pbCarteFace.Refresh();
            //}
            //else
            //{
            //    var font = new Font("Calibri", 25, FontStyle.Bold);
            //    Edition.dessineTexteCarteFace(font, 325, 1075, prenom, pbCarteFace, cbbSection);
            //    pbCarteFace.Refresh();
            //}
            GC.Collect();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Globale.ListeEleveImpr.Clear();
            Eleve nouvelle_eleve = new Eleve();
            nouvelle_eleve.NomEleve = txtNom.Text;
            nouvelle_eleve.PrenomEleve = txtPrenom.Text;
            nouvelle_eleve.NiveauEleve = cbbSection.Text;
            if (rdbParN.Checked)
            {
                if (cbbClasse.Text != "")
                    nouvelle_eleve.ClasseEleve = cbbClasse.Text;
                // si cbbClasse est vide, chercher la classe de l'élève dans la base de données
                else
                    nouvelle_eleve.ClasseEleve = OperationsDb.GetUnEleve(nouvelle_eleve.NomEleve, nouvelle_eleve.PrenomEleve).ClasseEleve;
                    //nouvelle_eleve = OperationsDb.GetUnEleve(nouvelle_eleve.NomEleve, nouvelle_eleve.PrenomEleve); // rendrait l'élève null si il n'existe pas

            }
            else
            {
                nouvelle_eleve.ClasseEleve = "Profil particulier";
            }

            
            //if (nouvelle_eleve != null)
            //{
                Globale.ListeEleveImpr.Add(nouvelle_eleve);

                try
                {
                    Globale.carteProvisoire = true;
                    var frmMultiplesCartesEdition = new FrmMultiplesCartesEdition();
                    frmMultiplesCartesEdition.Show();
                    frmMultiplesCartesEdition.editPhotoDepuisCartesProvisoires((double)pbPhoto.Width / (double)pbCarteArriere.Width,
                        (double)pbPhoto.Height / (double)pbCarteArriere.Height,
                        (double)(pbPhoto.Location.X - pbCarteArriere.Location.X) / (double)pbCarteArriere.Width,
                        (double)(pbPhoto.Location.Y - pbCarteArriere.Location.Y) / (double)pbCarteArriere.Height,
                        new Bitmap(pbPhoto.Image));
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erreur : " + err.Message);
                }
            //}
            //else
            //{
            //    MessageBox.Show("L'élève n'existe pas: " + nouvelle_eleve.NomEleve + " " + nouvelle_eleve.PrenomEleve);
            //}
        }


        private void frmCarteProvisoire_Load(object sender, EventArgs e)
        {
            txtNom.TextChanged += ChangementTexte;
            txtPrenom.TextChanged += ChangementTexte;
            pbCarteArriere.MouseWheel += pictureBox1_MouseWheel;
        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
        }

        private void pbPhotoInitialSize()
        {
            if (pbPhoto.Image == null)
                return;
            photoRatio = (double)pbPhoto.Image.Width / (double)pbPhoto.Image.Height;
            pbPhoto.Location = new Point(defPhotoX + pbCarteArriere.Location.X, defPhotoY);
            pbPhoto.Width = defPhotoW;
            pbPhoto.Height = (int)((double)defPhotoW / photoRatio);
        }

        private void pbCorrectRatio(PictureBox pb)
        {
            if (pb.Image == null)
                return;

            double pbRatio = (double)pb.Image.Width / (double)pb.Image.Height;
            // Si Largeur <= Hauteur
            if(pbRatio <= 1)
            {
                pb.Height = pb.MaximumSize.Height;
                pb.Width = (int)((double)pb.Height * pbRatio);
            }
            // Si Hauteur > Largeur
            else
            {
                pb.Width = pb.MaximumSize.Width;
                pb.Width = (int)((double)pb.Width * pbRatio);
            }
        }

        private void cbbSection_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            List<string> ListClasses = OperationsDb.GetClasses();
            cbbClasse.Items.Clear();

            if (cbbSection.SelectedItem != null)
            {
                foreach (var classe in ListClasses)
                {
                    if (classe.Substring(0, 1) == cbbSection.Text.Substring(0, 1))
                    {
                        string[] listClasse1 = classe.Split(' ');
                        cbbClasse.Items.Add(listClasse1[0]);
                    }
                }
                cbbClasse.SelectedItem = null;
            }
            if(cbbSection.SelectedItem == null)
            {
                if(pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                pbCarteArriere.Image = null;
            }
            else
            {
                if (File.Exists(Chemin.DossierCartesFace + cbbSection.Text + ".png"))
                {
                    if (pbCarteFace.Image != null)
                        pbCarteFace.Image.Dispose();
                    pbCarteFace.Image = null;
                    try
                    {
                        pbCarteFace.Image = Image.FromFile(Chemin.DossierCartesFace + cbbSection.Text + ".png");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur + " + err);
                    }


                    //pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pbPhoto.Size = new Size(84, 92);
                    //pbPhoto.Location = new Point(885, 225);

                    pbPhotoInitialSize();

                    string prenom = txtPrenom.Text;
                    string nom = txtNom.Text;
                    string classex = "0";
                    if (cbbSection.SelectedIndex != -1)
                        classex = cbbSection.Text;
                    if (cbbClasse.SelectedIndex != -1)
                        classex = cbbClasse.Text;

                    if (Globale.InfosCarte == true)
                    {
                        Edition.FondCarteNiveauInfos(pbCarteFace, cbbSection, nom, prenom, classex);
                    }
                    else
                    {
                        Edition.fondCarteNiveau(pbCarteFace, cbbSection, nom, prenom, classex);
                    }

                    GC.Collect();

                    switch (cbbSection.Text)
                    {
                        case "6eme":
                            classeEleve = 6;
                            break;
                        case "5eme":
                            classeEleve = 5;
                            break;
                        case "4eme":
                            classeEleve = 4;
                            break;
                        case "3eme":
                            classeEleve = 3;
                            break;
                        default:
                            classeEleve = -1;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Aucune image pour le recto n'a été importée ! " +
                        "Vous pouvez le faire depuis Importation > Importer des faces pour les cartes.");
                }
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtPrenom.Clear();
            cbbSection.SelectedItem = null;
            if(pbCarteArriere.Image != null)
                pbCarteArriere.Image.Dispose();
            pbCarteArriere.Image = null;
            if(pbPhoto.Image != null)
                pbPhoto.Image.Dispose();
            pbPhoto.Image = null;
            if (pbCarteFace.Image != null)
                pbCarteFace.Image.Dispose();
            pbCarteFace.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdtPerso_Click_1(object sender, EventArgs e)
        {
            Globale.CheminPdf = "";
            Globale.CheminEleve = "";
            var frmSelectSection = new frmSelectionNiveauEdt();
            frmSelectSection.StartPosition = FormStartPosition.CenterScreen;
            frmSelectSection.ShowDialog();
            if (pbCarteArriere.Image != null)
                pbCarteArriere.Image.Dispose();
            pbCarteArriere.Image = null;
            try
            {
                pbCarteArriere.Image = Image.FromFile(Globale.CheminEleve);
            }
            catch
            {
                MessageBox.Show("Le chemin d'accès n'a pas été enregistré.");
            }
        }

        private void btnAnnulerPhoto_Click_1(object sender, EventArgs e)
        {

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "edition.jpg");
                if (File.Exists(imagePath))
                {
                    if (pictureBox1.Image != null)
                        pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pbCorrectRatio(pictureBox1);
                }
                else
                {
                    MessageBox.Show("L'image par défaut n'a pas été trouvée.", "ERREUR: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void cbbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.Assert(Directory.GetCreationTime(Chemin.DossierEdtClassique + "classes") == Directory.GetCreationTime("./data/FichierEdtClasse/classes"));
            Recherche_Image searchers = new Recherche_Image(Chemin.DossierEdtClassique + "classes");
            try
            {
                Image images = searchers.SearchImageByName(cbbClasse.Text);
                if (pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                pbCarteArriere.Image = images;
                pbPhoto.Visible = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur : " + err.Message);
            }
        }

        private void btnAjouterPhoto_Click_1(object sender, EventArgs e)
        {
            I_ImportService service = new ImportImg();
            Globale.CheminPhoto = service.setCheminImportation();
            Globale.CheminDestination = Chemin.DossierPhotoEleve+ cbbSection.Text;
            if (Globale.CheminPhoto != "failed")
            {

                Globale.Cas = Globale.CodeCas.copierImageRenommage;
                var frmWait = new frmChargement();
                frmWait.StartPosition = FormStartPosition.CenterScreen;
                frmWait.ShowDialog();
                if (pbPhoto.Image != null)
                    pbPhoto.Image.Dispose();
                pbPhoto.Image = null;
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                try
                {
                    pbPhoto.Image = Image.FromFile(Globale.CheminPhoto);
                    pictureBox1.Image = Image.FromFile(Globale.CheminPhoto);
                    pbPhotoInitialSize();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erreur : " + err.Message);
                }
            }

            pbCarteArriere.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            try
            {
                // -- Curseur en croix pour symboliser le mode selection
                Cursor = Cursors.Cross;

                // -- On est dans le mode selection
                Edition.SelectionClique = true;

                //btnSelect.Enabled = false;
                //btnCancel.Enabled = true;
            }
            catch
            {
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            try
            {
                // -- Le curseur revient à la normal --
                Cursor = Cursors.Default;

                // -- On est plus dans la selection --
                Edition.SelectionClique = false;

                // -- On remet les paramètres et l'image de base --
                Edt.AfficheEmploiDuTemps(cbbClasse, pbCarteArriere);
                pbCarteArriere.Refresh();
                //btnSelect.Enabled = true;
                //btnCancel.Enabled = false;
                Chemin.CheminEdtPerso = "";
            }
            catch
            {
            }
        }

        private void pbPhoto_MouseUp_1(object sender, MouseEventArgs e)
        {
            Edition.Drag = false;
        }

        private void pbPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            // -- Lorsque l'utilisateur clic, la position initiale est sauvegardée, drag passe a true
            if (e.Button == MouseButtons.Left)
            {
                Edition.PosX = e.X;
                Edition.PosY = e.Y;
                Edition.Drag = true;
            }

            if (e.Button == MouseButtons.Right) return;

            // -- Actualisation pour voir le déplacement en temps réel --
            Refresh();
        }

        private void pbPhoto_MouseMove(object sender, MouseEventArgs e)
        {
            // -- Lorsque l'utilisateur clique sur la photo de l'élève --
            if (Edition.Drag)
            {
                // -- La position de la photo change --
                pbPhoto.Left = e.X + pbPhoto.Left - Edition.PosX;
                pbPhoto.Top = e.Y + pbPhoto.Top - Edition.PosY;
            }
        }

        private void pbCarteArriere_MouseUp_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (Edition.SelectionClique)
                {
                    if (pbCarteArriere.ClientRectangle.Contains(pbCarteArriere.PointToClient(MousePosition)))
                    {
                        Edition.RognageX = Math.Min(Edition.RognageX, e.X);
                        Edition.RognageY = Math.Min(Edition.RognageY, e.Y);
                        Cursor = Cursors.Default;
                        var classe = cbbClasse.Text;
                        string pathEdt;
                        if (Chemin.CheminEdtPerso == "")
                            pathEdt = Chemin.DossierEdtClassique + classe + ".jpg";
                        else
                            pathEdt = Chemin.CheminEdtPerso;

                        Edition.SelectionClique = false;
                        Edt.RognageEdt(pbCarteArriere, pbPhoto);
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        var classe = cbbClasse.Text;
                        string pathEdt;
                        if (Chemin.CheminEdtPerso == "")
                            pathEdt = Chemin.DossierEdtClassique + classe + ".jpg";
                        else
                            pathEdt = Chemin.CheminEdtPerso;
                        Edition.SelectionClique = false;
                        if (pbCarteArriere.Image != null)
                            pbCarteArriere.Image.Dispose();
                        pbCarteArriere.Image = null;
                        pbCarteArriere.Image = Image.FromFile(pathEdt);

                        Edition.RognageX = 0;
                        Edition.RognageY = 0;
                        Edition.RognageHauteur = 0;
                        Edition.RognageLargeur = 0;

                        //btnSelect.Enabled = true;
                        //btnCancel.Enabled = false;
                    }
                }
            }
            catch
            {
            }

            Chemin.CheminEdtPerso = "";
        }

        private void pbCarteArriere_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                // -- Si le bouton selection est cliqué --
                if (Edition.SelectionClique)
                {
                    // -- Si pas d'image, on sort --
                    if (pbCarteArriere.Image == null)
                        return;

                    // -- Glissement à la fin du premier clic gauche --
                    if (e.Button == MouseButtons.Left)
                    {
                        // -- On prend les dimensions a la fin du déplacement de la souris
                        pbCarteArriere.Refresh();
                        Edition.RognageLargeur = e.X - Edition.RognageX;
                        Edition.RognageHauteur = e.Y - Edition.RognageY;

                        Edition.RognageLargeur = Math.Abs(Edition.RognageLargeur);
                        Edition.RognageHauteur = Math.Abs(Edition.RognageHauteur);

                        pbCarteArriere.CreateGraphics().DrawRectangle(Edition.RognagePen,
                            Math.Min(Edition.RognageX, e.X),
                            Math.Min(Edition.RognageY, e.Y),
                            Math.Abs(Edition.RognageLargeur),
                            Math.Abs(Edition.RognageHauteur));
                    }
                }
            }
            catch
            {
            }
        }

        private void pbCarteArriere_MouseDown_1(object sender, MouseEventArgs e)
        {
            try
            {
                // -- Si le bouton selectionné est cliqué --
                if (Edition.SelectionClique)
                {
                    // -- Si il y a clic gauche --
                    if (e.Button == MouseButtons.Left)
                    {
                        // -- On prend les coordonnées de départ --
                        Edition.RognageX = e.X;
                        Edition.RognageY = e.Y;
                        Edition.RognagePen = new Pen(Color.Black, 1);
                        Edition.RognagePen.DashStyle = DashStyle.DashDotDot;
                    }

                    // -- Refresh constant pour avoir un apperçu pendant la selection --
                    pbCarteArriere.Refresh();
                }
            }
            catch
            {
            }
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            Globale.PrenomEleve = txtPrenom.Text;
            if (txtNom.Text == "" && txtPrenom.Text == "")
            {
                btnAjouterPhoto.Enabled = false;
            }
            else
            {
                btnAjouterPhoto.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            Globale.NomEleve = txtNom.Text;
            if (txtNom.Text == "" && txtPrenom.Text == "")
            {
                btnAjouterPhoto.Enabled = false;
            }
            else
            {
                btnAjouterPhoto.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbParO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbParO.Checked == true)
            {
                cbbClasse.Enabled = false;
                cbbClasse.Items.Clear();
                if (pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                pbCarteArriere.Image = null;
                try
                {
                    Debug.Assert(Directory.GetCreationTime(Chemin.CheminEdtVierge) == Directory.GetCreationTime("./data/emploi_du_temps_vierge.png"));
                    pbCarteArriere.Image = Image.FromFile(Chemin.CheminEdtVierge);
                }
                catch (Exception Err)
                {
                    MessageBox.Show("Erreur : " + Err.Message);
                }
            }
            else
            {
                cbbClasse.Enabled = true;
                if (pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                pbCarteArriere.Image = null;
                List<string> ListClasses = OperationsDb.GetClasses();
                cbbClasse.Items.Clear();

                if (cbbSection.SelectedItem != null)
                {
                    foreach (var classe in ListClasses)
                    {
                        if (classe.Substring(0, 1) == cbbSection.Text.Substring(0, 1))
                        {
                            cbbClasse.Items.Add(classe);
                        }
                    }
                    cbbClasse.SelectedItem = null;
                }
            }
        }

        private void rdbParN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCarteProvisoire_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pbPhoto.Image != null)
                pbPhoto.Image.Dispose();
            pbPhoto.Image = null;
            if (pbCarteFace.Image != null)
                pbCarteFace.Image.Dispose();
            pbCarteFace.Image = null;
            if (pbCarteArriere.Image != null)
                pbCarteArriere.Image.Dispose();
            pbCarteArriere.Image = null;
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
        }

        private void pbCarteFace_Click(object sender, EventArgs e)
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
