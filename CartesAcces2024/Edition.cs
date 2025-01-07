/**
 * Ce fichier contient la classe Edition qui gère l'édition des cartes d'élèves.
 * Elle inclut des méthodes pour dessiner du texte, gérer les QR codes, et manipuler les images.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CartesAcces2024
{
    public static class Edition
    {
        // ** VARIABLES : Pour l'édition de l'emploi du temps (rognage) **
        public static bool SelectionClique { get; set; } = false;

        public static int RognageX { get; set; }
        public static int RognageY { get; set; }

        public static int RognageLargeur { get; set; }
        public static int RognageHauteur { get; set; }
        public static Pen RognagePen { get; set; }

        // ** VARIABLES  : Déplacement de la photo
        public static bool Drag { get; set; } = false;
        public static int PosX { get; set; }
        public static int PosY { get; set; }
        public static int PosXDef { get; set; }
        public static int PosYDef { get; set; }
        public static int PosHeightDef { get; set; }
        public static int PosWidthDef { get; set; }
        public static int PosXClassique { get; set; }
        public static int PosYClassique { get; set; }

        // ** VARIABLES : Chemin de l'image **
        public static string CheminFichier { get; set; }
        public static string CheminImpressionFinal { get; set; }

        // -- Dessine le rectangle de couleur derrière le texte pour une meilleure visibilité de celui-ci --
        public static void fondTexteCarteFace(Graphics objGraphique, string texte, Font police, int posX, int posY, ComboBox cbbSection)
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

        public static void fondTexteCarteFace(Graphics objGraphique, string texte, Font police, string classe, int posX,int posY)
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
            switch (classe.Substring(0, 1))
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

        public static void fondTexteCarteFaceFixe(Graphics objGraphique, string texte, Font police, string classe, int posX, int posY)
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
            switch (classe.Substring(0, 1))
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
        public static void dessineTexteCarteFace(Font police, int posX, int posY, string text, PictureBox pbCarteFace,
            ComboBox cbbSection)
        {
            // Pinceaux et graphique
            var objetGraphique = Graphics.FromImage(pbCarteFace.Image);
            Brush pinceauNoir = new SolidBrush(Color.Black);

            // Dessine et rempli le fond pour l'écriture
            fondTexteCarteFace(objetGraphique, text, police, posX, posY, cbbSection);

            // Dessine la saisie en textbox
            objetGraphique.DrawString(text, police, pinceauNoir, posX,
                posY); // Dessine le texte sur l'image à la position X et Y + couleur
            objetGraphique.Dispose(); // Libère les ressources
        }

        // -- Récupère et place le QR code sur la face de la carte
        public static void qrCodeFace(PictureBox pbCarteFace)
        {
            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());
            var bmpOriginal = QrCode.CreationQrCode(Etablissement[7]);
            var bmpFinal = new Bitmap(bmpOriginal, new Size(220, 220));

            var objGraphique = Graphics.FromImage(pbCarteFace.Image);
            objGraphique.DrawImage(bmpFinal, new Point(1350, 80));
        }

        // Preview carte provisoire si la carte n'a pas d'infos
        public static void fondCarteNiveau(PictureBox pbCarteFace, ComboBox cbbSection, string nomEleve, string prenomEleve, string classe)
        {
            var police = new Font("Calibri", 45, FontStyle.Bold);
            var police2 = new Font("Calibri", 22, FontStyle.Bold);
            var police3 = new Font("Calibri", 40, FontStyle.Bold);
            var police4 = new Font("Calibri", 16, FontStyle.Bold);
            var policenom = new Font("Calibri", 25, FontStyle.Bold);
            var policeprenom = new Font("Calibri", 25, FontStyle.Bold);
            if (File.Exists(Chemin.DossierCartesFace + Globale.CheminFaceCarte + "Face.png"))
            {
                var bmp = new Bitmap(Chemin.DossierCartesFace + Globale.CheminFaceCarte + "Face.png");
                bmp.SetResolution(150, 150);
                pbCarteFace.Image = bmp;
            }
            else
            {
                var bmp = new Bitmap(Chemin.CheminFaceDefault);
                bmp.SetResolution(150, 150);
                pbCarteFace.Image = bmp;
            }

            if (nomEleve.Length > 10 || prenomEleve.Length > 10)
            {
                if (nomEleve.Length > 10 && prenomEleve.Length > 10)
                {
                    policenom = new Font("Calibri", 25, FontStyle.Bold);
                    policeprenom = new Font("Calibri", 25, FontStyle.Bold);
                }
                else if (nomEleve.Length > 10)
                {
                    policenom = new Font("Calibri", 25, FontStyle.Bold);
                    policeprenom = new Font("Calibri", 40, FontStyle.Bold);
                }
                else
                {
                    policenom = new Font("Calibri", 40, FontStyle.Bold);
                    policeprenom = new Font("Calibri", 25, FontStyle.Bold);
                }
            }
            else
            {
                police = new Font("Calibri", 40, FontStyle.Bold);
            }

            Brush pinceauNoir = new SolidBrush(Color.Black);

            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());
            var date = DateTime.Today.ToShortDateString();

            var objGraphique = Graphics.FromImage(pbCarteFace.Image);
            string niveauel = classe.Substring(0, 1) + "eme";
            string chemin = "";
            if (niveauel == "0eme")
            {
                chemin = Chemin.DossierCartesFace + "default.png";
            }
            else
            {
                chemin = Chemin.DossierCartesFace + niveauel + ".png";
            }

            qrCodeFaceProvisoire(objGraphique);

            importCarteFace(chemin, objGraphique, classe.Substring(0, 1));

            fondTexteCarteFace(objGraphique, classe, police2, classe, 50, 70);

            //Dessine la saisie en textbox
            var chaine = "Nom : " + nomEleve;
            fondTexteCarteFace(objGraphique, chaine, policenom, classe, 50, 960);
            objGraphique.DrawString(chaine, policenom, pinceauNoir, 50, 960);

            chaine = "Prenom : " + prenomEleve;
            fondTexteCarteFace(objGraphique, chaine, policeprenom, classe, 50, 1075);
            objGraphique.DrawString(chaine, policeprenom, pinceauNoir, 50, 1075);

            fondTexteCarteFace(objGraphique, classe, police, classe, 50, 70);
            objGraphique.DrawString(classe, police, pinceauNoir, 50, 70);

            chaine = Etablissement[0];
            var mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 985);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 985);

            chaine = "Mail : " + Etablissement[6];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 1030);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 1030);

            chaine = "Adresse : " + Etablissement[2] + " " + Etablissement[1];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 1075);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 1075);

            chaine = Etablissement[3] + " " + Etablissement[4];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 1120);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 1120);

            chaine = "Téléphone : " + Etablissement[5];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 1165);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 1165);

            pbCarteFace.Refresh();

            objGraphique.Dispose(); // Libère les ressources
        }

        //Preview carteProvisoire si la carte a des infos
        public static void FondCarteNiveauInfos(PictureBox pbCarteFace, ComboBox cbbSection, string nomEleve, string prenomEleve, string classe)
        {
            if (File.Exists(Chemin.DossierCartesFace + Globale.CheminFaceCarte + "Face.png"))
            {
                var bmp = new Bitmap(Chemin.DossierCartesFace + Globale.CheminFaceCarte + "Face.png");
                bmp.SetResolution(150, 150);
                pbCarteFace.Image = bmp;
            }
            else
            {
                var bmp = new Bitmap(Chemin.CheminFaceDefault);
                bmp.SetResolution(150, 150);
                pbCarteFace.Image = bmp;
            }

            var police = new Font("Calibri", 20, FontStyle.Bold);
            var police2 = new Font("Calibri", 22, FontStyle.Bold);
            var police3 = new Font("Calibri", 40, FontStyle.Bold);
            var police4 = new Font("Calibri", 25, FontStyle.Bold);
            var policenom = new Font("Calibri", 25, FontStyle.Bold);
            var policeprenom = new Font("Calibri", 25, FontStyle.Bold);

            if (nomEleve.Length > 10 || prenomEleve.Length > 10)
            {
                if (nomEleve.Length > 10 && prenomEleve.Length > 10)
                {
                    policenom = new Font("Calibri", 25, FontStyle.Bold);
                    policeprenom = new Font("Calibri", 25, FontStyle.Bold);
                }
                else if (nomEleve.Length > 10)
                {
                    policenom = new Font("Calibri", 25, FontStyle.Bold);
                    policeprenom = new Font("Calibri", 40, FontStyle.Bold);
                }
                else
                {
                    policenom = new Font("Calibri", 40, FontStyle.Bold);
                    policeprenom = new Font("Calibri", 25, FontStyle.Bold);
                }
            }
            else
            {
                police = new Font("Calibri", 40, FontStyle.Bold);
            }

            Brush pinceauNoir = new SolidBrush(Color.Black);

            var objGraphique = Graphics.FromImage(pbCarteFace.Image);
            string niveauel = classe.Substring(0, 1) + "eme";
            string chemin = "";
            if (niveauel == "0eme")
            {
                chemin = Chemin.DossierCartesFace + "default.png";
            }
            else
            {
                chemin = Chemin.DossierCartesFace + niveauel + ".png";
            }

            importCarteFace(chemin, objGraphique, classe.Substring(0, 1));

            //Dessine et rempli le fond pour l'écriture
            fondTexteCarteFace(objGraphique, classe, police2, classe, 25, 70);

            //Dessine la saisie en textbox
            var chaine = "Nom : " + nomEleve;
            fondTexteCarteFace(objGraphique, chaine, policenom, classe, 25, 960);
            objGraphique.DrawString(chaine, policenom, pinceauNoir, 25, 960);

            chaine = "Prénom : " + prenomEleve;
            fondTexteCarteFace(objGraphique, chaine, policeprenom, classe, 25, 1075);
            objGraphique.DrawString(chaine, policeprenom, pinceauNoir, 25, 1075);

            fondTexteCarteFace(objGraphique, classe, police, classe, 25, 70);
            objGraphique.DrawString(classe, police, pinceauNoir, 25, 70);

            pbCarteFace.Refresh();

            objGraphique.Dispose();
        }

        public static void qrCodeFace(Graphics objGraphique)
        {
            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());
            var bmpOriginal = QrCode.CreationQrCode(Etablissement[7]);
            var bmpFinal = new Bitmap(bmpOriginal, new Size(275, 275));

            objGraphique.DrawImage(bmpFinal, new Point(880, 990));
        }

        public static void qrCodeFaceProvisoire(Graphics objGraphique)
        {
            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());
            var bmpOriginal = QrCode.CreationQrCode(Etablissement[7]);
            var bmpFinal = new Bitmap(bmpOriginal, new Size(180, 180));

            objGraphique.DrawImage(bmpFinal, new Point(875, 980));
        }

        //Création de la carte face si elle n'a pas deja d'informations dessus
        public static Image ImageCarteFace(Eleve eleve, Font policenom, Font policeprenom)
        {
            var image = Image.FromFile(Chemin.CheminFaceDefault);
            string chemin = Chemin.DossierCartesFace + Globale.CheminFaceCarte + "Face.png";

            if (File.Exists(chemin)) 
            {
                if (image != null)
                    image.Dispose();
                image = Image.FromFile(Chemin.DossierCartesFace + eleve.NiveauEleve + ".png");
            }

            var objGraphique = Graphics.FromImage(image);

            
            qrCodeFace(objGraphique);

            Brush pinceauNoir = new SolidBrush(Color.Black);

            string classe = eleve.ClasseEleve;

            var police = new Font("Calibri", 45, FontStyle.Bold);
            var police2 = new Font("Calibri", 22, FontStyle.Bold);
            var police3 = new Font("Calibri", 40, FontStyle.Bold);
            var police4 = new Font("Calibri", 25, FontStyle.Bold);

            var date = DateTime.Today.ToShortDateString();
            List<string> Etablissement = new List<string>(OperationsDb.GetEtablissement());

            objGraphique = importCarteFace(chemin, objGraphique, eleve.NiveauEleve.Substring(0,1));

            //Dessine et rempli le fond pour l'écriture
            fondTexteCarteFace(objGraphique, classe, police2, classe, 50, 70);

            //Dessine la saisie en textbox
            var chaine = "Nom : " + eleve.NomEleve;
            fondTexteCarteFace(objGraphique, chaine, policenom, classe, 50, 960);
            objGraphique.DrawString(chaine, policenom, pinceauNoir, 50, 960); // Dessine le texte sur l'image à la position X et Y + couleur

            chaine = "Prénom : " + eleve.PrenomEleve;
            fondTexteCarteFace(objGraphique, chaine, policeprenom, classe, 50, 1075);
            objGraphique.DrawString(chaine, policeprenom, pinceauNoir, 50, 1075);

            fondTexteCarteFace(objGraphique, eleve.ClasseEleve, police, classe, 50, 70);
            objGraphique.DrawString(eleve.ClasseEleve, police, pinceauNoir, 50, 70);

            chaine = Etablissement[0];
            var mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 985);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 985);

            chaine = "Mail : " + Etablissement[6];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 1030);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 1030);

            chaine = "Adresse : " + Etablissement[2] + " " + Etablissement[1];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 1075);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 1075);

            chaine = Etablissement[3] + " " + Etablissement[4];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 1120);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 1120);

            chaine = "Téléphone : " + Etablissement[5];
            mesure = Convert.ToInt32(objGraphique.MeasureString(chaine, police4).Width);
            fondTexteCarteFaceFixe(objGraphique, chaine, police4, classe, 1100, 1165);
            objGraphique.DrawString(chaine, police4, pinceauNoir, 1100, 1165);

            objGraphique.Dispose(); // Libère les ressources

            return image;
        }
        //Création de la carte Face si elle a déja des infos dessus
        public static Image imageCarteFaceInfos(Eleve eleve, Font policenom, Font policeprenom)
        {
            var image = Image.FromFile(Chemin.CheminFaceDefault);

            string chemin = Chemin.DossierCartesFace + eleve.NiveauEleve + ".png";

            if (File.Exists(chemin))
            {
                if (image != null)
                    image.Dispose();
                image = Image.FromFile(Chemin.DossierCartesFace + eleve.NiveauEleve + ".png");
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

            objGraphique = importCarteFace(chemin, objGraphique, eleve.NiveauEleve.Substring(0, 1));

            string classe = eleve.ClasseEleve;

            //Dessine et rempli le fond pour l'écriture
            fondTexteCarteFace(objGraphique, eleve.ClasseEleve, police2, classe, 50, 70);

            //Dessine la saisie en textbox
            var chaine = "Nom : " + eleve.NomEleve;
            fondTexteCarteFace(objGraphique, chaine, policenom, classe, 50, 960);
            objGraphique.DrawString(chaine, policenom, pinceauNoir, 50, 960);

            chaine = "Prénom : " + eleve.PrenomEleve;
            fondTexteCarteFace(objGraphique, chaine, policeprenom, classe, 50, 1075);
            objGraphique.DrawString(chaine, policeprenom, pinceauNoir, 50, 1075);

            fondTexteCarteFace(objGraphique, eleve.ClasseEleve, police, classe, 50, 70);
            objGraphique.DrawString(eleve.ClasseEleve, police, pinceauNoir, 50, 70);

            objGraphique.Dispose(); // Libère les ressources

            return image;
        }

        public static void carteFace(Eleve eleve, string chemin)
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

        public static void carteArriere(Eleve eleve, PictureBox pbCarteArriere)
        {
            if (!eleve.SansEdt)
            {
                var cheminEdt = Chemin.DossierEdtClassique + eleve.NiveauEleve + "/" + eleve.NomEleve + " " + eleve.PrenomEleve + ".jpg";
                if (pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                pbCarteArriere.Image = null;
                pbCarteArriere.Image = Image.FromFile(cheminEdt);
                //Edt.RognageEdt(pbCarteArriere, cheminEdt);
            }
            else
            {
                if (pbCarteArriere.Image != null)
                    pbCarteArriere.Image.Dispose();
                pbCarteArriere.Image = null;
                if (File.Exists(Chemin.DossierEdtClassique + "/classes/" + eleve.ClasseEleve + ".jpg"))
                    pbCarteArriere.Image = Image.FromFile(Chemin.DossierEdtClassique + "/classes/" + eleve.ClasseEleve + ".jpg");
                else
                    pbCarteArriere.Image = new Bitmap(297, 210);
            }
        }

        public static void ReplacementPhotoClassique(int posx, int posy)
        {
            PosYClassique = posy;
            PosXClassique = posx;
        }

        public static Graphics importCarteFace(string chemin, Graphics objgraph, string classeEleve)
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

        // -- Importation des photo des élèves --
        public static void importPhoto(string chemin)
        {
            var cheminSource = chemin;
            var cheminDestination = Chemin.DossierPhotoEleve;

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
    }
}