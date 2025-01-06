using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CartesAcces2024
{
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition'
    public static class Edition
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition'
    {
        // ** VARIABLES : Pour l'édition de l'emploi du temps (rognage) **
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.SelectionClique'
        public static bool SelectionClique { get; set; } = false;
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.SelectionClique'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognageX'
        public static int RognageX { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognageX'
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognageY'
        public static int RognageY { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognageY'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognageLargeur'
        public static int RognageLargeur { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognageLargeur'
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognageHauteur'
        public static int RognageHauteur { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognageHauteur'
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognagePen'
        public static Pen RognagePen { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.RognagePen'

        // ** VARIABLES  : Déplacement de la photo
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.Drag'
        public static bool Drag { get; set; } = false;
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.Drag'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosX'
        public static int PosX { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosX'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosY'
        public static int PosY { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosY'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosXDef'
        public static int PosXDef { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosXDef'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosYDef'
        public static int PosYDef { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosYDef'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosHeightDef'
        public static int PosHeightDef { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosHeightDef'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosWidthDef'
        public static int PosWidthDef { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosWidthDef'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosXClassique'
        public static int PosXClassique { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosXClassique'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosYClassique'
        public static int PosYClassique { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.PosYClassique'

        // ** VARIABLES : Chemin de l'image **
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.CheminFichier'
        public static string CheminFichier { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.CheminFichier'

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.CheminImpressionFinal'
        public static string CheminImpressionFinal { get; set; }
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.CheminImpressionFinal'

        // -- Dessine le rectangle de couleur derrière le texte pour une meilleurs visibilité de celui ci --
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.fondTexteCarteFace(Graphics, string, Font, int, int, ComboBox)'
        public static void fondTexteCarteFace(Graphics objGraphique, string texte, Font police, int posX, int posY,
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.fondTexteCarteFace(Graphics, string, Font, int, int, ComboBox)'
            ComboBox cbbSection)
        {
            List<Color> couleurs = new List<Color> { };
            couleurs = OperationsDb.GetColors();

            Brush brush6 = new SolidBrush(couleurs[0]);
            Brush brush5 = new SolidBrush(couleurs[1]);
            Brush brush4 = new SolidBrush(couleurs[2]);
            Brush brush3 = new SolidBrush(couleurs[3]);

            var largeur = Convert.ToInt32(objGraphique.MeasureString(texte, police).Width);
            var hauteur = Convert.ToInt32(objGraphique.MeasureString(texte, police).Height);
            var rectangle = new Rectangle(posX, posY, largeur, hauteur);

            // -- Couleur du rectangle en fonction de la section (donc de la couleur de la carte) --
            switch (cbbSection.Text)
            {
                case "6eme":
                    objGraphique.FillRectangle(brush6, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush6), rectangle);
                    break;
                case "5eme":
                    objGraphique.FillRectangle(brush5, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush5), rectangle);
                    break;
                case "4eme":
                    objGraphique.FillRectangle(brush4, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush4), rectangle);
                    break;
                case "3eme":
                    objGraphique.FillRectangle(brush3, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush3), rectangle);
                    break;
            }
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.fondTexteCarteFace(Graphics, string, Font, Eleve, int, int)'
        public static void fondTexteCarteFace(Graphics objGraphique, string texte, Font police, Eleve eleve, int posX,int posY)
        {
            List<Color> couleurs = new List<Color> { };
            couleurs = OperationsDb.GetColors();

            Brush brush6 = new SolidBrush(couleurs[0]);
            Brush brush5 = new SolidBrush(couleurs[1]);
            Brush brush4 = new SolidBrush(couleurs[2]);
            Brush brush3 = new SolidBrush(couleurs[3]);
            Brush defbrush = new SolidBrush(Color.White);

            var largeur = Convert.ToInt32(objGraphique.MeasureString(texte, police).Width);
            var hauteur = Convert.ToInt32(objGraphique.MeasureString(texte, police).Height);
            var rectangle = new Rectangle(posX, posY, largeur, hauteur);

            // -- Couleur du rectangle en fonction de la section (donc de la couleur de la carte) --
            switch (eleve.ClasseEleve.Substring(0, 1))
            {
                case "6":
                    objGraphique.FillRectangle(brush6, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush6), rectangle);
                    break;
                case "5":
                    objGraphique.FillRectangle(brush5, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush5), rectangle);
                    break;
                case "4":
                    objGraphique.FillRectangle(brush4, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush4), rectangle);
                    break;
                case "3":
                    objGraphique.FillRectangle(brush3, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush3), rectangle);
                    break;
                default:
                    objGraphique.FillRectangle(defbrush, rectangle);
                    objGraphique.DrawRectangle(new Pen(defbrush), rectangle);
                    break;
            }
        }

        public static void fondTexteCarteFaceFixe(Graphics objGraphique, string texte, Font police, Eleve eleve, int posX, int posY)
        {
            List<Color> couleurs = new List<Color> { };
            couleurs = OperationsDb.GetColors();

            Brush brush6 = new SolidBrush(couleurs[0]);
            Brush brush5 = new SolidBrush(couleurs[1]);
            Brush brush4 = new SolidBrush(couleurs[2]);
            Brush brush3 = new SolidBrush(couleurs[3]);
            Brush defbrush = new SolidBrush(Color.White);

            var largeur = 625;
            var hauteur = Convert.ToInt32(objGraphique.MeasureString(texte, police).Height);
            var rectangle = new Rectangle(posX, posY, largeur, hauteur);

            // -- Couleur du rectangle en fonction de la section (donc de la couleur de la carte) --
            switch (eleve.ClasseEleve.Substring(0, 1))
            {
                case "6":
                    objGraphique.FillRectangle(brush6, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush6), rectangle);
                    break;
                case "5":
                    objGraphique.FillRectangle(brush5, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush5), rectangle);
                    break;
                case "4":
                    objGraphique.FillRectangle(brush4, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush4), rectangle);
                    break;
                case "3":
                    objGraphique.FillRectangle(brush3, rectangle);
                    objGraphique.DrawRectangle(new Pen(brush3), rectangle);
                    break;
                default:
                    objGraphique.FillRectangle(defbrush, rectangle);
                    objGraphique.DrawRectangle(new Pen(defbrush), rectangle);
                    break;
            }
        }

        // -- Dessine le texte des cases sur la carte --
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.dessineTexteCarteFace(Font, int, int, string, PictureBox, ComboBox)'
        public static void dessineTexteCarteFace(Font police, int posX, int posY, string text, PictureBox pbCarteFace,
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.dessineTexteCarteFace(Font, int, int, string, PictureBox, ComboBox)'
            ComboBox cbbSection)
        {
            //Pinceaux et graphique
            var objetGraphique = Graphics.FromImage(pbCarteFace.Image);
            Brush pinceauNoir = new SolidBrush(Color.Black);

            //Dessine et rempli le fond pour l'écriture
            fondTexteCarteFace(objetGraphique, text, police, posX, posY, cbbSection);

            //Dessine la saisie en textbox
            objetGraphique.DrawString(text, police, pinceauNoir, posX,
                posY); // Dessine le texte sur l'image à la position X et Y + couleur
            objetGraphique.Dispose(); // Libère les ressources
        }

        // -- Récupère et place le qr code sur la face de la carte
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.qrCodeFace(PictureBox)'
        public static void qrCodeFace(PictureBox pbCarteFace)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.qrCodeFace(PictureBox)'
        {
            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());
            var bmpOriginal = QrCode.CreationQrCode(Etablissement[7]);
            var bmpFinal = new Bitmap(bmpOriginal, new Size(220, 220));

            var objGraphique = Graphics.FromImage(pbCarteFace.Image);
            objGraphique.DrawImage(bmpFinal, new Point(1350, 80));
        }

        // -- Change le fond de la carte en fonction de la section choisie
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.fondCarteNiveau(PictureBox, ComboBox)'
        public static void fondCarteNiveau(PictureBox pbCarteFace, ComboBox cbbSection)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.fondCarteNiveau(PictureBox, ComboBox)'
        {
            if (File.Exists("./data/FichierCartesFace/" + cbbSection.Text + ".png"))
            {
                var bmp = new Bitmap("./data/FichierCartesFace/" + cbbSection.Text + ".png");
                bmp.SetResolution(150, 150);
                pbCarteFace.Image = bmp;
            }
            else
            {
                var bmp = new Bitmap("./data/default.png");
                bmp.SetResolution(150, 150);
                pbCarteFace.Image = bmp;
            }

            //qrCodeFace(pbCarteFace);

            var police = new Font("Calibri", 45, FontStyle.Bold);
            dessineTexteCarteFace(police, 50, 70, "Carte Provisoire", pbCarteFace, cbbSection);

            var police2 = new Font("Calibri", 24, FontStyle.Bold);

            var police3 = new Font("Calibri", 24, FontStyle.Bold);
            dessineTexteCarteFace(police3, 50, 960, "Nom :", pbCarteFace, cbbSection);
            dessineTexteCarteFace(police3, 50, 1075, "Prénom :", pbCarteFace, cbbSection);

            var police4 = new Font("Calibri", 24, FontStyle.Bold);

            var succes = true;

            var objetGraphique = Graphics.FromImage(pbCarteFace.Image);
            int mesure;
            string chaine;

            if (succes)
            {
                //    List<string> Etablissement = new List<string> (OperationsDb.GetEtablissement());
                var date = DateTime.Today.ToShortDateString();

                chaine = "Date de création : " + date;
                mesure = Convert.ToInt32(objetGraphique.MeasureString(chaine, police4).Width);
                dessineTexteCarteFace(police2, 1700 - mesure, 70, chaine, pbCarteFace, cbbSection);

            }

            pbCarteFace.Refresh();
        }

        public static void FondCarteNiveauInfos(PictureBox pbCarteFace, ComboBox cbbSection)
        {
            if (File.Exists("./data/FichierCartesFace/" + cbbSection.Text + ".png"))
            {
                var bmp = new Bitmap("./data/FichierCartesFace/" + cbbSection.Text + ".png");
                bmp.SetResolution(150, 150);
                pbCarteFace.Image = bmp;
            }
            else
            {
                var bmp = new Bitmap("./data/default.png");
                bmp.SetResolution(150, 150);
                pbCarteFace.Image = bmp;
            }

            qrCodeFace(pbCarteFace);

            var police = new Font("Calibri", 45, FontStyle.Bold);
            dessineTexteCarteFace(police, 50, 70, "Carte Provisoire", pbCarteFace, cbbSection);

            var police2 = new Font("Calibri", 24, FontStyle.Bold);

            var police3 = new Font("Calibri", 24, FontStyle.Bold);
            dessineTexteCarteFace(police3, 50, 960, "Nom :", pbCarteFace, cbbSection);
            dessineTexteCarteFace(police3, 50, 1075, "Prénom :", pbCarteFace, cbbSection);

            var police4 = new Font("Calibri", 24, FontStyle.Bold);

            var succes = true;

            var objetGraphique = Graphics.FromImage(pbCarteFace.Image);
            int mesure;
            string chaine;

            if (succes)
            {
                List<string> Etablissement = new List<string> (OperationsDb.GetEtablissement());
                var date = DateTime.Today.ToShortDateString();

                chaine = "Date de création : " + date;
                mesure = Convert.ToInt32(objetGraphique.MeasureString(chaine, police4).Width);
                dessineTexteCarteFace(police2, 1700 - mesure, 70, chaine, pbCarteFace, cbbSection);

                chaine = Etablissement[0];
                mesure = Convert.ToInt32(objetGraphique.MeasureString(chaine, police4).Width);
                dessineTexteCarteFace(police4, 1700 - mesure, 780, Etablissement[0], pbCarteFace, cbbSection);

                chaine = "Adresse : " + Etablissement[2] + " " + Etablissement[1];
                mesure = Convert.ToInt32(objetGraphique.MeasureString(chaine, police4).Width);
                dessineTexteCarteFace(police4, 1700 - mesure, 860, chaine, pbCarteFace, cbbSection);

                chaine = Etablissement[3] + " " + Etablissement[4];
                mesure = Convert.ToInt32(objetGraphique.MeasureString(chaine, police4).Width);
                dessineTexteCarteFace(police4, 1700 - mesure, 940, chaine, pbCarteFace, cbbSection);

                chaine = "Tel : " + Etablissement[5];
                mesure = Convert.ToInt32(objetGraphique.MeasureString(chaine, police4).Width);
                dessineTexteCarteFace(police4, 1700 - mesure, 1020, chaine, pbCarteFace, cbbSection);

                chaine = "Mail : " + Etablissement[6];
                mesure = Convert.ToInt32(objetGraphique.MeasureString(chaine, police4).Width);
                dessineTexteCarteFace(police4, 1700 - mesure, 1100, chaine, pbCarteFace, cbbSection);
            }

            pbCarteFace.Refresh();
        }

        // -- N'affiche que les classes correspondantes a la section selectionnées --
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.classePourNiveau(ComboBox, ComboBox)'
        public static void classePourNiveau(ComboBox cbbSection, ComboBox cbbClasse)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.classePourNiveau(ComboBox, ComboBox)'
        {
            switch (cbbSection.Text)
            {
                case "6eme":
                    cbbClasse.DataSource = Globale.Classes6Eme;
                    break;

                case "5eme":
                    cbbClasse.DataSource = Globale.Classes5Eme;
                    break;

                case "4eme":
                    cbbClasse.DataSource = Globale.Classes4Eme;
                    break;

                case "3eme":
                    cbbClasse.DataSource = Globale.Classes3Eme;
                    break;
            }
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.reprendPrenom(string, PictureBox, ComboBox)'
        public static void reprendPrenom(string txtPrenom, PictureBox pbCarteFace,
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.reprendPrenom(string, PictureBox, ComboBox)'
            ComboBox cbbSection)
        {
            if (txtPrenom != "")
            {
                if (txtPrenom.Length < 15)
                {
                    var font = new Font("Calibri", 28, FontStyle.Bold);
                    dessineTexteCarteFace(font, 325, 1075, txtPrenom, pbCarteFace, cbbSection);
                    pbCarteFace.Refresh();
                }
                else
                {
                    fondCarteNiveau(pbCarteFace, cbbSection);
                    var font = new Font("Calibri", 25, FontStyle.Bold);
                    dessineTexteCarteFace(font, 325, 1075, txtPrenom, pbCarteFace, cbbSection);
                    pbCarteFace.Refresh();
                }
            }
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.reprendNom(string, PictureBox, ComboBox)'
        public static void reprendNom(string txtNom, PictureBox pbCarteFace, ComboBox cbbSection)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.reprendNom(string, PictureBox, ComboBox)'
        {
            if (txtNom != "")
            {
                if (txtNom.Length < 15)
                {
                    var font = new Font("times new roman", 28, FontStyle.Bold);
                    dessineTexteCarteFace(font, 250, 960, txtNom, pbCarteFace, cbbSection);
                    pbCarteFace.Refresh();
                }
                else
                {
                    fondCarteNiveau(pbCarteFace, cbbSection);
                    var font = new Font("times new roman", 25, FontStyle.Bold);
                    dessineTexteCarteFace(font, 250, 960, txtNom, pbCarteFace, cbbSection);
                    pbCarteFace.Refresh();
                }
            }
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.getDateFace()'
        public static string getDateFace()
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.getDateFace()'
        {
            if (File.Exists("./data/FichierCartesFace/6eme.png"))
                return File.GetCreationTime("./data/FichierCartesFace/6eme.png").ToString();

            if (File.Exists("./data/FichierCartesFace/5eme.png"))
                return File.GetCreationTime("./data/FichierCartesFace/5eme.png").ToString();

            if (File.Exists("./data/FichierCartesFace/3eme.png"))
                return File.GetCreationTime("./data/FichierCartesFace/3eme.png").ToString();

            if (File.Exists("./data/FichierCartesFace/4eme.png"))
                return File.GetCreationTime("./data/FichierCartesFace/4eme.png").ToString();

            return null;
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.checkMef(RadioButton, RadioButton, RadioButton, PictureBox, ComboBox, Button, TextBox, TextBox)'
        public static void checkMef(RadioButton rdbUlis, RadioButton rdbUPE2A, RadioButton rdbClRelais,
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.checkMef(RadioButton, RadioButton, RadioButton, PictureBox, ComboBox, Button, TextBox, TextBox)'
            PictureBox pbCarteFace, ComboBox cbbSection, Button btnEdtPerso, TextBox txtNom, TextBox txtPrenom)
        {
            if (rdbUlis.Checked)
            {
                fondCarteNiveau(pbCarteFace, cbbSection);
                reprendNom(txtNom.Text, pbCarteFace, cbbSection);
                reprendPrenom(txtPrenom.Text, pbCarteFace, cbbSection);
                var police = new Font("Calibri", 30, FontStyle.Bold);
                dessineTexteCarteFace(police, 50, 230, "ULIS ", pbCarteFace, cbbSection);
                pbCarteFace.Refresh();
                btnEdtPerso.Enabled = true;
            }
            else if (rdbUPE2A.Checked)
            {
                fondCarteNiveau(pbCarteFace, cbbSection);
                reprendNom(txtNom.Text, pbCarteFace, cbbSection);
                reprendPrenom(txtPrenom.Text, pbCarteFace, cbbSection);
                var police = new Font("Calibri", 30, FontStyle.Bold);
                dessineTexteCarteFace(police, 50, 230, "UPE2A", pbCarteFace, cbbSection);
                pbCarteFace.Refresh();
                btnEdtPerso.Enabled = true;
            }
            else if (rdbClRelais.Checked)
            {
                fondCarteNiveau(pbCarteFace, cbbSection);
                reprendNom(txtNom.Text, pbCarteFace, cbbSection);
                reprendPrenom(txtPrenom.Text, pbCarteFace, cbbSection);
                var police = new Font("Calibri", 30, FontStyle.Bold);
                dessineTexteCarteFace(police, 50, 230, "CL-Relais", pbCarteFace, cbbSection);
                pbCarteFace.Refresh();
                btnEdtPerso.Enabled = true;
            }
            else
            {
                fondCarteNiveau(pbCarteFace, cbbSection);
                reprendNom(txtNom.Text, pbCarteFace, cbbSection);
                reprendPrenom(txtPrenom.Text, pbCarteFace, cbbSection);
                btnEdtPerso.Enabled = false;
            }
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.qrCodeFace(Graphics)'
        public static void qrCodeFace(Graphics objGraphique)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.qrCodeFace(Graphics)'
        {
            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());
            var bmpOriginal = QrCode.CreationQrCode(Etablissement[7]);
            var bmpFinal = new Bitmap(bmpOriginal, new Size(275, 275));

            objGraphique.DrawImage(bmpFinal, new Point(825, 925));
        }

        //Création de la carte face si elle n'a pas deja d'informations dessus
        public static Image ImageCarteFace(Eleve eleve, Font policenom, Font policeprenom)
        {
            var image = Image.FromFile("./data/default.png");
            string chemin = "./data/FichierCartesFace/" + eleve.NiveauEleve + ".png";

            if (File.Exists(chemin)) 
            {
                if (image != null)
                    image.Dispose();
                image = Image.FromFile("./data/FichierCartesFace/" + eleve.NiveauEleve + ".png");
            }

            var objGraphique = Graphics.FromImage(image);

            
            qrCodeFace(objGraphique);

            Brush pinceauNoir = new SolidBrush(Color.Black);

            var police = new Font("Calibri", 45, FontStyle.Bold);
            var police2 = new Font("Calibri", 22, FontStyle.Bold);
            var police3 = new Font("Calibri", 40, FontStyle.Bold);
            var police4 = new Font("Calibri", 25, FontStyle.Bold);

            var date = DateTime.Today.ToShortDateString();
            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());

            objGraphique = importCarteFace(chemin, Etablissement[8], objGraphique, eleve.NiveauEleve.Substring(0,1));

            //Dessine et rempli le fond pour l'écriture
            fondTexteCarteFace(objGraphique, eleve.ClasseEleve, police2, eleve, 50, 70);

            //Dessine la saisie en textbox
            var chaine = "Nom : " + eleve.NomEleve;
            fondTexteCarteFace(objGraphique, chaine, policenom, eleve, 50, 960);
            objGraphique.DrawString(chaine, policenom, pinceauNoir, 50, 960); // Dessine le texte sur l'image à la position X et Y + couleur
            chaine = "Prénom : " + eleve.PrenomEleve;
            fondTexteCarteFace(objGraphique, chaine, policeprenom, eleve, 50, 1075);
            objGraphique.DrawString(chaine, policeprenom, pinceauNoir, 50, 1075);

            fondTexteCarteFace(objGraphique, eleve.ClasseEleve, police, eleve, 50, 70);
            objGraphique.DrawString(eleve.ClasseEleve, police, pinceauNoir, 50, 70);

            chaine = Etablissement[0];
            var mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, eleve, 1050, 920);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1050, 920);

            chaine = "Mail : " + Etablissement[6];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, eleve, 1050, 965);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1050, 965);

            chaine = "Adresse : " + Etablissement[2] + " " + Etablissement[1];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, eleve, 1050, 1010);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1050, 1010);

            chaine = Etablissement[3] + " " + Etablissement[4];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, eleve, 1050, 1055);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1050, 1055);

            chaine = "Téléphone : " + Etablissement[5];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, eleve, 1050, 1100);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1050, 1100);

            objGraphique.Dispose(); // Libère les ressources



            return image;
        }
        //Création de la carte Face si elle a déja des infos dessus
        public static Image imageCarteFaceInfos(Eleve eleve, Font policenom, Font policeprenom)
        {
            var image = Image.FromFile("./data/default.png");

            string chemin = "./data/FichierCartesFace/" + eleve.NiveauEleve + ".png";

            if (File.Exists(chemin))
            {
                if (image != null)
                    image.Dispose();
                image = Image.FromFile("./data/FichierCartesFace/" + eleve.NiveauEleve + ".png");
            }

            var objGraphique = Graphics.FromImage(image);

            //qrCodeFace(objGraphique);

            Brush pinceauNoir = new SolidBrush(Color.Black);

            var police = new Font("Calibri", 45, FontStyle.Bold);
            var police2 = new Font("Calibri", 22, FontStyle.Bold);
            var police3 = new Font("Calibri", 40, FontStyle.Bold);
            var police4 = new Font("Calibri", 32, FontStyle.Bold);

            var date = DateTime.Today.ToShortDateString();
            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());

            objGraphique = importCarteFace(chemin, Etablissement[8], objGraphique, eleve.NiveauEleve.Substring(0, 1));

            //Dessine et rempli le fond pour l'écriture
            fondTexteCarteFace(objGraphique, eleve.ClasseEleve, police2, eleve, 50, 70);

            //Dessine la saisie en textbox
            var chaine = "Nom : " + eleve.NomEleve;
            fondTexteCarteFace(objGraphique, chaine, policenom, eleve, 50, 960);
            objGraphique.DrawString(chaine, policenom, pinceauNoir, 50, 960); // Dessine le texte sur l'image à la position X et Y + couleur
            chaine = "Prénom : " + eleve.PrenomEleve;
            fondTexteCarteFace(objGraphique, chaine, policeprenom, eleve, 50, 1075);
            objGraphique.DrawString(chaine, policeprenom, pinceauNoir, 50, 1075);

            fondTexteCarteFace(objGraphique, eleve.ClasseEleve, police, eleve, 50, 70);
            objGraphique.DrawString(eleve.ClasseEleve, police, pinceauNoir, 50, 70);

            objGraphique.Dispose(); // Libère les ressources

            return image;
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.carteFace(Eleve, string)'
        public static void carteFace(Eleve eleve, string chemin)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.carteFace(Eleve, string)'
        {
            // -- Déclare l'image --
            Image imageFace = null;

            // -- Gestion de la taille de la police --
            if (eleve.NomEleve.Length > 10 || eleve.PrenomEleve.Length > 10)
            {
                if (eleve.NomEleve.Length > 10 && eleve.PrenomEleve.Length > 10)
                {
                    var policenom = new Font("Calibri", 25, FontStyle.Bold);
                    var policeprenom = new Font("Calibri", 25, FontStyle.Bold);
                    if (Globale.InfosCarte == true)
                        imageFace = imageCarteFaceInfos(eleve, policenom, policeprenom);
                    else
                        imageFace = ImageCarteFace(eleve, policenom, policeprenom);
                }
                else if (eleve.NomEleve.Length > 10)
                {
                    var policenom = new Font("Calibri", 25, FontStyle.Bold);
                    var policeprenom = new Font("Calibri", 40, FontStyle.Bold);
                    if (Globale.InfosCarte == true)
                        imageFace = imageCarteFaceInfos(eleve, policenom, policeprenom);
                    else
                        imageFace = ImageCarteFace(eleve, policenom, policeprenom);
                }
                else
                {
                    var policenom = new Font("Calibri", 40, FontStyle.Bold);
                    var policeprenom = new Font("Calibri", 25, FontStyle.Bold);
                    if (Globale.InfosCarte == true)
                        imageFace = imageCarteFaceInfos(eleve, policenom, policeprenom);
                    else
                        imageFace = ImageCarteFace(eleve, policenom, policeprenom);
                }
            }
            else
            {
                var police = new Font("Calibri", 40, FontStyle.Bold);
                if (Globale.InfosCarte == true)
                    imageFace = imageCarteFaceInfos(eleve, police, police);
                else
                    imageFace = ImageCarteFace(eleve, police, police);
            }

            // -- Sauvegarde l'image --
            imageFace.Save(chemin + "/" + eleve.NomEleve + eleve.PrenomEleve + "Carte.png", ImageFormat.Png);
            if (imageFace != null)
                imageFace.Dispose();
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.carteArriere(Eleve, PictureBox)'
        public static void carteArriere(Eleve eleve, PictureBox pbCarteArriere)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.carteArriere(Eleve, PictureBox)'
        {
            if (!eleve.SansEdt)
            {
                var cheminEdt = "./data/FichierEdtClasse/" + eleve.NiveauEleve + "/" + eleve.NomEleve + " " + eleve.PrenomEleve + ".jpg";
                if (pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                pbCarteArriere.Image = Image.FromFile(cheminEdt);
                //Edt.RognageEdt(pbCarteArriere, cheminEdt);
            }
            else
            {
                if (pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                pbCarteArriere.Image = Image.FromFile("./data/FichierEdtClasse/classes/" + eleve.ClasseEleve + ".jpg");
            }
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.ReplacementPhotoClassique(int, int)'
        public static void ReplacementPhotoClassique(int posx, int posy)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.ReplacementPhotoClassique(int, int)'
        {
            PosYClassique = posy;
            PosXClassique = posx;
        }

        public static Graphics importCarteFace(string chemin, string Etablissement, Graphics objgraph, string classeEleve)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.importCarteFace(string)'
        {
            var img = Image.FromFile(chemin);
            var bmp = new Bitmap(img, new Size(1754, 1240));
            List<Color> couleurs = new List<Color> { };
            couleurs = OperationsDb.GetColors();

            Brush brush6 = new SolidBrush(couleurs[0]);
            Brush brush5 = new SolidBrush(couleurs[1]);
            Brush brush4 = new SolidBrush(couleurs[2]);
            Brush brush3 = new SolidBrush(couleurs[3]);
            switch (classeEleve)
            {
                case "6":
                    objgraph.DrawRectangle(new Pen(brush6, 40), new Rectangle(0, 0, bmp.Width, bmp.Height));
                    break;
                case "5":
                    objgraph.DrawRectangle(new Pen(brush5, 40), new Rectangle(0, 0, bmp.Width, bmp.Height));
                    break;
                case "4":
                    objgraph.DrawRectangle(new Pen(brush4, 40), new Rectangle(0, 0, bmp.Width, bmp.Height));
                    break;
                case "3":
                    objgraph.DrawRectangle(new Pen(brush3, 40), new Rectangle(0, 0, bmp.Width, bmp.Height));
                    break;
            }
            return objgraph;
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.importEdtClassique(string)'
        public static void importEdtClassique(string chemin)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.importEdtClassique(string)'
        {
            var cheminDestination = Chemin.CheminEdtClassique;

            try
            {
                if (Directory.Exists(cheminDestination))
                {
                    foreach (var fichier in Directory.GetFiles(cheminDestination))
                        if (!fichier.Contains("Default"))
                            File.Delete(fichier);
                    Directory.Delete(cheminDestination);
                }

                Directory.CreateDirectory(cheminDestination);
            }
            catch
            {
                // ignored
            }
        }

        // -- Importation des photo des élèves --
#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.importPhoto(string)'
        public static void importPhoto(string chemin)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.importPhoto(string)'
        {
            var cheminSource = chemin;
            var cheminDestination = Chemin.CheminPhotoEleve;

            try
            {
                if (Directory.Exists(cheminDestination))
                {
                    foreach (var file in Directory.GetFiles(cheminDestination)) File.Delete(file);
                    Directory.Delete(cheminDestination);
                }

                Directory.CreateDirectory(cheminDestination);

                var directory = new DirectoryInfo(cheminSource);

                foreach (var file in directory.GetFiles())
                {
                    var img = Image.FromFile(file.FullName);
                    var nom = file.Name;
                    img.Save(cheminDestination + nom, ImageFormat.Png);
                    img.Dispose();
                }

                Globale.Actuelle.Invoke(new MethodInvoker(delegate
                {
                    foreach (Control controle in Globale.Actuelle.Controls)
                        if (controle is Label && controle.Name == "lblDateListeEleve")
                            controle.Text = readCsv.GetDateFile();
                }));

                MessageBox.Show(new Form { TopMost = true }, " Les photos du dossier ont été importés");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

#pragma warning disable CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.importLogo(string)'
        public static void importLogo(string chemin)
#pragma warning restore CS1591 // Commentaire XML manquant pour le type ou le membre visible publiquement 'Edition.importLogo(string)'
        {
            var cheminSource = chemin;
            var cheminDestination = "./data/";

            try
            {
                if (File.Exists("./data/logo.png")) File.Delete("./data/logo.png");

                var img = Image.FromFile(chemin);
                img.Save(cheminDestination + "logo.png", ImageFormat.Png);
                img.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}