/**
 * Ce fichier contient la classe CopieImage qui gère la copie d'images d'un dossier à un autre.
 * Elle inclut des méthodes pour copier des fichiers d'images et gérer les progrès de l'opération.
 */

using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CartesAcces2024
{
    class CopieImage
    {
        // Méthode pour copier un dossier d'images
        public static void CopieDossier(string cheminSource, string cheminDestination, BackgroundWorker worker)
        {
            try
            {
                // Vérifie si le répertoire de destination n'existe pas, alors il le crée
                if (!Directory.Exists(cheminDestination))
                {
                    Directory.CreateDirectory(cheminDestination);
                }

                // Récupère tous les fichiers avec une extension d'image (.jpg, .png, etc.)
                string[] fichiers = Directory.GetFiles(cheminSource, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".png", StringComparison.OrdinalIgnoreCase)).ToArray();

                double numFile = 0;
                double nbFiles = fichiers.Length;

                // Copie chaque fichier vers le répertoire de destination
                foreach (string fichier in fichiers)
                {
                    string fileName = Path.GetFileName(fichier);
                    string destFile = Path.Combine(cheminDestination, fileName);
                    File.Copy(fichier, destFile, true);

                    // calcul et envoi du pourcentage d'avancement
                    double p = (numFile / nbFiles) * 100.0;
                    if (p < 0)
                        p = 0;
                    else if (p > 100)
                        p = 100;
                    worker.ReportProgress((int)p);
                    numFile++;
                }

                Globale.MessageFinFrmChargement = "Images copiées avec succès ! Voulez-vous ouvrir le dossier ?";
                Globale.OperationSuccess = true;
            }
            catch (Exception ex)
            {
                Globale.MessageFinFrmChargement = $"Une erreur est survenue : {ex.Message}";
                Globale.OperationSuccess = false;
            }
        }

        // Méthode pour copier une image
        public static void CopierImage(string cheminSource, string cheminDestination, BackgroundWorker worker)
        {
            /// <summary>
            /// Copies an image file from the source path to the destination path.
            /// </summary>
            try
            {
                Globale.MessageFinFrmChargement = "Images copiées avec succès ! Voulez-vous ouvrir le dossier ?";
                Globale.OperationSuccess = true;

                if (File.Exists(cheminSource))
                {
                    string[] imageExtensions = { ".jpg", ".jpeg", ".png" };
                    string fileExtension = Path.GetExtension(cheminSource).ToLower();
                    if (!Directory.Exists(cheminDestination))
                    {
                        Directory.CreateDirectory(cheminDestination);
                    }

                    if (Array.Exists(imageExtensions, ext => ext == fileExtension))
                    {
                        string fileName = Path.GetFileName(cheminSource);
                        string destFile = Path.Combine(cheminDestination, fileName);
                        File.Copy(cheminSource, destFile, true);
                    }
                    else
                    {
                        Globale.MessageFinFrmChargement = "Le fichier spécifié n'est pas une image.";
                        Globale.OperationSuccess = false;
                    }
                }
                else
                {
                    Globale.MessageFinFrmChargement = "Le fichier source n'existe pas.";
                    Globale.OperationSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Globale.MessageFinFrmChargement = $"Une erreur est survenue : {ex.Message}";
                Globale.OperationSuccess = false;
            }
        }

        // Méthode pour copier une image avec un nom personnalisé
        public static void CopierImage(string cheminSource, string cheminDestination, BackgroundWorker worker, string nom, string prenom)
        {
            /// <summary>
            /// Copies an image file from the source path to the destination path.
            /// </summary>
            try
            {
                Globale.MessageFinFrmChargement = "Images copiées avec succès ! Voulez-vous ouvrir le dossier ?";
                Globale.OperationSuccess = true;

                if (File.Exists(cheminSource))
                {
                    string[] imageExtensions = { ".jpg", ".jpeg", ".png" };
                    string fileExtension = Path.GetExtension(cheminSource).ToLower();
                    if (!Directory.Exists(cheminDestination))
                    {
                        Directory.CreateDirectory(cheminDestination);
                    }

                    if (Array.Exists(imageExtensions, ext => ext == fileExtension))
                    {
                        string fileName = nom + " " + prenom + ".jpg";
                        string destFile = Path.Combine(cheminDestination, fileName);
                        File.Copy(cheminSource, destFile, true);
                    }
                    else
                    {
                        Globale.MessageFinFrmChargement = "Le fichier spécifié n'est pas une image.";
                        Globale.OperationSuccess = false;
                    }
                }
                else
                {
                    Globale.MessageFinFrmChargement = "Le fichier source n'existe pas.";
                    Globale.OperationSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Globale.MessageFinFrmChargement = $"Une erreur est survenue : {ex.Message}";
                Globale.OperationSuccess = false;
            }
        }

        // Méthode pour copier des images d'un dossier
        public static void CopierImagesDossier(string cheminSource, string cheminDestination, BackgroundWorker worker)
        {
            string numClasse = Globale.Classe.ToString();
            try
            {
                if (!Directory.Exists(cheminDestination))
                {
                    Directory.CreateDirectory(cheminDestination);
                }

                // Récupère tous les sous-dossiers correspondant à la classe
                string[] dossiers = Directory.GetDirectories(cheminSource, "*.*", SearchOption.TopDirectoryOnly).Where(chemin => Path.GetFileName(chemin).StartsWith(numClasse)).ToArray();
                bool anyCopied = false;

                double numDoss = 0;
                double nbDoss = dossiers.Length; 
                foreach (string dossier in dossiers)
                {
                    // Récupère tous les fichiers d'images dans le dossier
                    string[] fichiers = Directory.GetFiles(dossier, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".png", StringComparison.OrdinalIgnoreCase)).ToArray();

                    foreach (string fichier in fichiers)
                    {
                        string fileName = Path.GetFileName(fichier);
                        string destFile = Path.Combine(cheminDestination, fileName);
                        File.Copy(fichier, destFile, true);
                    }
                    // calcul et envoi du pourcentage d'avancement
                    double p = (numDoss / nbDoss) * 100.0;
                    if (p < 0)
                        p = 0;
                    else if (p > 100)
                        p = 100;
                    worker.ReportProgress((int)p);
                    anyCopied = true;
                    numDoss++;
                }

                if (anyCopied)
                {
                    Globale.MessageFinFrmChargement = "Images copiées avec succès ! Voulez-vous ouvrir le dossier ?";
                    Globale.OperationSuccess = true;
                }
                else
                {
                    Globale.MessageFinFrmChargement = "Aucune image trouvée à copier.";
                    Globale.OperationSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Globale.MessageFinFrmChargement = $"Une erreur est survenue : {ex.Message}";
                Globale.OperationSuccess = false;
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

