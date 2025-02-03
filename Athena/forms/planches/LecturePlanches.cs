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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace CartesAcces2024
{
    class LecturePlanches : EditionPlanche
    {

        /// <summary>
        /// Lit les noms de fichiers du dossier spécifié, essaie de faire correspondre avec une classe et de trouver le numéro de page.
        /// Appelle la fonction de découpage de l'image si une correspondance a été trouvée.
        /// </summary>
        /// <param name="chemin">Chemin du dossier</param>
        //public static void CorrespondancePlanches(string chemin, frmImportPlanches.mode mode)
        //{
        //    if(Globale.ListClasses != null)
        //        Globale.ListeClasses.Clear();
            
        //    switch(mode)
        //    {
        //        case frmImportPlanches.mode.classesNormales:
        //            Globale.ListeClasses = OperationsDb.GetClasses();
        //            break;
        //        case frmImportPlanches.mode.classesNouvelleAnnee:
        //            Globale.ListeClasses = OperationsDb.GetClassesNouvelleAnnee();
        //            break;
        //    }
        //    List<string> notFound = new List<string>();

        //    if(Globale.ListeClasses.Count == 0)
        //    {
        //        MessageBox.Show("La liste des classes est vide ! Veuillez d'abord importer des classes depuis des emplois du temps / fichier excel avant d'importer des planches photos.");
        //        return;
        //    }

        //    string[] fichiers = Directory.GetFiles(chemin);
        //    int fichiersTraites = 0;
        //    Rectangle rGrille = new Rectangle(0, 0, 0, 0);
        //    foreach(string f in fichiers)
        //    {
        //        // si une correspondance entre le nom de fichier et la classe / numéro de page a été trouvée
        //        bool correspondance = true;

        //        // enlever le chemin du dossier du nom du fichier
        //        int index = f.LastIndexOf('\\');
        //        string nom = f;
        //        if (index != -1)
        //            nom = nom.Substring(index + 1);

        //        // trouver l'endroit où se situe l'extension de fichier 
        //        int indexExtension = nom.LastIndexOf('.');
        //        string nomSansExt = nom;
        //        if(indexExtension != -1)
        //            nomSansExt = nom.Substring(0, indexExtension);

        //        // trouver l'endroit où le num de page est indiqué
        //        int indexP = nomSansExt.LastIndexOf('p');
        //        string strNumPage = nomSansExt;
        //        string nomClasseUniquement = nomSansExt;
        //        int page = 1;
        //        if (indexP == -1)
        //            correspondance = false;
        //        else
        //        {
        //            // garder uniquement le numéro et le convertir en int
        //            strNumPage = nomSansExt.Substring(indexP + 1);
        //            if (int.TryParse(strNumPage, out int result))
        //                page = result;
        //            else
        //                correspondance = false;
        //            nomClasseUniquement = nomSansExt.Substring(0, indexP);
        //            if (nomClasseUniquement.Length >= 8)
        //                nomClasseUniquement = nomClasseUniquement.Substring(0, 8); // ne prende que les 4 premiers caractères
        //        }

        //        // recherche de la classe
        //        // nomClasseReference = nom de classe qui vient de la base de données, pour comparer avec le nom du fichier
        //        // nomClasseUniquement = le nom que l'on teste provenant du nom de fichier de la planche, qu'on cherche à rattacher à une des classes existantes
        //        string nomClasseReference = "";
        //        int i = 0;
        //        bool found = false;
        //        while (!found && i < Globale.ListeClasses.Count)
        //        {
        //            nomClasseReference = Globale.ListeClasses[i];
        //            if (nomClasseReference.Length >= 8)
        //                nomClasseReference = nomClasseReference.Substring(0, 8);
        //            int indexCrochet = nomClasseReference.IndexOf('[');
        //            if (indexCrochet != -1)
        //               nomClasseReference = nomClasseReference.Substring(0, indexCrochet);
        //            found = nomClasseReference == nomClasseUniquement;
        //            i++;
        //        }
        //        // si aucune correspondance n'a été trouvée
        //        if (!found)
        //            correspondance = false;

        //        i--;
        //        if (!correspondance)
        //            notFound.Add(f);
        //        else
        //        {
        //            try
        //            {
        //                frmSelectionZone frm = new frmSelectionZone(new Bitmap(f));
        //                frm.ShowDialog();
        //                if (frmSelectionZone.annulation)
        //                    return;
        //                rGrille = frmSelectionZone.rGrille;
                        
        //                decouperPlanche(f, Globale.ListeClasses[i], page, mode, rGrille);
        //            }
        //            catch
        //            {
        //                return;
        //            }
        //            fichiersTraites++;
        //        }
        //    }

        //    string message = fichiersTraites.ToString() + " fichiers traités avec succès.";
        //    if(notFound.Count > 0)
        //    {
        //        message += "\nLes fichiers suivants n'ont pas pu être reconnus et n'ont pas été traités :";
        //        foreach(string nf in notFound)
        //        {
        //            message += "\n" + nf;
        //        }
        //        message += "\n\nVérifiez que le nom est correct et suit le format suivant, puis réessayez : \n" +
        //            "[num de la classe][nom de la classe]p[numéro de la page].jpg\n";
        //        message += "Exemple : 6ATHENESp1.jpg";
        //    }
        //    MessageBox.Show(message);
        //}

        /// <summary>
        /// Découpe les différentes photos d'une planche de photo et les enregistre avec le bon nom dans le bon dossier.
        /// </summary>
        /// <param name="cheminFichier">Chemin du fichier planche/trombinoscope</param>
        /// <param name="classe">Le nom de la classe concernée par cette planche</param>
        /// <param name="pageNum">Le numéro de page concerné par le fichier, commence à 1.</param>
        public static void decouperPlanche(string cheminFichier, string classe, int pageNum, frmImportPlanches.mode mode, Rectangle rGrille)
        {
            EditionPlanche.formatPage format = formatPage.A4;

            try
            {
                // image contenant le document entier
                using(Bitmap bmp = new Bitmap(cheminFichier))
                {

                    // calcul pour conserver les bonnes proportions quand l'image scannée n'a pas la même résolution que le document
                    // de base
                    int origW = rGrille.Width;
                    int origH = rGrille.Height;

                    if (origW < origH)
                        format = formatPage.A3;

                    double changeRatio = 0;
                    Rectangle rGrilleNormale = new Rectangle(0, 0, 0, 0);
                    rGrilleNormale.X = marginLeftRigh + marginWordDoc;
                    rGrilleNormale.Y = marginTopBottom + marginWordDoc;
                    switch(format)
                    {
                        case formatPage.A4:
                            rGrilleNormale.Width = cellW * nbCellsW;
                            rGrilleNormale.Height = (nameCellH + photoCellH) * nbCellsH;
                            break;
                        case formatPage.A3:
                            rGrilleNormale.Width = cellW * nbCellsW_A3;
                            rGrilleNormale.Height = (nameCellH + photoCellH) * nbCellsH_A3;
                            break;
                    }
                    changeRatio = (double)rGrille.Width / (double)(rGrilleNormale.Width);

                    List<Eleve> elevesClasse = null;
                    switch(mode)
                    {
                        case frmImportPlanches.mode.classesNormales:
                            elevesClasse = OperationsDb.GetEleve(classe);
                            break;
                        case frmImportPlanches.mode.classesNouvelleAnnee:
                            elevesClasse = OperationsDb.GetEleveNouvelleAnnee(classe);
                            break;
                    }
                    int debut = (pageNum - 1) * nbElevesParPlanche;
                    int fin = debut + 31;
                    if (fin > elevesClasse.Count)
                        fin = elevesClasse.Count;
                
                    // image dans laquelle sera dessinée la photo individuelle depuis de la planche
                    using(Bitmap photo = new Bitmap(cellW, photoCellH))
                    {
                        // la première cellule est sautée car elle contient les informations classe / num de page
                        int numCell = 1;
                        // rectangle de destination
                        Rectangle destRect = new Rectangle(0, 0, cellW, photoCellH);
                        for(int i = debut; i < fin; i++)
                        {
                            int posx = (int)((double)((numCell % nbCellsW) * cellW) * changeRatio) + rGrille.X;
                            int posy = (int)((double)((numCell / nbCellsW) * (photoCellH + nameCellH)) * changeRatio) + rGrille.Y;
                            Rectangle sourceRect = new Rectangle(posx + 5, posy + 5, (int)((double)(cellW - 7) * changeRatio), (int)((double)(photoCellH - 7) * changeRatio));
                            using (Graphics graph = Graphics.FromImage(photo))
                            {
                                graph.DrawImage(bmp, destRect, sourceRect, GraphicsUnit.Pixel);
                            }
                            string outputPath = "";

                            try
                            {
                                if (!Directory.Exists(Chemin.DossierPhotoEleve))
                                    Directory.CreateDirectory(Chemin.DossierPhotoEleve);

                                outputPath += Chemin.DossierPhotoEleve;
                                if (classe[0] == '6' || classe[0] == '5' || classe[0] == '4' || classe[0] == '3')
                                    outputPath += classe[0] + "eme/";
                                else
                                    outputPath += "tous/";

                                if (!Directory.Exists(outputPath))
                                    Directory.CreateDirectory(outputPath);

                                string nom = elevesClasse[i].NomEleve;
                                string prenom = elevesClasse[i].PrenomEleve;
                                if (File.Exists(outputPath + "/" + nom + " " + prenom + ".jpg"))
                                    File.Delete(outputPath + "/" + nom + " " + prenom + ".jpg");
                                photo.Save(outputPath + "/" + nom + " " + prenom + ".jpg", ImageFormat.Jpeg);
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show("Erreur dans l'enregistrement des photos : " + err.Message + "\nAnnulation.");
                                throw new Exception("Annulation");
                            }

                            numCell += 1;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur dans la lecture des fichiers planches photos : " + err.Message +
                    "\nAnnulation.");
                throw new Exception("Annulation");
            }
        }
    }
}
