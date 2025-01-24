/**
 * Ce fichier contient la classe ReadCsv qui gère la lecture des fichiers CSV.
 * Elle inclut des méthodes pour charger les données à partir d'un fichier CSV et les convertir en objets.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CartesAcces2024;

namespace CartesAcces2024
{
    public class readCsv
    {
        //private Dictionary<string, string> listeCsv = new Dictionary<string, string>();

        // on utilise un dictionnaire pour relier ["Nom"] au nom de l'élève, etc
        // on créée une liste de dictionnaires, chaque élément de la liste est un nouvel élève
        private static List<Dictionary<string, string>> dictCsv = new List<Dictionary<string, string>>();

        /// <summary>
        /// Remplit la listeCsv (attribut privé), à appeler en premier
        /// </summary>
        /// <param name="pathCsv"></param>
        public static void ExtraireDoneesCsv(string pathCsv)
        {
            // Nom de la donnée (en première ligne du tableau excel)
            var intitules = new List<string>();

            try
            {
                using (var reader = new StreamReader(pathCsv, Encoding.GetEncoding("ISO-8859-1")))
                {
                    // première ligne du tableur
                    if (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        // pour chaque cellule de la ligne du tableur
                        foreach (var v in values)
                            intitules.Add(v);
                    }

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        // Vérifier la présence de guillemets, ajouter la ligne suivante si jamais une paire de guillemets est ouverte
                        // à la fin de la ligne actuelle
                        bool quit = false;
                        int guillemets = 0;
                        int j = 0;
                        while(!quit)
                        {
                            if (line[j] == '"')
                                guillemets++;
                            if(j + 1 == line.Length)
                            {
                                // si le nombre de guillemets n'est pas pair, c'est qu'il faut ajouter la ligne suivante
                                if (guillemets % 2 != 0 && !reader.EndOfStream)
                                    line += reader.ReadLine();
                                else
                                    quit = true;
                            }
                            j++;
                        }
                        var values = line.Split(';');
                        line.Split();
                        // variable dictionnaire temporaire
                        var dic = new Dictionary<string, string>();
                        int i = 0;
                        // pour chaque cellule de la ligne du tableur
                        foreach (var v in values)
                        {
                            
                            dic.Add(intitules[i], v);
                            i++;
                        }
                        dictCsv.Add(dic);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Impossible d'ouvrir " + pathCsv + " : " + err.Message);
            }
        }

        /// <summary>
        /// Lit un fichier CSV et retourne une liste d'objets.
        /// </summary>
        /// <param name="elemListe">Le numéro de l'élève (élément de la liste)</param>
        /// <param name="donnee">Nom de la donnée (exemple "Prénom")</param>
        /// <returns></returns>
        public static string GetDataFromDictEleve(int elemListe, string donnee)
        {
            try
            {
                string result = dictCsv[elemListe][donnee];
                return result;
            }
            catch (Exception err)
            {
                MessageBox.Show("Impossible de récupérer la donnée " + donnee + " : " + err.Message +
                    "\nVérifiez qu'il existe une colonne " + donnee + " dans votre fichier.");
                dictCsv.Clear();
                throw new Exception("Annulation.");
            }
        }

        /// <summary>
        /// Remplit Globale.ListeEleve avec les données
        /// </summary>
        public static void SetLesEleves()
        {
            // On vide la liste pour éviter tout conflit avec l'ordre des pages générées dans GetImageFromPdf
            Globale.ListeEleve.Clear();
            try
            {
                var listeProvisoire = new List<Eleve>();

                // on lit toutes les lignes de listeCsv en récupérant les valeurs qui nous intéressent
                
                for (var i = 0; i < dictCsv.Count; i++)
                {
                    //var classe = RectifClasse(GetDataFromListeEleve(i, 6));
                    var unEleve = new Eleve();
                    unEleve.NumEleve = i;
                    unEleve.NomEleve = GetDataFromDictEleve(i, "Nom de famille");
                    unEleve.PrenomEleve = GetDataFromDictEleve(i, "Prénom");
                    unEleve.ClasseEleve = GetDataFromDictEleve(i, "Lib. Structure");
                    if (unEleve.ClasseEleve != "")
                        unEleve.NiveauEleve = unEleve.ClasseEleve[0].ToString();
                    //unEleve.RegimeEleve = GetDataFromListeEleve(i, 14);
                    //unEleve.OptionUnEleve = GetDataFromListeEleve(i, 7);
                    //unEleve.OptionDeuxEleve = GetDataFromListeEleve(i, 8);
                    //unEleve.OptionTroisEleve = GetDataFromListeEleve(i, 9);
                    //unEleve.OptionQuatreEleve = GetDataFromListeEleve(i, 10);
                    //unEleve.MefEleve = GetDataFromListeEleve(i, 5);
                    listeProvisoire.Add(unEleve);
                    //Globale.ListeElevesString.Add(unEleve.NomEleve + " " + unEleve.PrenomEleve + " " +
                    //                              unEleve.ClasseEleve);
                }
                Globale.ListeEleve = listeProvisoire;
                MessageBox.Show("Liste élèves importée !");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur d'importation : " + err.Message);
            }
        }

        /// <summary>
        /// Remplit Globale.ListeEleve avec les données
        /// </summary>
        public static void SetLesElevesNouvelleAnnee()
        {
            // On vide la liste pour éviter tout conflit avec l'ordre des pages générées dans GetImageFromPdf
            Globale.ListeEleve.Clear();
            try
            {
                var listeProvisoire = new List<Eleve>();

                // on lit toutes les lignes de listeCsv en récupérant les valeurs qui nous intéressent

                for (var i = 0; i < dictCsv.Count; i++)
                {
                    //var classe = RectifClasse(GetDataFromListeEleve(i, 6));
                    var unEleve = new Eleve();
                    unEleve.NumEleve = i;
                    unEleve.NomEleve = GetDataFromDictEleve(i, "Nom");
                    unEleve.PrenomEleve = GetDataFromDictEleve(i, "Prénom(s)");
                    unEleve.ClasseEleve = Globale.nom6emeSansClasse;
                    unEleve.NiveauEleve = "6";

                    string profil = GetDataFromDictEleve(i, "Formation d'accueil");
                    if (profil.Contains("SEGPA"))
                        unEleve.ProfilEleve = Eleve.profils.Segpa;
                    else if (profil.Contains("ALLOPHONES"))
                        unEleve.ProfilEleve = Eleve.profils.Allophone;
                    else if (profil.Contains("ULIS"))
                        unEleve.ProfilEleve = Eleve.profils.Ulis;
                    else if (profil.Contains("BILINGUE"))
                        unEleve.ProfilEleve = Eleve.profils.Bilingue;
                    else
                        unEleve.ProfilEleve = Eleve.profils.Defaut;

                    //unEleve.RegimeEleve = GetDataFromListeEleve(i, 14);
                    //unEleve.OptionUnEleve = GetDataFromListeEleve(i, 7);
                    //unEleve.OptionDeuxEleve = GetDataFromListeEleve(i, 8);
                    //unEleve.OptionTroisEleve = GetDataFromListeEleve(i, 9);
                    //unEleve.OptionQuatreEleve = GetDataFromListeEleve(i, 10);
                    //unEleve.MefEleve = GetDataFromListeEleve(i, 5);
                    listeProvisoire.Add(unEleve);
                    //Globale.ListeElevesString.Add(unEleve.NomEleve + " " + unEleve.PrenomEleve + " " +
                    //                              unEleve.ClasseEleve);
                }
                Globale.ListeEleve = listeProvisoire;
                MessageBox.Show("Liste élèves importée !");
            }
            catch
            {
                MessageBox.Show(new Form { TopMost = true },
                    "Pas de liste importée, afin de pouvoir créer des carte merci d'importer le fichier Excel");
            }
        }

        /// <summary>
        /// Cette fonction permet de rectifier la classe
        /// </summary>
        /// <param name="classe"></param>
        /// <returns></returns>
        public static string RectifClasse(string classe)
        {
            var index = classe.IndexOf('"');
            var classeRectif = classe.Substring(index + 1, classe.Length - 3);

            return classeRectif;
        }

        /// <summary>
        /// Cette fonction permet d'obtenir le nombre de ligne d'un fichier CSV
        /// </summary>
        /// <param name="pathCsv"></param>
        /// <returns></returns>
        public static int GetNumberOfLines(string pathCsv)
        {
            return File.ReadAllLines(pathCsv).Length - 1;
        }

        public static List<string> GetDataFromCsv(string pathCsv, int numColonne)
        {
            var list = new List<string>();

            using (var reader = new StreamReader(pathCsv, Encoding.GetEncoding("ISO-8859-1")))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    list.Add(values[numColonne]);
                }
            }

            return list;
        }
        /// <summary>
        /// Cette fonction permet de créer la liste des élèves
        /// </summary>
        /// <param name="sFilePath"></param>
        public static void SetLesElevesPourEdition(string sFilePath)
        {
            //string sFilePath = ""; // chemin vers le fichier csv
            try
            {
                var listeProvisoire = new List<Eleve>();
                var rowCount = GetNumberOfLines(sFilePath);

                for (var i = 1; i <= rowCount; i++)
                {
                    var classe = RectifClasse(GetDataFromCsv(sFilePath, 6)[i]);
                    var unEleve = new Eleve();
                    unEleve.NumEleve = i;
                    unEleve.NomEleve = GetDataFromCsv(sFilePath, 0)[i];
                    unEleve.PrenomEleve = GetDataFromCsv(sFilePath, 1)[i];
                    unEleve.ClasseEleve = classe;
                    unEleve.RegimeEleve = GetDataFromCsv(sFilePath, 14)[i];
                    unEleve.OptionUnEleve = GetDataFromCsv(sFilePath, 7)[i];
                    unEleve.OptionDeuxEleve = GetDataFromCsv(sFilePath, 8)[i];
                    unEleve.OptionTroisEleve = GetDataFromCsv(sFilePath, 9)[i];
                    unEleve.OptionQuatreEleve = GetDataFromCsv(sFilePath, 10)[i];
                    unEleve.MefEleve = GetDataFromCsv(sFilePath, 5)[i];

                    listeProvisoire.Add(unEleve);
                    Globale.ListeElevesString.Add(unEleve.NomEleve + " " + unEleve.PrenomEleve + " " +
                                                  unEleve.ClasseEleve);
                }

                Globale.ListeEleve = listeProvisoire.OrderBy(o => o.ClasseEleve).ThenBy(o => o.NomEleve).ToList();
            }
            catch
            {
                MessageBox.Show(new Form { TopMost = true },
                    "Pas de liste importée, afin de pouvoir créer des carte merci d'importer le fichier Excel");
            }
        }
        public static string GetDateFile()
        {
            try
            {
                var dateFile = "Aucune Importation";

                if (File.Exists(Chemin.CheminListeEleve))
                    dateFile = File.GetCreationTime(Chemin.CheminListeEleve).ToString();

                return dateFile;
            }
            catch (Exception err)
            {
                MessageBox.Show("aaa + " + err.Message);
            }

            return null;
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
