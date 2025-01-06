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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;


namespace CartesAcces2024
{
    public static class Edt
    {
        // -- Selection du bon emploi du temps en fonction de la classe selectionnée
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cbbClasse"></param>
        /// <param name="pbCarteArriere"></param>
        public static void AfficheEmploiDuTemps(ComboBox cbbClasse, PictureBox pbCarteArriere)
        {
            try
            {
                if (cbbClasse.Text != "")
                {
                    var classe = cbbClasse.Text;
                    if (pbCarteArriere.Image != null)
                        pbCarteArriere.Image.Dispose();
                    pbCarteArriere.Image = Image.FromFile(Chemin.DossierEdtClassique + classe + ".jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbCarteArriere"></param>
        /// <param name="btnSelect"></param>
        public static void AjouterEdtPerso(PictureBox pbCarteArriere, Button btnSelect)
        {
            try
            {
                // -- Parcours des fichiers...
                var opf = new OpenFileDialog();

                var opfPath = "";

                opf.InitialDirectory = Chemin.DossierData + "ElevesEdt/";
                opf.Filter = "Images (*.png, *.jpg) | *.png; *.jpg";
                opf.FilterIndex = 1;
                opf.RestoreDirectory = true;
                Chemin.CheminEdtPerso = "";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    opfPath = opf.FileName;
                    // -- Ajout de l'image dans la picturebox, celle ci devient visible
                    pbCarteArriere.Image = new Bitmap(opfPath);
                    Chemin.CheminEdtPerso = opfPath;
                    btnSelect.Enabled = true;
                }
            }
            catch
            {
                btnSelect.Enabled = true;
            }
        }

        /// <summary>
        /// Rogne l'image de l'emploi du temps et affiche le résultat en temps réel.
        /// </summary>
        /// <param name="pbCarteArriere"></param>
        /// <param name="cheminEdt"></param>
        public static void RognageEdt(PictureBox pbCarteArriere)
        {
            //// -- Si la largeur a rogner est trop faible, on sort --
            if (Edition.RognageLargeur < 1) return;

            ///* -- Rectangle pour stocker l'image rognée avec les points calculés --
            //    Les dimensions calculées ci dessous utilisent les dimensions 920 x 604 (calcul par proportionnalité)
            //    qui sont celles des vrai fichier EDT !
            //    Cela permet d'éviter les problèmes de résolution d'image après le rognage */

            //// -- Je sais c'est moche mais j'ai pas eu le choix... --
            var rLargeurReel = (double)Edition.RognageLargeur * pbCarteArriere.Image.Width / pbCarteArriere.Width;
            var rHauteurReel = (double)Edition.RognageHauteur * pbCarteArriere.Image.Height / pbCarteArriere.Height;
            var rXReel = (double)Edition.RognageX * pbCarteArriere.Image.Width / pbCarteArriere.Width;
            var rYReel = (double)Edition.RognageY * pbCarteArriere.Image.Height / pbCarteArriere.Height;

            var rogagneLargeurReel = Convert.ToInt32(Math.Round(rLargeurReel));
            var rogagneHauteurReel = Convert.ToInt32(Math.Round(rHauteurReel));
            var rognageXReel = Convert.ToInt32(Math.Round(rXReel));
            var rogangeYReel = Convert.ToInt32(Math.Round(rYReel));

            var rectangle = new Rectangle(rognageXReel, rogangeYReel, rogagneLargeurReel, rogagneHauteurReel);

            //// -- On stock l'image original dans un bitmap --
            var imageOriginel = new Bitmap(pbCarteArriere.Image);

            //// -- Bitmap pour l'image rognée --
            var image = new Bitmap(rogagneLargeurReel, rogagneHauteurReel);

            //// -- Création d'un graphique depuis l'image rognée
            var graphique = Graphics.FromImage(image);

            //// -- Attributs de l'image --
            graphique.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphique.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphique.CompositingQuality = CompositingQuality.HighQuality;

            //// -- On dessine l'image original, avec les dimensions rognées dans le graphique 
            graphique.DrawImage(imageOriginel, 0, 0, rectangle, GraphicsUnit.Pixel);

            //// -- Affichage dans la picturebox
            if (pbCarteArriere.Image != null)
                pbCarteArriere.Image.Dispose();
            pbCarteArriere.Image = image;
            pbCarteArriere.SizeMode = PictureBoxSizeMode.StretchImage;

            //pbCarteArriere.Width = 540;
            //pbCarteArriere.Height = 354;
        }

        /// <summary>
        /// Rogne l'image de l'emploi du temps et affiche le résultat en temps réel, tout en adaptant
        /// l'affichage de la photo à ce nouveau rognage.
        /// </summary>
        /// <param name="pbCarteArriere"></param>
        /// <param name="cheminEdt"></param>
        public static void RognageEdt(PictureBox pbCarteArriere, PictureBox pbPhoto)
        {
            int originalW = pbCarteArriere.Image.Width;
            int originalH = pbCarteArriere.Image.Height;

            RognageEdt(pbCarteArriere);

            // Calcul du redimentionnement et repositionnement de pbPhoto
            Point pos = new Point(pbPhoto.Location.X - Edition.RognageX, pbPhoto.Location.Y - Edition.RognageY);
            pos.X = (int)((double)pos.X * (double)originalW / (double)pbCarteArriere.Width);
            pos.Y = (int)((double)pos.Y * (double)originalH / (double)pbCarteArriere.Height);
            pos.X = (int)((double)pos.X / (double)pbCarteArriere.Image.Width * (double)pbCarteArriere.Width);
            pos.Y = (int)((double)pos.Y / (double)pbCarteArriere.Image.Height * (double)pbCarteArriere.Height);
            pbPhoto.Location = pos;
            pbPhoto.Width = (int)((double)pbPhoto.Width * (double)originalW / (double)pbCarteArriere.Width);
            pbPhoto.Height = (int)((double)pbPhoto.Height * (double)originalH / (double)pbCarteArriere.Height);
            pbPhoto.Width = (int)((double)pbPhoto.Width / (double)pbCarteArriere.Image.Width * (double)pbCarteArriere.Width);
            pbPhoto.Height = (int)((double)pbPhoto.Height / (double)pbCarteArriere.Image.Height * (double)pbCarteArriere.Height);
            pbPhoto.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listeEleve"></param>
        /// <param name="pbCarteArriere"></param>
        public static void ChercheEdtPerso(List<Eleve> listeEleve, PictureBox pbCarteArriere)
        {
            if (pbCarteArriere.Image != null)
                pbCarteArriere.Image.Dispose();
            pbCarteArriere.Image = null;
            pbCarteArriere.Image = Image.FromFile(Chemin.DossierEdtClassique + listeEleve[0].NiveauEleve + "/" + listeEleve[0].NomEleve + " " + listeEleve[0].PrenomEleve + ".jpg");
        }

        public static void AddEleveProfilParticulier(List<Eleve> listeEleve, PictureBox pbCarteArriere)
        {
            if (pbCarteArriere.Image != null)
                pbCarteArriere.Image.Dispose();
            pbCarteArriere.Image = null;
            if (File.Exists(Chemin.CheminEdtVierge))
                pbCarteArriere.Image = Image.FromFile(Chemin.CheminEdtVierge);
            else
            {
                pbCarteArriere.Image = new Bitmap(297, 210);
                MessageBox.Show("Aucun emploi du temps vierge trouvé.");
            }
        }

        public static void AddEleveSansEdt(List<Eleve> listeEleve, PictureBox pbCarteArriere)
        {
            if (pbCarteArriere.Image != null)
                pbCarteArriere.Image.Dispose();
            pbCarteArriere.Image = null;
            if (File.Exists(Chemin.DossierEdtClassique + "classes/" + listeEleve[0].ClasseEleve + ".jpg"))
                pbCarteArriere.Image = Image.FromFile(Chemin.DossierEdtClassique + "classes/" + listeEleve[0].ClasseEleve + ".jpg");
            else
            {
                pbCarteArriere.Image = new Bitmap(297, 210);
                throw new Exception("Aucune image d'emploi du temps trouvée, avez-vous importé les emplois du temps de classes ?");
            }
        }
    }
}