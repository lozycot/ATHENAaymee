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
using System.Drawing;
using System.Windows.Forms;

namespace CartesAcces2024
{
    class Recherche_Image
    {
        private readonly string _directoryPath;
        // cette fonction remplace les espaces par un underscore
        static string ReplaceSpacesInFileName(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("Le nom de fichier ne peut pas être vide ou contenir uniquement des espaces.");
            }

            return fileName.Replace(' ', '_');
        }


        // permet de prendre le chemin du fichier où se situe les images 
        public Recherche_Image(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                _directoryPath = Chemin.CheminPhotoDefault;
            }
            else
            {
                _directoryPath = directoryPath;
            }
           
        }

        // cette fonction permet de chercher l'image dans tous le fichier qu'on aura séléctionner
        public Image SearchImageByName(string nom, string prenom)
        {
            try
            {
                string[] files = Directory.GetFiles(_directoryPath);
                foreach (string file in files)
                {
                    string updatedFileName = ReplaceSpacesInFileName(Path.GetFileNameWithoutExtension(file));
                    string[] nameParts = updatedFileName.Split('_');


                    if (nameParts.Length == 2 && nameParts[0].Equals(nom) && nameParts[1].Equals(prenom))
                    {
                        return new Bitmap(file);
                    }
                    else if(nameParts.Length >= 3) 
                    {
                        string[] nom1 = nom.Split(' ');
                        string[] prenom1 = prenom.Split(' ');

                        if(prenom1.Length > 1)
                        {
                            if ( nameParts[0].Equals(nom1[0], StringComparison.OrdinalIgnoreCase) && nameParts[nameParts.Length - 1].Equals(prenom1[1], StringComparison.OrdinalIgnoreCase))
                                {
                                    return new Bitmap(file);
                                }
                        }   
                        else if(prenom1.Length == 1)
                        {
                            if (nameParts[0].Equals(nom1[0], StringComparison.OrdinalIgnoreCase) && nameParts[nameParts.Length - 1].Equals(prenom, StringComparison.OrdinalIgnoreCase))
                            {
                                return new Bitmap(file);
                            }
                        }
                    }
                }

                return null; // Aucune correspondance trouvée
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public Image SearchImageByName(string nomClasse)
        {
            try
            {
                string[] files = Directory.GetFiles(_directoryPath);
                foreach (string file in files)
                {
                    string[] nameParts = Path.GetFileNameWithoutExtension(file).Split(' ');
                    string[] nameParts2 = nomClasse.Split(' ');

                    if (nameParts[0].Equals(nameParts2[0]))
                    {
                        return new Bitmap(file);
                    }
                }
                return null; // Aucune correspondance trouvée
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
