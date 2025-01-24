using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using Athena.forms.autre;


namespace CartesAcces2024
{

    /*
     * Classe qui permet d'éditer les cartes d'accès
     * elle prend une liste d'élèves et permet de leur editer une carte
     */
    /// <summary>
    ///     Classe qui permet d'éditer les cartes d'accès
    ///     elle prend une liste d'élèves et permet de leur editer une carte
    /// </summary>
    public partial class FrmMultiplesCartesEdition : Form
    {
        public static int defPhotoX = 0;
        public static int defPhotoY = 0;
        public static int defPhotoW = 0;
        public static int defPhotoH = 0;
        public static double photoRatio = 0;

        /// <summary>
        /// Stocke le chemin du dernier dossier d'enregistrement
        /// </summary>
        public static string dernierCheminEnregistre;

        /// <summary>
        /// Champs personnalisés ajoutés par l'utilisateur sur la carte. Voir <see cref="Globale.donneesChampsPersonnalisee"/> pour une description de la structure.
        /// </summary>
        public List<Tuple<string, Image, Point, string, Font, PictureBox>> elementsAjoutee;

        /// <summary>
        /// Ajout un control de champs personnalisé dans la carte face selon l'option d'ajout du champs sélectionné dans <see cref="frmSelectionneAjoutDansCarteAcces"/> (texte, code QR ou code barre).
        /// </summary>
        public void ajouteControlChampPersonnalisee(string uneValeurDeChamp, string optionDAjoutDeLaValeur, Font policeTextChampPersonnalisee = null)
        {
            // on utilise une picturebox pour plus facilement l'ajouter à l'image de la face avant
            PictureBox newCntrl = new PictureBox();

            if (Globale.donneesChampsPersonnalisee == null)
            {
                Globale.donneesChampsPersonnalisee = new List<Tuple<string, Image, Point, string, Font, PictureBox>>();
            }


            if (optionDAjoutDeLaValeur == "Code QR")
            {

                var bmpOriginal = QrCode.CreationQrCode(uneValeurDeChamp);
                var bmpFinal = new Bitmap(bmpOriginal, new Size(100, 100));
                newCntrl.Image = bmpFinal;

                newCntrl.Width = 100;
                newCntrl.Height = 100;

            }
            else if (optionDAjoutDeLaValeur == "Code Barre")
            {

                EditionCodeBarre.AfficherCodeBarre(uneValeurDeChamp, newCntrl);

            } 
            else if (optionDAjoutDeLaValeur == "Text")
            {

                if (policeTextChampPersonnalisee==null) // la police peut ou non être passée en paramètre
                {
                    policeTextChampPersonnalisee = new Font("Calibri", 16, FontStyle.Bold);
                }
                Brush pinceauNoir = new SolidBrush(Color.Black);

                // Gestion de la couleur de l'arrière plan
                List<Color> couleurs = new List<Color> { };
                couleurs = OperationsDb.GetColors();

                Color couleurFondDuTexte;

                // -- Couleur du rectangle en fonction de la section (donc de la couleur de la carte) --
                switch (Globale.ListeEleveImpr[0].NiveauEleve)
                {
                    case "6eme":
                        couleurFondDuTexte = couleurs[0];
                        break;
                    case "5eme":
                        couleurFondDuTexte = couleurs[1];
                        break;
                    case "4eme":
                        couleurFondDuTexte = couleurs[2];
                        break;
                    case "3eme":
                        couleurFondDuTexte = couleurs[3];
                        break;
                    default:
                        couleurFondDuTexte = Color.White;
                        break;
                }


                using (Bitmap temp = new Bitmap(1, 1))
                using (Graphics tempGraph = Graphics.FromImage(temp))
                {
                    // on mesure la taille du texte dessiné avec une certaine police
                    SizeF tailleDeTexte = tempGraph.MeasureString(uneValeurDeChamp, policeTextChampPersonnalisee);
                    Rectangle rectangelArrièrePlan = new Rectangle(0, 0, (int)tailleDeTexte.Width, (int)tailleDeTexte.Height);



                    // on définit la taille du picturebox selon la longueur du text
                    newCntrl.Width = (int)tailleDeTexte.Width;
                    newCntrl.Height = (int)tailleDeTexte.Height;

                    // on définit la taille de l'image selon la longueur du text
                    newCntrl.Image = new Bitmap(newCntrl.Width, newCntrl.Height);

                    using (Graphics graph = Graphics.FromImage(newCntrl.Image))
                    {
                        graph.FillRectangle(new SolidBrush(couleurFondDuTexte), rectangelArrièrePlan);
                        // on écrit la valeur de champ dans la picturebox, qui as la bonne taille
                        graph.DrawString(uneValeurDeChamp, policeTextChampPersonnalisee, pinceauNoir, new Point(0, 0));
                    }
                }
                newCntrl.Refresh();
            }

            // paramètre du nouveaux control
            newCntrl.Location = new Point(pbCarteFace.Location.X + (pbCarteFace.Width / 2), pbCarteFace.Location.Y + (pbCarteFace.Height / 2));
            newCntrl.Visible = true;



            // évènements du nouveaux control

            //---------------- pour permetre de le bouger avec la sourie
            newCntrl.MouseDown += (sender, e) => {
                // Your code here
                // -- Lorsque l'utilisateur clic, la position initiale est sauvegardée, drag passe a true
                if (e.Button == MouseButtons.Left)
                {
                    Edition.PosX = e.X;
                    Edition.PosY = e.Y;
                    Edition.Drag = true;
                }

                // -- Actualisation pour voir le déplacement en temps réel --
                Refresh();
            };



            newCntrl.MouseMove += (object sender, MouseEventArgs e) =>
            {
                // -- Lorsque l'utilisateur clique sur la photo de l'élève --

                // On calcul la nouvelle position qu'auras lecontrol
                int newLeft = e.X + newCntrl.Left - Edition.PosX;
                int newTop = e.Y + newCntrl.Top - Edition.PosY;

                // on récupère la surface de pbCarteFace
                Rectangle boundingRect = pnlEdtPhoto.RectangleToClient(
                    pbCarteFace.RectangleToScreen(pbCarteFace.ClientRectangle)
                );

                // si drag est vrais
                if (Edition.Drag)
                {
                    // On restraint le control à la surface de pbCarteFace
                    newLeft = Math.Max(boundingRect.Left, Math.Min(newLeft, boundingRect.Right - newCntrl.Width));
                    newTop = Math.Max(boundingRect.Top, Math.Min(newTop, boundingRect.Bottom - newCntrl.Height));

                    // -- La position de la photo change --
                    newCntrl.Left = newLeft;
                    newCntrl.Top = newTop;
                }
            };



            newCntrl.MouseUp += (Object sender, MouseEventArgs e) =>
            {
                // -- Le drag est fini lorsque le clic est relevé  --
                Edition.Drag = false;
            };





            //--------------------permet de supprimer le control en double-cliquant
            newCntrl.MouseDoubleClick += (Object sender, MouseEventArgs e) =>
            {
                pnlEdtPhoto.Controls.Remove(newCntrl);
            };



            // On ajoute le control
            pnlEdtPhoto.Controls.Add(newCntrl);
            newCntrl.BringToFront(); // on le met au premier plan

            // On ajoute le control dans la liste, afin de l'ajouter dans Globale.donneesChampsPersonnalisee avec les bonnes cordonnées lors de btnValiderImpr_Click
            // car l'origine des cordonnées sont calculées à partir de pnlEdtPhoto, pas de pbCarteFace
            elementsAjoutee.Add( new Tuple<string, Image, Point, string, Font, PictureBox >(optionDAjoutDeLaValeur, newCntrl.Image, newCntrl.Location, uneValeurDeChamp, policeTextChampPersonnalisee, newCntrl) );

        }









 





        /// <summary>
        /// Permet de transmettre la photo de frmCarteProvisoire à L'IDENTIQUE avec les mêmes position
        /// et taille. Les paramètres transmis sont les valeurs à MULTIPLIER par les dimensions de pbCarteArriere.
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="img"></param>
        public void editPhotoDepuisCartesProvisoires(double w, double h, double x, double y, Image img)
        {
            if (pbPhoto.Image != null)
                pbPhoto.Image.Dispose();
            pbPhoto.Image = img;
            pbPhoto.Location = new Point((int)((x + (double)pbCarteArriere.Location.X) * (double)pbCarteArriere.Width),
                (int)((y + (double)pbCarteArriere.Location.Y) * (double)pbCarteArriere.Height));
            //pbPhoto.Location = new Point(0, 0);
            pbPhoto.Size = new Size((int)(w * (double)pbCarteArriere.Width), (int)(h * (double)pbCarteArriere.Height));
            pbPhoto.Refresh();        
        }
        
        
        
        
        
        /// <summary>
        ///     Constructeur de la classe
        /// </summary>
        public FrmMultiplesCartesEdition()
        {
            InitializeComponent();
            //Couleur.setCouleurFenetre(this);
            labelEnCoursValidation.Visible = false;
            labelEnCoursValidation.ForeColor = Color.Red;
            dernierCheminEnregistre = "";
            elementsAjoutee = new List<Tuple<string, Image, Point, string, Font, PictureBox>>();
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

        private void pbPhoto_MouseDown(object sender, MouseEventArgs e)
        {
            // -- Lorsque l'utilisateur clic, la position initiale est sauvegardée, drag passe a true
            if (e.Button == MouseButtons.Left)
            {
                Edition.PosX = e.X;
                Edition.PosY = e.Y;
                Edition.Drag = true;
            }

            // -- Actualisation pour voir le déplacement en temps réel --
            Refresh();
        }

        private void pbPhoto_MouseUp(object sender, MouseEventArgs e)
        {
            // -- Le drag est fini lorsque le clic est relevé  --
            Edition.Drag = false;
        }

        private void tkbTaillePhoto_Scroll(object sender, EventArgs e)
        {
            if (pbPhoto != null)
            {
                // -- La largeur en pixel de la photo change et prend la valeur de la trackbar
                pbPhoto.Width = tkbTaillePhoto.Value;
                pbPhoto.Height = Convert.ToInt32(tkbTaillePhoto.Value * 1.5);
            }
        }


        // #### Rognage de l'emploi du temps ####
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                // -- Curseur en croix pour symboliser le mode selection
                Cursor = Cursors.Cross;

                // -- On est dans le mode selection
                Edition.SelectionClique = true;

                btnCancel.Enabled = true;
                btnSelect.Enabled = false;
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // -- Le curseur revient à la normal --
            Cursor = Cursors.Default;

            // -- On est plus dans la selection --
            Edition.SelectionClique = false;
            // -- On remet les paramètres et l'image de base --
            if (Globale.carteProvisoire == true)
            {
                if (pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                // Debug.Assert(Directory.GetCreationTime(Chemin.DossierEdtClassique) == Directory.GetCreationTime("./data/FichierEdtClasse/"));
                pbCarteArriere.Image = Image.FromFile(Chemin.DossierEdtClassique + "classes/" + Globale.ListeEleveImpr[0].ClasseEleve + ".jpg");
                Edition.RognageX = 720;
                Edition.RognageY = 457;
            }
            else
            {
                Edt.ChercheEdtPerso(Globale.ListeEleveImpr, pbCarteArriere);
            }
            Photo.AffichePhotoProvisoire(Chemin.CheminPhotoDefault, pbPhoto);

            resetView();

            btnSelect.Enabled = true;
            btnCancel.Enabled = false;
            
        }

        private void pbCarteArriere_MouseDown(object sender, MouseEventArgs e)
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

        private void btnValiderImpr_Click(object sender, EventArgs e)
        {
            Edition.ReplacementPhotoClassique(pbPhoto.Location.X, pbPhoto.Location.Y);


            // On met à jour les coordonnées pour qu'elles soient relatives à pbcarteFace
            foreach (Tuple<string, Image, Point, string, Font, PictureBox> donneElementPersonnelisee in elementsAjoutee)
            {
                int relativeX = donneElementPersonnelisee.Item6.Location.X - pbCarteFace.Left;
                int relativeY = donneElementPersonnelisee.Item6.Location.Y - pbCarteFace.Top;

                MessageBox.Show( donneElementPersonnelisee.Item1 + " " + donneElementPersonnelisee.Item4 + " " + relativeX + " " + relativeY
                    + "\n" + donneElementPersonnelisee.Item3.X + " " + donneElementPersonnelisee.Item3.Y);
                MessageBox.Show("Sizes : " + donneElementPersonnelisee.Item6.Size.Width + " " + donneElementPersonnelisee.Item6.Size.Height);

                Globale.donneesChampsPersonnalisee.Add(
                        new Tuple<string, Image, Point, string, Font, PictureBox>(
                                donneElementPersonnelisee.Item1,
                                donneElementPersonnelisee.Item2,
                                new Point(relativeX, relativeY),
                                donneElementPersonnelisee.Item4,
                                donneElementPersonnelisee.Item5,
                                donneElementPersonnelisee.Item6

                            )
                    );
            }


            if (rdbA4.Checked == false && rdbA5.Checked == false)
            {
                MessageBox.Show("Veuillez selectionner un format d'impression (A4 ou A5).");
            }
            else if (rdbA4.Checked == true)
            {
                btnOpenFolder.Enabled = false;
                try
                {
                    // -- Si la liste est impaire, on double le dernier élève
                    if (Globale.ListeEleveImpr.Count % 2 == 1)
                    {
                        Globale.EleveImpr = true;
                        var eleve = Globale.ListeEleveImpr[Globale.ListeEleveImpr.Count - 1];
                        Globale.ListeEleveImpr.Add(eleve);
                    }

                    I_ImportService chemin = new ImportDossier();
                    if (OperationsDb.FolderPathExists() == true)
                    {
                        Globale.presetPath = true;
                        Globale.folderPath = OperationsDb.GetFolderPath();
                    }

                    Globale.cheminImpressionFinal = chemin.setCheminImportation("Choisissez le chemin d'arrivée du fichier Word a imprimer");
                    if (Globale.cheminImpressionFinal != "failed")
                    {
                        labelEnCoursValidation.Visible = true;
                        OperationsDb.SetFolderPath(Globale.cheminImpressionFinal);

                        Globale.LblCount = lblCompteur;
                        Globale.pgbCount = progressBar1_compteur;

                        pbPhoto.Visible = false;
                        FichierWord.SauvegardeCarteEnWord(Globale.cheminImpressionFinal, Globale.ListeEleveImpr, pbPhoto, pbCarteArriere);
                        pbPhoto.Visible = true;
                        Globale.PositionPhotoClassique = false;
                        btnOpenFolder.Enabled = true;
                        resetView();
                    }
                    else
                    {
                        MessageBox.Show("Import Annulé");
                    }
                    Globale.presetPath = false;
                }
                catch
                {
                    pbPhoto.Visible = true;

                    if (Globale.cheminImpressionFinal != "failed")
                    {
                        labelEnCoursValidation.Visible = true;
                        OperationsDb.SetFolderPath(Globale.cheminImpressionFinal);

                        Globale.LblCount = lblCompteur;
                        Globale.pgbCount = progressBar1_compteur;

                        pbPhoto.Visible = false;
                        FichierWord.SauvegardeCarteEnWord(Globale.cheminImpressionFinal, Globale.ListeEleveImpr, pbPhoto, pbCarteArriere);
                        pbPhoto.Visible = true;
                        Globale.PositionPhotoClassique = false;
                        btnOpenFolder.Enabled = true;
                        resetView();
                    }
                    else
                    {
                        MessageBox.Show("Import Annulé");
                    }
                    Globale.presetPath = false;
                }
            }
            //impression en A5
            else
            {
                try
                {
                    I_ImportService chemin = new ImportDossier();
                    if (OperationsDb.FolderPathExists() == true)
                    {
                        Globale.presetPath = true;
                        Globale.folderPath = OperationsDb.GetFolderPath();
                    }

                    Globale.cheminImpressionFinal = chemin.setCheminImportation("Choisissez le chemin d'arrivée du fichier Word a imprimer");
                    if (Globale.cheminImpressionFinal != "failed")
                    {
                        labelEnCoursValidation.Visible = true;
                        OperationsDb.SetFolderPath(Globale.cheminImpressionFinal);

                        Globale.LblCount = lblCompteur;

                        pbPhoto.Visible = false;
                        FichierWord.SauvegardeCarteEnWordA5(Globale.cheminImpressionFinal, Globale.ListeEleveImpr, pbPhoto, pbCarteArriere);
                        pbPhoto.Visible = true;
                        Globale.PositionPhotoClassique = false;
                        btnOpenFolder.Enabled = true;
                        resetView();
                    }
                    else
                    {
                        MessageBox.Show("Import Annulé");
                    }
                    Globale.presetPath = false;
                }
                catch
                {
                    if (Globale.cheminImpressionFinal != "failed")
                    {
                        labelEnCoursValidation.Visible = true;
                        OperationsDb.SetFolderPath(Globale.cheminImpressionFinal);

                        Globale.LblCount = lblCompteur;
                        Globale.pgbCount = progressBar1_compteur;

                        pbPhoto.Visible = false;
                        FichierWord.SauvegardeCarteEnWordA5(Globale.cheminImpressionFinal, Globale.ListeEleveImpr, pbPhoto, pbCarteArriere);
                        pbPhoto.Visible = true;
                        Globale.PositionPhotoClassique = false;
                        btnOpenFolder.Enabled = true;
                        resetView();
                    }
                    else
                    {
                        MessageBox.Show("Import Annulé");
                    }
                    Globale.presetPath = false;
                }
            }
            labelEnCoursValidation.Visible = false;
        }

        private void resetView()
        {
            Edition.SelectionClique = false;
            btnSelect.Enabled = true;
            btnCancel.Enabled = false;
            lblCompteur.Visible = false;
            progressBar1_compteur.Visible = false;
            Eleve.PossedeEdt(Globale.ListeEleveImpr);
            try
            {
                foreach (Eleve eleve in Globale.ListeEleveImpr)
                {
                    if (eleve.SansEdt == true && eleve.ClasseEleve != "Profil particuler")
                    {
                        Edt.AddEleveSansEdt(Globale.ListeEleveImpr, pbCarteArriere);
                    }
                    else if (eleve.ClasseEleve == "Profil particulier")
                    {
                        Edt.AddEleveProfilParticulier(Globale.ListeEleveImpr, pbCarteArriere);
                    }
                    else if (eleve.SansEdt == false)
                    {
                        Edt.ChercheEdtPerso(Globale.ListeEleveImpr, pbCarteArriere);
                    }
                }
                Photo.AffichePhotoProvisoire(Chemin.CheminPhotoDefault, pbPhoto);

                // Replace pbPhoto :
                defPhotoX = (int)(0.4127 * (double)pbCarteArriere.Width);
                defPhotoY = (int)(0.45 * (double)pbCarteArriere.Height);
                defPhotoW = (int)(0.1539 * (double)pbCarteArriere.Width);
                defPhotoH = (int)(0.379 * (double)pbCarteArriere.Height);

                pbPhoto.Location = new Point(defPhotoX, defPhotoY);
                pbPhoto.Size = new Size(defPhotoW, defPhotoH);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Close();
            }
        }

        private void frmMultiplesCartesEdition_Load(object sender, EventArgs e)
        {
            resetView();
            btnOpenFolder.Enabled = false;
            Edition.RognageX = 720;
            Edition.RognageY = 457;

            // On affiche la face de la carte selon le premier élève
            if (File.Exists(Chemin.DossierCartesFace + Globale.ListeEleveImpr[0].NiveauEleve + ".png"))
            {
                if (pbCarteFace.Image != null)
                    pbCarteFace.Image.Dispose();
                pbCarteFace.Image = null;
                try
                {
                    // affiche la face de la carte dans la picturebox
                    pbCarteFace.Image = Image.FromFile(Chemin.DossierCartesFace + Globale.ListeEleveImpr[0].NiveauEleve + ".png");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erreur + " + err);
                }

                // permet de générer la preview avec les informations personnalisés on non (selon le radiobouton dans frmEtablissement)
                string prenom = Globale.ListeEleveImpr[0].PrenomEleve;
                string nom = Globale.ListeEleveImpr[0].NomEleve;
                string classex = Globale.ListeEleveImpr[0].ClasseEleve;

                if (Globale.InfosCarte == true)
                {
                    Edition.FondCarteNiveauInfos(pbCarteFace, nom, prenom, classex);
                }
                else
                {
                    Edition.fondCarteNiveau(pbCarteFace, nom, prenom, classex);
                }
            }
            else
            {
                MessageBox.Show("Aucune image pour le recto n'a été importée ! " +
                    "Vous pouvez le faire depuis Importation > Importer des faces pour les cartes.");
            }
        }

        private void pbCarteArriere_MouseUp(object sender, MouseEventArgs e)
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
                        var pathEdt = Chemin.CheminEdt;
                        Edition.SelectionClique = false;
                        Edt.RognageEdt(pbCarteArriere, pbPhoto);
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        Edition.SelectionClique = false;
                        if (pbCarteArriere.Image != null)
                            pbCarteArriere.Image.Dispose();
                        pbCarteArriere.Image = Image.FromFile(Chemin.CheminEdt);
                        btnCancel.Enabled = false;
                        btnSelect.Enabled = true;

                        Edition.RognageX = 0;
                        Edition.RognageY = 0;
                        Edition.RognageHauteur = 0;
                        Edition.RognageLargeur = 0;
                    }
                }
            }
            catch
            {
            }
        }

        private void labelEnCoursValidation_Click(object sender, EventArgs e)
        {

        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }

        private void frmMultipleCartesEdition_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pbPhoto.Image != null)
                pbPhoto.Image.Dispose();
            if (pbCarteArriere.Image != null)
                pbCarteArriere.Image.Dispose();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(@dernierCheminEnregistre);
        }

        private void btnAjouterElementDansCartes_Click(object sender, EventArgs e)
        {

            Globale.formMultipleCartes = this;
            // ouvrir form qui choisit l'élément à ajouter
            frmSelectionneAjoutDansCarteAcces frmSelection = new frmSelectionneAjoutDansCarteAcces();
            frmSelection.Show();
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
