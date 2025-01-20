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
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;


/**
 * Dimensions document (sans compter les marges du document word) :
 * Document entier A4 : 297 * 210 mm (A4)                  1754 * 1240 px
 * Document A3        : 420 * 297 mm                       2480 * 1754 px
 * Marges gauche / droite : 8,5 mm                      50 px
 * Marges haut / bas : 5 mm                             29 px
 * taille case photo + libellé élève : 35 * 50 mm       206 * 295 px
 * taille case photo : 35 * 45 mm                       206 * 265 px
 * taille libellé élève : 35 * 5 mm                     206 * 29 px
 */

namespace CartesAcces2024
{
    public class EditionPlanche
    {
        /// <summary>
        /// Permet de choisir de generer une planche sans photos ou bien une planche trombinoscopes avec photos.
        /// </summary>
        public enum typePlanche
        {
            plancheVide,
            trombinoscope
        };

        /// <summary>
        /// Permet de choisir le format de la page.
        /// </summary>
        public enum formatPage
        {
            A4,
            A3
        }

        // CONSTANTES 
        public const int marginWordDoc = 29;    // marge du document word

        // Dimensions moins les marges du document word
        public const int pageWidth = 1695;
        public const int pageHeight = 1181;
        public const int pageWidthA3 = 1696;
        public const int pageHeightA3 = 2422;

        public const int marginLeftRigh = 21;
        public const int marginTopBottom = 0;
        public const int cellW = 206; // largeur d'une cellule
        public const int photoCellH = 265; // hauteur d'une celle de photo
        // constante utilisée pour dimensionner les images qui n'ont pas le même ratio
        public const double photoCellRatio = (double)photoCellH / (double)cellW;
        public const int nameCellH = 29; // hauteur de la case qui contient le nom de l'élève

        public const int nbCellsW = 8; // nb de cellules en largeur pour les pages A4
        public const int nbCellsW_A3 = 8; // pour les pages A3
        public const int nbCellsH = 4; // nb de cellules (Photo + nom) en hauteur format A4
        public const int nbCellsH_A3 = 8; // A3
        public const int nbElevesParPlanche = 31; // moins la première case qui est utilisée pour le titre
        public const int nbElevesParPlancheA3 = 63; // idem
        static public Rectangle rectPage = new Rectangle(0, 0, pageWidth, pageHeight);
        static public Rectangle rectPageA3 = new Rectangle(0, 0, pageWidthA3, pageHeightA3);

        public static Color magenta = Color.FromArgb(255, 255, 0, 179);
        public static Color bleuciel = Color.FromArgb(255, 139, 208, 255);
        public static Color vertclair = Color.FromArgb(255, 41, 255, 128);
        public static Color jaune = Color.FromArgb(255, 255, 255, 0);
        public static Color gris = Color.FromArgb(255, 85, 85, 85);

        public static Brush pinceauMagenta = new SolidBrush(magenta);
        public static Brush pinceauBleuCiel = new SolidBrush(bleuciel);
        public static Brush pinceauVertClair = new SolidBrush(vertclair);
        public static Brush pinceauJaune = new SolidBrush(jaune);
        public static Brush pinceauGris = new SolidBrush(gris);

        // utilisé pour les dessins
        public static Brush pinceauNoir = new SolidBrush(Color.Black);
        public static Brush pinceauBlanc = new SolidBrush(Color.White);

        // utilisé pour le texte
        // par défaut (utilisé pour les noms), on utilise une police à chasse fixe (tous les caractères font la même taille
        // pour faciliter le calcul de la longueur maximale de la chaîne de caractères)
        public static Font defFont = new Font(FontFamily.GenericMonospace, 11);
        public static Font italFont = new Font(FontFamily.GenericMonospace, 11, FontStyle.Italic);
        public static Font underFont = new Font(FontFamily.GenericMonospace, 11, FontStyle.Underline);
        public static Font titreFont = new Font(FontFamily.GenericSansSerif, 20);

        /// <summary>
        /// Créer une image vide.
        /// </summary>
        /// <param name="format"></param>
        public static void CreerPlanche(formatPage format)
        {
            int w = pageWidth;
            int h = pageHeight;
            Rectangle r = rectPage;
            string filename = Chemin.CheminTrombiTemplate;

            if (format == formatPage.A3)
            {
                w = pageWidthA3;
                h = pageHeightA3;
                r = rectPageA3;
                filename = Chemin.CheminTrombiTemplateA3;
            }

            using (Bitmap bmp = new Bitmap(w, h))
            {
                using (Graphics objetGraphique = Graphics.FromImage(bmp))
                {
                    objetGraphique.FillRectangle(pinceauBlanc, r);
                    objetGraphique.DrawRectangle(new Pen(pinceauBlanc), r);
                }

                try
                {
                    if (File.Exists(filename))
                        File.Delete(filename);
                    bmp.Save(filename, ImageFormat.Png);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        /// <summary>
        /// Peint la page en blanc
        /// </summary>
        /// <param name="img"></param>
        public static void ResetPlanche(Image img, formatPage format)
        {
            Rectangle r = rectPage;

            if (format == formatPage.A3)
            {
                r = rectPageA3;
            }
            using (Graphics objetGraphique = Graphics.FromImage(img))
            {
                objetGraphique.FillRectangle(pinceauBlanc, r);
                objetGraphique.DrawRectangle(new Pen(pinceauBlanc), r);
            }
        }

        /// <summary>
        /// Dessine une grille pour une planche vide
        /// </summary>
        /// <param name="img"></param>
        /// <param name="format">Taille de la page A4 / A3</param>
        public static void DessinerGrille(Image img, formatPage format)
        {
            //Rectangle rectPhoto = new Rectangle(0, 0, 100, 160);
            using (Graphics objetGraphique = Graphics.FromImage(img))
            {
                //objetGraphique.FillRectangle(pinceauNoir, rectPhoto);
                //objetGraphique.DrawRectangle(new Pen(pinceauNoir), rectPhoto);
                int nbW = nbCellsW;
                int nbH = nbCellsH;

                if (format == formatPage.A3)
                {
                    nbW = nbCellsW_A3;
                    nbH = nbCellsH_A3;
                }

                Pen cr = new Pen(pinceauNoir, 2);
                //Marge gauche
                int positionW = marginLeftRigh;
                objetGraphique.DrawLine(cr, positionW, marginTopBottom, positionW, (photoCellH + nameCellH) * nbH + marginTopBottom);
                //Lignes verticales
                for(int i = 0; i < nbW; i++)
                {
                    positionW += cellW;
                    objetGraphique.DrawLine(cr, positionW, marginTopBottom, positionW, (photoCellH + nameCellH) * nbH + marginTopBottom);
                }

                //Marge haut
                int positionH = marginTopBottom;
                objetGraphique.DrawLine(cr, marginLeftRigh, positionH, cellW * nbW + marginLeftRigh, positionH);
                //lignes horizontales
                for (int i = 0; i < nbH; i++)
                {
                    positionH += photoCellH;
                    objetGraphique.DrawLine(cr, marginLeftRigh, positionH, cellW * nbW + marginLeftRigh, positionH);
                    positionH += nameCellH;
                    objetGraphique.DrawLine(cr, marginLeftRigh, positionH, cellW * nbW + marginLeftRigh, positionH);
                }
                cr.Dispose();
            }
        }

        /// <summary>
        /// Écrit les noms + prénoms des élèves dans chaque case de la planche d'une classe,
        /// ainsi que le nom de la classe. On peut choisir qu'une partie de la liste dans le cas
        /// où la classe contient + de 31 élèves (ou 61 pour les pages A3) (il faudra alors faire plusieurs planches).
        /// </summary>
        /// <param name="elevesClasse">La liste d'élèves</param>
        /// <param name="debutListe"></param>
        /// <param name="finListe"></param>
        /// <param name="pageActuelle">Le numéro de page qui sera affiché</param>
        /// <param name="nbPagesTotal">Le nombre de pages total qui sera affiché</param>
        /// <param name="format">Taille de la page</param>
        /// <returns></returns>
        public static Image EcrireNomsEleves
            (List<Eleve> elevesClasse, int debutListe, int finListe, int pageActuelle, int nbPagesTotal, formatPage format, bool afficherProfils)
        {
            int nbW = nbCellsW;
            int nbEl = nbElevesParPlanche;
            string filename = Chemin.CheminTrombiTemplate;

            if (format == formatPage.A3)
            {
                nbW = nbCellsW_A3;
                nbEl = nbElevesParPlancheA3;
                filename = Chemin.CheminTrombiTemplateA3;
            }

            if (finListe - debutListe > nbEl)
            {
                MessageBox.Show("Trop d'élèves dans la classe " + elevesClasse[0].ClasseEleve + " !");
                return null;
            }
            try
            {
                Bitmap bmp = new Bitmap(filename);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    // titre et numéro de pages
                    graph.DrawString("Classe :\n" + elevesClasse[0].ClasseEleve, titreFont, pinceauNoir, 
                        marginLeftRigh + 5, marginTopBottom + 5);
                    graph.DrawString("Page " + pageActuelle + " / " + nbPagesTotal, titreFont, pinceauNoir,
                        marginLeftRigh + 5, marginTopBottom + 80);

                    if(afficherProfils)
                    {
                        int x = marginLeftRigh + 5;
                        int y = marginTopBottom + 150;
                        graph.DrawString("Légende :", defFont, pinceauNoir, x, y);
                        y += 22;
                        graph.DrawString(" - SEGPA", italFont, pinceauMagenta, x, y);
                        y += 22;
                        graph.FillRectangle(pinceauGris, x, y, cellW - 15, nameCellH);
                        graph.DrawString(" - ULIS", underFont, pinceauBleuCiel, x, y);
                        y += 22;
                        graph.FillRectangle(pinceauNoir, x, y, cellW - 15, nameCellH);
                        graph.DrawString(" - Bilingue", defFont, pinceauVertClair, x, y);
                        y += 22;
                        graph.FillRectangle(pinceauNoir, x, y, cellW - 15, nameCellH);
                        graph.DrawString(" - Allophone", italFont, pinceauJaune, x, y);
                    }

                    int numCell = 1;
                    for(int i = debutListe; i < finListe; i++)
                    {
                        // calcul de la position du texte à écrire
                        int posX = (numCell % nbW) * cellW + marginLeftRigh;
                        int posY = (numCell / nbW) * (photoCellH + nameCellH) + marginTopBottom + photoCellH;
                        string nom = elevesClasse[i].NomEleve;
                        string prenom = elevesClasse[i].PrenomEleve;
                        Eleve.profils profil = elevesClasse[i].ProfilEleve;

                        //recoupage pour éviter de(trop) dépasser des cases
                        if (nom.Length > 9)
                            nom = nom.Substring(0, 8) + ".";
                        if (nom.Length + prenom.Length > 15)
                            prenom = prenom.Substring(0, 15 - nom.Length) + ".";

                        Font police = defFont;
                        Brush pinceauTxt = pinceauNoir;

                        if(afficherProfils)
                        {
                            switch(profil)
                            {
                                case Eleve.profils.Segpa:
                                    police = italFont;
                                    pinceauTxt = pinceauMagenta;
                                    break;
                                case Eleve.profils.Ulis:
                                    police = underFont;
                                    pinceauTxt = pinceauBleuCiel;
                                    graph.FillRectangle(pinceauGris, posX, posY, cellW, nameCellH);
                                    break;
                                case Eleve.profils.Bilingue:
                                    pinceauTxt = pinceauVertClair;
                                    graph.FillRectangle(pinceauNoir, posX, posY, cellW, nameCellH);
                                    break;
                                case Eleve.profils.Allophone:
                                    police = italFont;
                                    pinceauTxt = pinceauJaune;
                                    graph.FillRectangle(pinceauNoir, posX, posY, cellW, nameCellH);
                                    break;
                            }
                        }

                        graph.DrawString(nom + " " + prenom, police, pinceauTxt, posX, posY);
                        graph.DrawString(nom + " " + prenom, police, pinceauTxt, posX, posY);
                        numCell++;
                        //return bmp;
                    }
                }
                return bmp;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return null;
            }
        }

        /// <summary>
        /// Dessine les photos des élèves sur le trombinoscope.
        /// Nécessite d'avoir au préalable importé les photos élèves.
        /// </summary>
        /// <param name="elevesClasse"></param>
        /// <param name="debutListe"></param>
        /// <param name="finListe"></param>
        /// <param name="plancheVide">Image de la planche vide sans photos (avec noms d'élèves).</param>
        /// <returns></returns>
        public static Image DessinerPhotosEleves
            (List<Eleve> elevesClasse, int debutListe, int finListe, Image plancheVide, formatPage format)
        {
            int nbW = nbCellsW;
            int nbEl = nbElevesParPlanche;

            if (format == formatPage.A3)
            {
                nbW = nbCellsW_A3;
                nbEl = nbElevesParPlancheA3;
            }

            if (finListe - debutListe > nbEl)
            {
                MessageBox.Show("Trop d'élèves dans la classe " + elevesClasse[0].ClasseEleve + " !");
                return null;
            }
            try
            {
                using (Graphics graph = Graphics.FromImage(plancheVide))
                {
                    int numCell = 1;
                    Recherche_Image search = new Recherche_Image(Chemin.DossierPhotoEleve + elevesClasse[0].NiveauEleve);
                    for (int i = debutListe; i < finListe; i++)
                    {
                        // calcul de la position du texte à écrire
                        int posx = (numCell % nbW) * cellW + marginLeftRigh;
                        int posy = (numCell / nbW) * (photoCellH + nameCellH) + marginTopBottom;
                        string nom = elevesClasse[i].NomEleve;
                        string prenom = elevesClasse[i].PrenomEleve;

                        using (Image photo = search.SearchImageByName(elevesClasse[i].NomEleve, elevesClasse[i].PrenomEleve))
                        {
                            if(photo != null)
                            {
                                // Correction du ratio de l'image et positionnement au milieu de la case
                                Rectangle rectPhoto = new Rectangle(posx, posy, cellW, photoCellH);
                                double photoRatio = (double)photo.Height / (double)photo.Width;
                                // Si la photo est moins large que le format de la cellule
                                if (photoRatio >= photoCellRatio)
                                {
                                    rectPhoto.Width = (int)((double) rectPhoto.Height / photoRatio);
                                    rectPhoto.X += (cellW - rectPhoto.Width) / 2;
                                }
                                else // si la photo est plus large que le format de la cellule
                                {
                                    rectPhoto.Height = (int)((double)rectPhoto.Width * photoRatio);
                                    rectPhoto.Y += (photoCellH - rectPhoto.Height) / 2;
                                }
                                graph.DrawImage(photo, rectPhoto);
                            }
                        }

                        numCell++;
                        //return bmp;
                    }
                }
                return plancheVide;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return null;
            }
        }

        /// <summary>
        /// Créée le dossier si non existant, vide le dossier si existant.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool CreateOrResetDir(string path)
        {
            try
            {
                // crée le dossier si non existant
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                else // vide le dossier si existant
                {
                    Directory.Delete(path, true);
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Génère les planches pour une liste de classes.
        /// Retourne la liste des noms de fichiers générés.
        /// </summary>
        /// <param name="classes"></param>
        public static List<string> GenererPlanches(List<string> classes, typePlanche type, formatPage format, bool afficherProfils)
        {
            int nbEl = nbElevesParPlanche;

            if (format == formatPage.A3)
            {
                nbEl = nbElevesParPlancheA3;
            }
            List<string> nomsFichiers = new List<string>();

            if (false == CreateOrResetDir(Globale.DossierPlanches))
                return null;

            foreach (var cl in classes)
            {
                List<Eleve> elevesClasse = null;
                switch(frmPlanches.modeActuel)
                {
                    case frmPlanches.mode.classesNormales:
                        elevesClasse = OperationsDb.GetEleve(cl);
                        break;
                    case frmPlanches.mode.classesNouvelleAnnee:
                        elevesClasse = OperationsDb.GetEleveNouvelleAnnee(cl);
                        break;
                }

                if(elevesClasse.Count == 0)
                {
                    throw new Exception("La classe " + cl + " ne contient aucun élève ! Avez-vous effectué l'importation ?\nAnnulation.");
                }
                // variables pour calculer le nombre de pages à effectuer et quels élèves mettre sur quelle page.
                int debut = 0;
                int fin = elevesClasse.Count;
                bool quit = false;
                int nbPages = (int)((double)fin / (double)nbEl + 1.0);
                int pageActuelle = 1;
                while(!quit)
                {
                    if (fin - debut > nbEl)
                        fin = debut + nbEl;
                    else
                        quit = true;
                    using (Image img = EcrireNomsEleves(elevesClasse, debut, fin, pageActuelle, nbPages, format, afficherProfils))
                    {
                        if (img != null)
                        {
                            if (type == typePlanche.trombinoscope)
                                DessinerPhotosEleves(elevesClasse, debut, fin, img, format) ;
                            try
                            {
                                // enregistrement de l'image dans un fichier et ajout du nom de fichier dans la liste qu'on va retourner.
                                string filename = cl + "p" + pageActuelle;
                                img.Save(Globale.DossierPlanches + filename + ".jpg", ImageFormat.Jpeg);
                                nomsFichiers.Add(filename);
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                                return null;
                            }
                        }
                    }
                    // on sélectionne les élèves restants si il y en a
                    debut = fin;
                    fin = elevesClasse.Count;
                    pageActuelle++;
                }
            }
            return nomsFichiers;
        }

    }
}
