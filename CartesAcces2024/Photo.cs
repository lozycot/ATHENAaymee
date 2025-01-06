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
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System;

namespace CartesAcces2024
{
    /// <summary>
    /// Cette classe permet de gérer les photos
    /// </summary>
    public static class Photo
    {
        /// <summary>
        /// Cette fonction permet de vérifier si une photo existe pour un élève
        /// </summary>
        /// <param name="eleve"></param>
        /// <param name="pbPhoto"></param>
        public static void VerifPhotoEleve(Eleve eleve, PictureBox pbPhoto)
        {
            var nomFichierJpg = eleve.NomEleve + " " + eleve.PrenomEleve + ".jpg";
            var nomFichierPng = eleve.NomEleve + " " + eleve.PrenomEleve + ".png";
            if (pbPhoto.Image != null)
                pbPhoto.Image.Dispose();

            if (File.Exists(Chemin.DossierPhotoEleve + eleve.NiveauEleve + "/" + nomFichierJpg))
                pbPhoto.Image = Image.FromFile(Chemin.DossierPhotoEleve + eleve.NiveauEleve + "/" + nomFichierJpg);
            else if (File.Exists(Chemin.DossierPhotoEleve + eleve.NiveauEleve + "/" + nomFichierPng))
                pbPhoto.Image = Image.FromFile(Chemin.DossierPhotoEleve + eleve.NiveauEleve + "/" + nomFichierPng);
            else
            {
                pbPhoto.Image = Image.FromFile(Chemin.CheminPhotoDefault);
                string el = eleve.NomEleve + " " + eleve.PrenomEleve;
                Globale.ListeEleveSansPhoto.Add(el);
            }

            if (pbPhoto.Image != null)
            {
                double ratio = (double)pbPhoto.Image.Width / (double)pbPhoto.Image.Height;
                pbPhoto.Height = (int)((double)pbPhoto.Width / ratio);
            }

            Edition.PosXDef = pbPhoto.Location.X;
            Edition.PosYDef = pbPhoto.Location.Y;
            Edition.PosHeightDef = pbPhoto.Height;
            Edition.PosWidthDef = pbPhoto.Width;
        }

        /// <summary>
        /// Cette fonction permet de d'afficher une photo provisoire
        /// </summary>
        /// <param name="chemin"></param>
        /// <param name="pbPhoto"></param>
        public static void AffichePhotoProvisoire(string chemin, PictureBox pbPhoto)
        {
            Bitmap bmp = new Bitmap(chemin);
            pbPhoto.Image = bmp;
            pbPhoto.Size = new Size(82, 109);
            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPhoto.Visible = true;
        }

        /// <summary>
        /// Cette fonction permet de gérer les proportions de la photo. Elle redimentionne l'emploi du temps,
        /// dessine la photo sur l'emploi du temps et enregistre l'image obtenue au format png.
        /// </summary>
        /// <param name="pbPhoto"></param>
        /// <param name="pbCarteArriere"></param>
        /// <param name="eleve"></param>
        /// <param name="path"></param>
        public static void ProportionPhotoMultiple(PictureBox pbPhoto, PictureBox pbCarteArriere, Eleve eleve,
            string path)
        {
            // -- Calcul par proportionnalité de la position et des dimensions de la photo sur le cadre de l'application par rapport a l'image réelle --
            // -- Cela permet de répercuter les déplacements effectués par l'utilisateur sur l'image originelle afin de pouvoir réutiliser celle ci --
            // -- Et ainsi ne pas perdre en qualité de l'image --
            //double rLocX = 0.0;
            //double rLocY = 0.0;
            //double rWidth = 0.0;
            //double rHeight = 0.0;

            int rLocX = (int)((double)Edition.PosXDef * (double)pbCarteArriere.Image.Width / (double)pbCarteArriere.Width);
            int rLocY = (int)((double)Edition.PosYDef * (double)pbCarteArriere.Image.Height / (double)pbCarteArriere.Height);
            int rWidth = (int)((double)Edition.PosWidthDef * (double)pbCarteArriere.Image.Width / (double)pbCarteArriere.Width);
            int rHeight = (int)((double)Edition.PosHeightDef * (double)pbCarteArriere.Image.Height / (double)pbCarteArriere.Height);

            if (eleve.SansEdt)
            {
                rLocX = (int)((double)Edition.PosXClassique * (double)pbCarteArriere.Image.Width / (double)pbCarteArriere.Width);
                rLocY = (int)((double)Edition.PosYClassique * (double)pbCarteArriere.Image.Height / (double)pbCarteArriere.Height);
                rWidth = (int)((double)pbPhoto.Width * (double)pbCarteArriere.Image.Width / (double)pbCarteArriere.Width);
                rHeight = (int)((double)pbPhoto.Height * (double)pbCarteArriere.Image.Height / (double)pbCarteArriere.Height);
            }

            var rectangle = new Rectangle(rLocX, rLocY, rWidth, rHeight);
            // -- Superposition des deux image dans un objet "Graphics" --
            Edt.RognageEdt(pbCarteArriere);
            using (var objGraphics = Graphics.FromImage(pbCarteArriere.Image))
            {
                if (Edition.RognageLargeur < 1)
                    objGraphics.DrawImage(pbPhoto.Image, rectangle);
                else
                {
                    Point pos = pbPhoto.Location;
                    pos.X = (int)((double)pos.X * (double)pbCarteArriere.Image.Width / (double)pbCarteArriere.Width);
                    pos.Y = (int)((double)pos.Y * (double)pbCarteArriere.Image.Height / (double)pbCarteArriere.Height);
                    Size taille = new Size();
                    taille.Width = (int)((double)pbPhoto.Width * (double)pbCarteArriere.Image.Width / (double)pbCarteArriere.Width);
                    taille.Height = (int)((double)pbPhoto.Height * (double)pbCarteArriere.Image.Height / (double)pbCarteArriere.Height);
                    objGraphics.DrawImage(pbPhoto.Image, new Rectangle(pos, taille));
                }
            }
            pbCarteArriere.Image.Save(path + "/" + eleve.NomEleve + eleve.PrenomEleve + "EDT.png", ImageFormat.Png);

            Thread.Sleep(1000);
        }

        /// <summary>
        /// Cette fonction permet d'obtenir la date de la dernière importation des photos
        /// </summary>
        /// <returns></returns>
        public static string GetDatePhotos()
        {
            var dateFile = "Aucune Importation";
            var dir = new DirectoryInfo(Chemin.DossierPhotoEleve);
            if (dir.Exists) dateFile = dir.CreationTime.ToString(CultureInfo.InvariantCulture);

            return dateFile;
        }
    }
}