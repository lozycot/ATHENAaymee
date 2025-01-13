/**
 * Ce fichier contient la classe FichierWord qui gère la création et la manipulation de documents Word.
 * Elle inclut des méthodes pour initialiser un fichier Word, ajouter des images, et sauvegarder le document.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using System.ComponentModel;

namespace CartesAcces2024
{
    /// <summary>
    /// Classe pour gérer les opérations sur les fichiers Word.
    /// </summary>
    public static class FichierWord
    {
        /// <summary>
        /// Initialise un fichier Word avec des marges spécifiées.
        /// </summary>
        /// <param name="margeHaute">Marge haute en points.</param>
        /// <param name="margeDroite">Marge droite en points.</param>
        /// <param name="margeGauche">Marge gauche en points.</param>
        /// <param name="margeBasse">Marge basse en points.</param>
        /// <returns>Une instance de l'application Word.</returns>
        public static Application InitWordFile(int margeHaute, int margeDroite, int margeGauche, int margeBasse)
        {


            try
            {
                //FermerWord();
                // -- Ouverture de l'applucation Word -- 
                var applicationWord = new Application();

                // -- Nouveau Document --
                applicationWord.Documents.Add();

                applicationWord.ActiveDocument.PageSetup.PaperSize = WdPaperSize.wdPaperA4;

                // -- Marge à 0 pour éviter les espaces blancs entre la page et l'image sur le document --
                applicationWord.ActiveDocument.PageSetup.TopMargin = margeHaute; // 15 points = env à 0.5 cm
                applicationWord.ActiveDocument.PageSetup.RightMargin = margeDroite;
                applicationWord.ActiveDocument.PageSetup.LeftMargin = margeGauche;
                applicationWord.ActiveDocument.PageSetup.BottomMargin = margeBasse;


                return applicationWord;
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                MessageBox.Show("Une erreur s'est produite. L'application vas se fermer.\n" +
                    "Assurez-vous que Microsoft Word est installé sur votre ordinateur!");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                return null;
            }

        }

        /// <summary>
        /// Sauvegarde une planche de photos au format PDF.
        /// </summary>
        /// <param name="margeHaute"></param>
        /// <param name="margeDroite"></param>
        /// <param name="margeGauche"></param>
        /// <param name="margeBasse"></param>
        /// <returns></returns>
        public static Application InitWordFileA3(int margeHaute, int margeDroite, int margeGauche, int margeBasse)
        {
            //FermerWord();
            // -- Ouverture de l'applucation Word -- 
            var applicationWord = new Application();

            // -- Nouveau Document --
            applicationWord.Documents.Add();

            applicationWord.ActiveDocument.PageSetup.PaperSize = WdPaperSize.wdPaperA3;

            // -- Marge à 0 pour éviter les espaces blancs entre la page et l'image sur le document --
            applicationWord.ActiveDocument.PageSetup.TopMargin = margeHaute; // 15 points = env à 0.5 cm
            applicationWord.ActiveDocument.PageSetup.RightMargin = margeDroite;
            applicationWord.ActiveDocument.PageSetup.LeftMargin = margeGauche;
            applicationWord.ActiveDocument.PageSetup.BottomMargin = margeBasse;


            return applicationWord;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationWord"></param>
        /// <param name="carteFace1"></param>
        /// <param name="carteFace2"></param>
        public static void RectifPositionImages(Application applicationWord, Shape carteFace1, Shape carteFace2)
        {
            // -- Gestion de la hauteur et de la position des images --
            /*
             * Le but ici est d'avoir un espace blanc d'environ 1cm au milieu de la page, entre les deux image, pour la découpe.
             * On définit la position de la deuxieme image par rapport au haut de la page afin d'ancrer celle au bas de la page.
             * Et enfin on gère la hauteur des deux images pour que celles ci aient les mêmes dimensions.
            */

            carteFace1.Height = 379;

            carteFace1.Top = 0;
            carteFace1.Left = 0;

            carteFace2.Height = carteFace1.Height;
            carteFace2.Top = carteFace1.Height + 50;
            carteFace2.Left = 0;

            carteFace1.Height = carteFace1.Height - 20;
            carteFace2.RelativeVerticalPosition = WdRelativeVerticalPosition.wdRelativeVerticalPositionPage;
            carteFace2.Top = applicationWord.InchesToPoints(14 - carteFace1.Height / 48);
            carteFace2.Height = carteFace1.Height;
        }

        public static void RectifPositionImagesA5(Application applicationWord, Shape carteFace1)
        {
            // -- Gestion de la hauteur et de la position des images --
            /*
             * Le but ici est d'avoir un espace blanc d'environ 1cm au milieu de la page, entre les deux image, pour la découpe.
             * On définit la position de la deuxieme image par rapport au haut de la page afin d'ancrer celle au bas de la page.
             * Et enfin on gère la hauteur des deux images pour que celles ci aient les mêmes dimensions.
            */

            carteFace1.Height = 380;

            carteFace1.Top = 90;
            carteFace1.Left = -78;
            carteFace1.Width = carteFace1.Width + 157;
            //carteFace1.Height = carteFace1.Height - 10;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="applicationWord"></param>
        /// <param name="chemin"></param>
        /// <param name="nbPage"></param>
        public static void Limite50Pages(Application applicationWord, string chemin, int nbPage)
        {
            // -- Sauvegarde du document --
            applicationWord.ActiveDocument.SaveAs(chemin + "Part " + nbPage + " " + ".doc", Type.Missing, Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // -- Ferme le document --
            applicationWord.ActiveDocument.Close();

            //Permet d'éviter la surcharge de mémoire qui s'arrête à 2400 ko, puis l'application s'arrête
            GC.Collect();

            // -- Nouveau Document --
            applicationWord.Documents.Add();

            // -- Marge à 0 pour éviter les espaces blancs entre la page et l'image sur le document --
            applicationWord.ActiveDocument.PageSetup.TopMargin = 15;
            applicationWord.ActiveDocument.PageSetup.RightMargin = 15;
            applicationWord.ActiveDocument.PageSetup.LeftMargin = 15;
            applicationWord.ActiveDocument.PageSetup.BottomMargin = 15;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chemin"></param>
        /// <param name="listeEleve"></param>
        /// <param name="pbPhoto"></param>
        /// <param name="pbCarteArriere"></param>
        public static void SauvegardeCarteEnWord(string chemin, List<Eleve> listeEleve, PictureBox pbPhoto,PictureBox pbCarteArriere)
        {
            //FermerWord();
            var k = 0;
            var pages = 0;

            Eleve.PossedeEdt(listeEleve);
            var fichierWord = InitWordFile(15, 15, 15, 15);
            if (Globale.carteParListe == true)
            {
                Directory.CreateDirectory(chemin + "/CartesParListe");
                chemin = chemin + "/CartesParListe";
                Globale.carteParListe = false;
            }
            else if (Globale.ImprNiveau == true)
            {
                Directory.CreateDirectory(chemin + "/" + Globale.ListeEleveImpr[0].NiveauEleve);
                chemin = chemin + Globale.ListeEleveImpr[0].NiveauEleve;
                Globale.ImprNiveau = false;
            }
            else if(Globale.carteProvisoire == true)
            {
                Directory.CreateDirectory(chemin + "/CartesProvisoires");
                chemin = chemin + "/CartesProvisoires";
                Globale.carteProvisoire = false;
            }
            else
            {
                Directory.CreateDirectory(chemin + "/" + Globale.ListeEleveImpr[0].NiveauEleve + "/" + Globale.ListeEleveImpr[0].ClasseEleve);
                chemin = chemin + "/" + Globale.ListeEleveImpr[0].NiveauEleve + "/" + Globale.ListeEleveImpr[0].ClasseEleve;
            }

            Globale.LblCount.Visible = true;
            Globale.ListeEleveSansPhoto.Clear();
            for (var compt = 1; compt <= listeEleve.Count; compt += 2)
            {
                Globale.LblCount.Text = compt + "/" + listeEleve.Count + " cartes réalisées";

                // -- Les élèves sont gérés deux par deux --

                // -- Carte Face : 1/2 Eleve --
                Edition.carteFace(listeEleve[compt], chemin);
                // -- Carte Face : 2/2 Eleve --
                Edition.carteFace(listeEleve[compt - 1], chemin);

                // -- Ajout des deux fichier PNG au nouveau document Word --
                var shapeCarteFace1 = fichierWord.ActiveDocument.Shapes.AddPicture(
                    chemin + "\\" + listeEleve[compt].NomEleve + listeEleve[compt].PrenomEleve + "Carte.png",
                    Type.Missing, Type.Missing, Type.Missing);
                var shapeCarteFace2 = fichierWord.ActiveDocument.Shapes.AddPicture(
                    chemin + "\\" + listeEleve[compt - 1].NomEleve + listeEleve[compt - 1].PrenomEleve + "Carte.png",
                    Type.Missing, Type.Missing, Type.Missing);
                RectifPositionImages(fichierWord, shapeCarteFace1, shapeCarteFace2);
                // -- Suppression des deux fichiers PNG, plus besoin d'eux maintenant qu'ils sont dans le fichier Word -- 
                File.Delete(chemin + "\\" + listeEleve[compt].NomEleve + listeEleve[compt].PrenomEleve + "Carte.png");
                File.Delete(chemin + "\\" + listeEleve[compt - 1].NomEleve + listeEleve[compt - 1].PrenomEleve +"Carte.png");
                //Permet d'éviter la surcharge de mémoire qui s'arrête à 2400 ko, puis l'application s'arrête
                GC.Collect();
                // -- Nouvelle page --
                fichierWord.Selection.EndKey(WdUnits.wdStory, Missing.Value);
                fichierWord.Selection.InsertBreak(WdBreakType.wdSectionBreakNextPage);

                // ------------------------------------------------------------------

                // -- Carte arriere : 1/2 Eleve --
                Edition.carteArriere(listeEleve[compt], pbCarteArriere);
                Photo.VerifPhotoEleve(listeEleve[compt], pbPhoto);
                Photo.ProportionPhotoMultiple(pbPhoto, pbCarteArriere, listeEleve[compt], chemin);
                // -- Carte arriere : 2/2 Eleve --
                Edition.carteArriere(listeEleve[compt - 1], pbCarteArriere);
                Photo.VerifPhotoEleve(listeEleve[compt - 1], pbPhoto);
                Photo.ProportionPhotoMultiple(pbPhoto, pbCarteArriere, listeEleve[compt - 1], chemin);

                Globale.LblCount.Text = compt + 1 + "/" + listeEleve.Count + " cartes réalisées";

                // -- Ajout des deux fichier PNG au nouveau document Word --
                var shapeCarteArriere1 = fichierWord.ActiveDocument.Shapes.AddPicture(
                    chemin + "/" + listeEleve[compt].NomEleve + listeEleve[compt].PrenomEleve + "EDT.png", Type.Missing,
                    Type.Missing, Type.Missing);
                var shapeCarteArriere2 = fichierWord.ActiveDocument.Shapes.AddPicture(
                    chemin + "/" + listeEleve[compt - 1].NomEleve + listeEleve[compt - 1].PrenomEleve + "EDT.png",
                    Type.Missing, Type.Missing, Type.Missing);

                RectifPositionImages(fichierWord, shapeCarteArriere1, shapeCarteArriere2);

                // -- Suppression des deux fichiers PNG, plus besoin d'eux maintenant qu'ils sont dans le fichier Word -- 
                File.Delete(chemin + "\\" + listeEleve[compt].NomEleve + listeEleve[compt].PrenomEleve + "EDT.png");
                File.Delete(chemin + "\\" + listeEleve[compt - 1].NomEleve + listeEleve[compt - 1].PrenomEleve + "EDT.png");

                //Permet d'éviter la surcharge de mémoire qui s'arrête à 2400 ko, puis l'application s'arrête
                GC.Collect();

                // -- Nouvelle page --
                fichierWord.Selection.EndKey(WdUnits.wdStory, Missing.Value);


                fichierWord.Selection.InsertBreak(WdBreakType.wdPageBreak);

                if (compt > k + 50)
                {
                    var name = chemin + "/Imprimer ";
                    var nbPage = k / 50;
                    Limite50Pages(fichierWord, name, nbPage);
                    k += 50;
                    pages++;
                }
            }
            if (Globale.ListeEleveSansPhoto.Count != 0)
            {
                MessageBox.Show("Les élèves suivants n'ont pas de photo, veuillez vérifier l'orthographe des fichier jpg/png et les réimporter : " + string.Join(", ", Globale.ListeEleveSansPhoto));
            }


            if (k / 50 == 1)
            {
                if (File.Exists(chemin + "/Imprimer.doc"))
                    File.Delete(chemin + "/Imprimer.doc");
                fichierWord.ActiveDocument.SaveAs(chemin + "/Imprimer.doc", Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            else
            {
                if (File.Exists(chemin + "/Imprimer Part " + pages + ".doc"))
                    File.Delete(chemin + "/Imprimer Part " + pages + ".doc");
                fichierWord.ActiveDocument.SaveAs(chemin + "/Imprimer Part " + pages + ".doc", Type.Missing,
                    Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            // -- Ferme le document --
            fichierWord.ActiveDocument.Close();

            // -- Quitte l'application -- 
            fichierWord.Quit();

            // -- TaskKill --
            Marshal.FinalReleaseComObject(fichierWord);

            //Permet d'éviter la surcharge de mémoire qui s'arrête à 2400 ko, puis l'application s'arrête
            GC.Collect();

            // -- Message qui indique que nous sommes arrivé au bout --
            if (Globale.EleveImpr)
                MessageBox.Show(new Form { TopMost = true }, listeEleve.Count - 1 + " élèves ont été imprimés.");
            else
                MessageBox.Show(new Form { TopMost = true }, listeEleve.Count + " élèves ont été imprimés.");
            //FermerWord();
            FrmMultiplesCartesEdition.dernierCheminEnregistre = chemin;
        }

        public static void SauvegardeCarteEnWordA5(string chemin, List<Eleve> listeEleve, PictureBox pbPhoto, PictureBox pbCarteArriere)
        {
            //FermerWord();
            var k = 0;
            var pages = 0;

            Eleve.PossedeEdt(listeEleve);
            var fichierWord = InitWordFile(15, 15, 15, 15);
            //Change le répértoire si l'impression vient de carte par liste (car le document peut contenir des eleves de plusieurs classes et niveaux differents.
            if (Globale.carteParListe == true)
            {
                Directory.CreateDirectory(chemin + "/CartesParListe");
                chemin = chemin + "/CartesParListe";
                Globale.carteParListe = false;
            }
            else if (Globale.ImprNiveau == true)
            {
                Directory.CreateDirectory(chemin + "/" + Globale.ListeEleveImpr[0].NiveauEleve);
                chemin = chemin + Globale.ListeEleveImpr[0].NiveauEleve;
                Globale.ImprNiveau = false;
            }
            else if (Globale.carteProvisoire == true)
            {
                Directory.CreateDirectory(chemin + "/CartesProvisoires");
                chemin = chemin + "/CartesProvisoires";
                Globale.carteProvisoire = false;
            }
            else
            {
                Directory.CreateDirectory(chemin + "/" + Globale.ListeEleveImpr[0].NiveauEleve + "/" + Globale.ListeEleveImpr[0].ClasseEleve);
                chemin = chemin + "/" + Globale.ListeEleveImpr[0].NiveauEleve + "/" + Globale.ListeEleveImpr[0].ClasseEleve;
            }
            //Changement de la taille des pages en A5
            fichierWord.ActiveDocument.PageSetup.PaperSize = WdPaperSize.wdPaperA5;

            Globale.LblCount.Visible = true;
            Globale.ListeEleveSansPhoto.Clear();
            for (var compt = 0; compt < listeEleve.Count; compt += 1)
            {
                Globale.LblCount.Text = compt + "/" + listeEleve.Count + " cartes réalisées";


                // -- Carte Face : 1 Eleve --
                Edition.carteFace(listeEleve[compt], chemin);


                // -- Ajout des deux fichier PNG au nouveau document Word --
                var shapeCarteFace1 = fichierWord.ActiveDocument.Shapes.AddPicture(
                    chemin + "\\" + listeEleve[compt].NomEleve + listeEleve[compt].PrenomEleve + "Carte.png",
                    Type.Missing, Type.Missing, Type.Missing);
                RectifPositionImagesA5(fichierWord, shapeCarteFace1);
                shapeCarteFace1.Rotation = 90;
                // -- Suppression du fichiers PNG, plus utile maintenant qu'il est dans le fichier Word -- 
                File.Delete(chemin + "\\" + listeEleve[compt].NomEleve + listeEleve[compt].PrenomEleve + "Carte.png");
                //Permet d'éviter la surcharge de mémoire qui s'arrête à 2400 ko, puis l'application s'arrête
                GC.Collect();
                // -- Nouvelle page --
                fichierWord.Selection.EndKey(WdUnits.wdStory, Missing.Value);
                fichierWord.Selection.InsertBreak(WdBreakType.wdSectionBreakNextPage);

                // ------------------------------------------------------------------

                // -- Carte arriere : 1 Eleve --
                Edition.carteArriere(listeEleve[compt], pbCarteArriere);
                Photo.VerifPhotoEleve(listeEleve[compt], pbPhoto);
                Photo.ProportionPhotoMultiple(pbPhoto, pbCarteArriere, listeEleve[compt], chemin);


                Globale.LblCount.Text = compt + 1 + "/" + listeEleve.Count + " cartes réalisées";

                // -- Ajout des deux fichier PNG au nouveau document Word --
                var shapeCarteArriere1 = fichierWord.ActiveDocument.Shapes.AddPicture(
                    chemin + "/" + listeEleve[compt].NomEleve + listeEleve[compt].PrenomEleve + "EDT.png", Type.Missing,
                    Type.Missing, Type.Missing);

                RectifPositionImagesA5(fichierWord, shapeCarteArriere1);
                shapeCarteArriere1.Rotation = -90;
                // -- Suppression des deux fichiers PNG, plus besoin d'eux maintenant qu'ils sont dans le fichier Word -- 
                File.Delete(chemin + "\\" + listeEleve[compt].NomEleve + listeEleve[compt].PrenomEleve + "EDT.png");

                //Permet d'éviter la surcharge de mémoire qui s'arrête à 2400 ko, puis l'application s'arrête
                GC.Collect();

                // -- Nouvelle page --
                fichierWord.Selection.EndKey(WdUnits.wdStory, Missing.Value);


                fichierWord.Selection.InsertBreak(WdBreakType.wdPageBreak);

                if (compt > k + 50)
                {
                    var name = chemin + "/Imprimer ";
                    var nbPage = k / 50;
                    Limite50Pages(fichierWord, name, nbPage);
                    k += 50;
                    pages++;
                }
            }
            if (Globale.ListeEleveSansPhoto.Count != 0)
            {
                MessageBox.Show("Les élèves suivants n'ont pas de photo, veuillez vérifier l'orthographe des fichier jpg/png et les réimporter : " + string.Join(", ", Globale.ListeEleveSansPhoto));
            }


            if (k / 50 == 1)
            {
                if (File.Exists(chemin + "/Imprimer.doc"))
                    File.Delete(chemin + "/Imprimer.doc");
                fichierWord.ActiveDocument.SaveAs(chemin + "/Imprimer.doc", Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            else
            {
                if (File.Exists(chemin + "/Imprimer Part " + pages + ".doc"))
                    File.Delete(chemin + "/Imprimer Part " + pages + ".doc");
                fichierWord.ActiveDocument.SaveAs(chemin + "/Imprimer Part " + pages + ".doc", Type.Missing,
                    Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            // -- Ferme le document --
            fichierWord.ActiveDocument.Close();

            // -- Quitte l'application -- 
            fichierWord.Quit();

            // -- TaskKill --
            Marshal.FinalReleaseComObject(fichierWord);

            //Permet d'éviter la surcharge de mémoire qui s'arrête à 2400 ko, puis l'application s'arrête
            GC.Collect();

            // -- Message qui indique que nous sommes arrivé au bout --
            if (Globale.EleveImpr)
                MessageBox.Show(new Form { TopMost = true }, listeEleve.Count - 1 + " élèves ont été imprimés.");
            else
                MessageBox.Show(new Form { TopMost = true }, listeEleve.Count + " élèves ont été imprimés.");
            //FermerWord();
            FrmMultiplesCartesEdition.dernierCheminEnregistre = chemin;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void GetDossierCarteProvisoire()
        {
            var diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
                Edition.CheminImpressionFinal = diag.SelectedPath;

            else
                MessageBox.Show(new Form { TopMost = true },
                    "Merci de choisir un dossier de destination pour les fichiers générés par l'application");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbCarteArriere"></param>
        /// <param name="pbPhoto"></param>
        /// <param name="pbCarteFace"></param>
        /// <param name="txtNom"></param>
        /// <param name="txtPrenom"></param>
        public static void SauvegardeCarteProvisoireWord(PictureBox pbCarteArriere, PictureBox pbPhoto,
            PictureBox pbCarteFace, TextBox txtNom, TextBox txtPrenom)
        {
            //FermerWord();
            if (pbCarteArriere.Image != null && pbCarteFace.Image != null && pbPhoto.Image != null)
            {
                double rLocX = pbPhoto.Location.X * pbCarteArriere.Image.Width / pbCarteArriere.Width;
                double rLocY = pbPhoto.Location.Y * pbCarteArriere.Image.Height / pbCarteArriere.Height;
                double rWidth = pbPhoto.Width * pbCarteArriere.Image.Width / pbCarteArriere.Width;
                double rHeight = pbPhoto.Height * pbCarteArriere.Image.Height / pbCarteArriere.Height;

                // -- Rectifications des positions --
                var realLocX = Convert.ToInt32(Math.Round(rLocX)) - 2;
                var realLocY = Convert.ToInt32(Math.Round(rLocY)) + 3;
                var realWidth = Convert.ToInt32(Math.Round(rWidth)) - 1;
                var realHeight = Convert.ToInt32(Math.Round(rHeight)) - 1;

                var ObjGraphics = Graphics.FromImage(pbCarteArriere.Image);
                ObjGraphics.DrawImage(pbPhoto.Image, realLocX, realLocY, realWidth, realHeight);

                Edition.CheminImpressionFinal = Edition.CheminImpressionFinal + "\\";

                pbCarteArriere.Image.Save(Edition.CheminImpressionFinal + txtNom.Text + txtPrenom.Text + "EDT.png",
                    ImageFormat.Png);
                pbCarteFace.Image.Save(Edition.CheminImpressionFinal + txtNom.Text + txtPrenom.Text + "Carte.png",
                    ImageFormat.Png);

                var WordApp = new Application();
                WordApp.Documents.Add();
                WordApp.ActiveDocument.PageSetup.TopMargin = 15;
                WordApp.ActiveDocument.PageSetup.RightMargin = 15;
                WordApp.ActiveDocument.PageSetup.LeftMargin = 15;
                WordApp.ActiveDocument.PageSetup.BottomMargin = 15;

                var shapeCarte = WordApp.ActiveDocument.Shapes.AddPicture(
                    Edition.CheminImpressionFinal + txtNom.Text + txtPrenom.Text + "Carte.png", Type.Missing,
                    Type.Missing, Type.Missing);

                WordApp.Selection.EndKey();
                WordApp.Selection.InsertNewPage();

                var shapeEDT = WordApp.ActiveDocument.Shapes.AddPicture(
                    Edition.CheminImpressionFinal + txtNom.Text + txtPrenom.Text + "EDT.png", Type.Missing,
                    Type.Missing, Type.Missing);

                shapeCarte.Top = 0;
                shapeCarte.Left = 0;

                shapeEDT.Top = 0;
                shapeEDT.Height = shapeCarte.Height;

                File.Delete(Edition.CheminImpressionFinal + txtNom.Text + txtPrenom.Text + "EDT.png");
                File.Delete(Edition.CheminImpressionFinal + txtNom.Text + txtPrenom.Text + "Carte.png");

                WordApp.ActiveDocument.SaveAs(
                    Edition.CheminImpressionFinal + txtNom.Text + txtPrenom.Text + " Carte.doc", Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                WordApp.ActiveDocument.Close();
                WordApp.Quit();
                Marshal.FinalReleaseComObject(WordApp);

                GC.Collect();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void FermerWord()
        {
            var processes = Process.GetProcessesByName("WINWORD");
            try
            {
                foreach (var process in processes) process.Kill();
            }
            catch
            { }

        }


        /// <summary>
        /// Sauvegarder une planches photos / trombinoscope au format pdf
        /// </summary>
        /// <param name="nomsFichiersPlanches">ffn</param>
        /// <param name="dossierPlanches"></param>
        public static void SauvegarderPlanche(List<string> nomsFichiersPlanches, string dossierPlanches, BackgroundWorker worker, EditionPlanche.formatPage format)
        {
            //FermerWord();
            try
            {
                Application fichierWord = null;
                switch (format)
                {
                    case EditionPlanche.formatPage.A4:
                        fichierWord = InitWordFile(15, 15, 15, 15);
                        fichierWord.ActiveDocument.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                        break;
                    case EditionPlanche.formatPage.A3:
                        fichierWord = InitWordFileA3(15, 15, 15, 15);
                        break;
                }
                double nb = nomsFichiersPlanches.Count;
                for (var compt = 0; compt < nomsFichiersPlanches.Count; compt++)
                {
                    string imgPath = dossierPlanches + nomsFichiersPlanches[compt] + ".jpg"; 
                    var shape = fichierWord.ActiveDocument.Shapes.AddPicture(imgPath, Type.Missing, Type.Missing, Type.Missing);
                    shape.Top = 0;
                    shape.Left = 0;
                    fichierWord.Selection.EndKey(WdUnits.wdStory, Missing.Value);
                    fichierWord.Selection.InsertNewPage();
                    fichierWord.Selection.InsertBreak(WdBreakType.wdSectionBreakNextPage);

                    // calcul du pourcentage d'avancement
                    double p = (double)compt / nb * 100.0;
                    if (p < 0)
                        p = 0;
                    if (p > 100)
                        p = 100;
                    worker.ReportProgress((int)p);
                }

                fichierWord.ActiveDocument.SaveAs2(Globale.CheminDestination, WdSaveFormat.wdFormatPDF);
                fichierWord.ActiveDocument.Close(false);
                fichierWord.Quit();
                Marshal.FinalReleaseComObject(fichierWord);
                GC.Collect();
                Globale.MessageFinFrmChargement = "Fichier enregistré !";
            }
            catch (Exception err)
            {
                Globale.MessageFinFrmChargement = "Erreur de création du fichier word : " + err;
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
 */