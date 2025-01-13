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
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;

namespace CartesAcces2024
{
    public class OperationsDb
    {
        public const string profilDefaut = "Defaut";
        public const string profilAllophone = "Allophone";
        public const string profilBilingue = "Bilingue";
        public const string profilSegpa = "Segpa";
        public const string profilUlis = "Ulis";

        private static void InsertUpdateDeleteUnElement(string txt)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                using (SQLiteCommand commande = new SQLiteCommand(txt, connection))
                {
                    try
                    {
                        connection.Open();
                        commande.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Une erreur s'est produite lors de l'opération dans la base de données " +
                            "Carte Accès : " + err.Message);
                        return;
                    }
                    connection.Close();
                }
            }
        }

        public static void InsertUnEleveDansBdd(Eleve el)
        {
            string[] Eleve = el.ClasseEleve.Split(' ');
            string txt = "INSERT INTO Eleve (Nom, Prenom, Classe, Niveau) VALUES (\"" + el.NomEleve + "\", \"" + el.PrenomEleve +
                "\", \"" + Eleve[0] + "\", \"" + el.NiveauEleve + "eme\");";
            InsertUpdateDeleteUnElement(txt);
        }

        public static void DeleteUnEleve(Eleve el)
        {
            string[] Eleve = el.ClasseEleve.Split(' ');
            string txt = "DELETE FROM Eleve WHERE Nom = \"" + el.NomEleve + "\" AND Prenom = \"" + el.PrenomEleve +
                "\" AND Classe = \"" + Eleve[0] + "\";";
            InsertUpdateDeleteUnElement(txt);
        }

        public static void DeleteUnEleveNouvelleAnneeDansBdd(Eleve el)
        {
            string[] Eleve = el.ClasseEleve.Split(' ');
            string txt = "DELETE FROM EleveNouvelleAnnee WHERE Nom = \"" + el.NomEleve + "\" AND Prenom = \"" + el.PrenomEleve +
                "\" AND Classe = \"" + Eleve[0] + "\";";
            InsertUpdateDeleteUnElement(txt);
        }

        public static void DeleteUneClasseNouvelleAnneeDansBdd(string classe)
        {
            string[] ClasseList = classe.Split(' ');
            string txt = "DELETE FROM ClasseNouvelleAnnee WHERE Classe = \"" + ClasseList[0] + "\";";
            InsertUpdateDeleteUnElement(txt);
        }

        public static void InsertUnEleveNouvelleAnneeDansBdd(Eleve el)
        {
            string profil = "";
            switch (el.ProfilEleve)
            {
                case Eleve.profils.Allophone:
                    profil = "Allophone";
                    break;
                case Eleve.profils.Bilingue:
                    profil = "Bilingue";
                    break;
                case Eleve.profils.Segpa:
                    profil = "Segpa";
                    break;
                case Eleve.profils.Ulis:
                    profil = "Ulis";
                    break;
                default:
                    profil = "Defaut";
                    break;
            }
            string[] EleveList = el.ClasseEleve.Split(' ');
            string txt = "INSERT INTO EleveNouvelleAnnee (Nom, Prenom, Classe, Niveau, Profil) VALUES (\"" + el.NomEleve + "\", \"" + el.PrenomEleve +
                "\", \"" + EleveList[0] + "\", \"" + el.NiveauEleve + "eme\", \"" + profil + "\");";
            InsertUpdateDeleteUnElement(txt);
        }

        /// <summary>
        /// Met à jour la classe d'un élève de la nouvelle année
        /// </summary>
        /// <param name="el"></param>
        public static void UpdateClasseUnEleveNouvelleAnneeDansBdd(Eleve el, string nouvelleClasse)
        {
            string[] Eleve = el.ClasseEleve.Split(' ');
            string txt = "UPDATE EleveNouvelleAnnee SET Classe = \"" + nouvelleClasse + "\" WHERE Classe = \"" + Eleve[0] +
                "\" AND Nom = \"" + el.NomEleve + "\" AND Prenom = \"" + el.PrenomEleve + "\";";
            InsertUpdateDeleteUnElement(txt);
        }

        public static void InsertUneClasseNouvelleAnneeDansBdd(string classe)
        {
            string[] ClasseList = classe.Split(' ');
            string txt = "INSERT INTO ClasseNouvelleAnnee (Classe) VALUES (\"" + ClasseList[0] + "\");";
            InsertUpdateDeleteUnElement(txt);
        }

        public static void InsertElevesDansBdd(BackgroundWorker worker)
        {
            int i = 0;
            int l = Globale.ListeEleve.Count;
            foreach (Eleve el in Globale.ListeEleve)
            {
                // Si l'élève n'existe pas dans la bdd
                if (!ConnectDb.DbConnect.DbData("Eleve WHERE Eleve.Nom = \"" + el.NomEleve + "\" AND " +
                    "Eleve.Prenom = \"" + el.PrenomEleve + "\" AND Eleve.Classe = \"" + el.ClasseEleve + "\";"))
                {
                    InsertUnEleveDansBdd(el);
                }

                double p = (double)i / (double)l * 100.0;
                worker.ReportProgress((int)p);
                i++;
            }
            //chg.Close();
            //MessageBox.Show("Données enregistrées");
        }

        public static void InsertElevesNouvelleAnneeDansBdd(BackgroundWorker worker)
        {
            int i = 0;
            int l = Globale.ListeEleve.Count;
            foreach (Eleve el in Globale.ListeEleve)
            {
                string[] Elevelist = el.ClasseEleve.Split(' ');
                // Si l'élève n'existe pas dans la bdd
                if (!ConnectDb.DbConnect.DbData("EleveNouvelleAnnee WHERE EleveNouvelleAnnee.Nom = \"" + el.NomEleve + "\" AND " +
                    "EleveNouvelleAnnee.Prenom = \"" + el.PrenomEleve + "\" AND EleveNouvelleAnnee.Classe = \"" + Elevelist[0] + "\";"))
                {
                    InsertUnEleveNouvelleAnneeDansBdd(el);
                }

                double p = (double)i / (double)l * 100.0;
                worker.ReportProgress((int)p);
                i++;
            }
            //chg.Close();
            //MessageBox.Show("Données enregistrées");
        }

        public static void ImportCsv()
        {
            I_ImportService fileDialog = new ImportCsv();
            string path = fileDialog.setCheminImportation();
            Globale.CheminCsv = path;
            if (path != "failed")
            {
                readCsv.ExtraireDoneesCsv(path);
                readCsv.SetLesEleves();
                //InsertElevesDansBdd();
                Globale.Cas = Globale.CodeCas.insertElevesBdd;
                frmChargement chg = new frmChargement();
                chg.updateLabel("Enregistrement des élèves, veuillez patienter...");
                chg.ShowDialog();
                if (Globale.MessageFinFrmChargement != "")
                    MessageBox.Show(Globale.MessageFinFrmChargement);
                else
                    MessageBox.Show("Opération terminée !");
            }
        }

        public static List<Color> GetColors()
        {
            //Initalisation des variables de couleur
            Color couleur6 = Color.White;
            Color couleur5 = Color.White;
            Color couleur4 = Color.White;
            Color couleur3 = Color.White;
            //Initialisation des commandes SQL
            string codeHex6 = "SELECT codeHexa6eme FROM Etablissement";
            string codeHex5 = "SELECT codeHexa5eme FROM Etablissement";
            string codeHex4 = "SELECT codeHexa4eme FROM Etablissement";
            string codeHex3 = "SELECT codeHexa3eme FROM Etablissement";
            //Initialisation des listes pour le for
            List<string> variables = new List<string> { };
            List<string> commands = new List<string> { codeHex6, codeHex5, codeHex4, codeHex3 };
            List<Color> couleurs = new List<Color> { couleur6, couleur5, couleur4, couleur3 };

            //ouverture de la BDD
            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                for (int i = 0; i < 4; i++)
                {
                    //attribution des valeurs de chaque niveau a la bonne variable
                    using (SQLiteCommand command = new SQLiteCommand(commands[i], connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                variables.Add(reader.GetString(0));
                                if (variables[i] == "#FFFF00")
                                {
                                    couleurs[i] = Color.Yellow;
                                }
                                else if (variables[i] == "#90EE90")
                                {
                                    couleurs[i] = Color.Green;
                                }
                                else if (variables[i] == "#FF0000")
                                {
                                    couleurs[i] = Color.Red;
                                }
                                else
                                {
                                    couleurs[i] = Color.Blue;
                                }
                            }
                        }
                    }
                }
            }
            return couleurs;
        }


        public static List<string> GetEtablissement()
        {
            string etabName = "SELECT nomEtablissement FROM Etablissement";
            string rueName = "SELECT nomRueEtablissement FROM Etablissement";
            string numRue = "SELECT numeroRueEtablissement FROM Etablissement";
            string codePost = "SELECT codePostalEtablissement FROM Etablissement";
            string ville = "SELECT villeEtablissement FROM Etablissement";
            string numTel = "SELECT numeroTelephoneEtablissement FROM Etablissement";
            string email = "SELECT emailEtablissement FROM Etablissement";
            string url = "SELECT urlEtablissement FROM Etablissement";
            string bordure = "SELECT bordure FROM Etablissement";
            string NomEtablissement = "";
            string NomRueEtablissement = "";
            string NumeroRueEtablissement = "";
            string CodePostalEtablissement = "";
            string VilleEtablissement = "";
            string NumeroTelephoneEtablissement = "";
            string EmailEtablissement = "";
            string urlEtablissement = "";
            string bordureEtablissement = "";
            List<string> commands = new List<string> { etabName, rueName, numRue, codePost, ville, numTel, email, url, bordure};
            List<string> results = new List<string> { NomEtablissement, NomRueEtablissement, NumeroRueEtablissement, CodePostalEtablissement, VilleEtablissement, NumeroTelephoneEtablissement, EmailEtablissement, urlEtablissement, bordureEtablissement };
                                                     //      0                  1                   2                          3                       4                       5                         6                  7                   8
            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                for (int i = 0; i < 8; i++)
                {
                    using (SQLiteCommand command = new SQLiteCommand(commands[i], connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                results[i] = reader.GetString(0);
                            }
                        }
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Fonction commune pour toutes les fonctions de lecture élève.
        /// </summary>
        /// <param name="commande"></param>
        /// <param name="lireProfil">Permet de savoir si on veut lire le profil de l'élève ou pas.</param>
        /// <returns></returns>
        private static List<Eleve> GetEleveCommun(string commande, bool lireProfil)
        {
            List<Eleve> results = new List<Eleve> { };

            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                {
                    using (SQLiteCommand command = new SQLiteCommand(commande, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Eleve el = new Eleve();
                                el.ClasseEleve = reader.GetString(0);
                                el.NomEleve = reader.GetString(1);
                                el.PrenomEleve = reader.GetString(2);
                                el.NiveauEleve = reader.GetString(3);

                                if(lireProfil)
                                {
                                    switch(reader.GetString(4))
                                    {
                                        case profilAllophone:
                                            el.ProfilEleve = Eleve.profils.Allophone;
                                            break;
                                        case profilBilingue:
                                            el.ProfilEleve = Eleve.profils.Bilingue;
                                            break;
                                        case profilSegpa:
                                            el.ProfilEleve = Eleve.profils.Segpa;
                                            break;
                                        case profilUlis:
                                            el.ProfilEleve = Eleve.profils.Ulis;
                                            break;
                                        default:
                                            el.ProfilEleve = Eleve.profils.Defaut;
                                            break;
                                    }
                                }

                                results.Add(el);
                            }
                        }
                    }
                }
            }

            // Ranger par ordre alphabétique
            results.Sort(delegate (Eleve x, Eleve y)
            {
                int comparaison = String.Compare(x.NomEleve, y.NomEleve, false);
                if (comparaison != 0)
                    return comparaison;
                else
                    return String.Compare(x.PrenomEleve, y.PrenomEleve, false);
            });
            return results;
        }

        /// <summary>
        /// Récupère un élève de la base de donnée. Renvoie si l'élève n'existe pas.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <returns></returns>
        public static Eleve GetUnEleve(string nom, string prenom)
        {
            string sql = "SELECT Classe, Nom, Prenom, Niveau FROM Eleve WHERE Nom = \"" + nom + "\" AND Prenom = \"" + prenom + "\";";
            List<Eleve> listeElve = GetEleveCommun(sql, false);
            if (listeElve.Count == 0)
            {
                return null;
            }
            else
            {
                return GetEleveCommun(sql, false)[0];
            }
        }


        public static List<Eleve> GetEleve()
        {
            string sql = "SELECT Classe, Nom, Prenom, Niveau FROM Eleve";
            return GetEleveCommun(sql, false);
        }

        public static List<Eleve> GetEleve(string niveau)
        {
            string sql = "SELECT Classe, Nom, Prenom, Niveau FROM Eleve WHERE Classe LIKE '%" + niveau + "%'";
            return GetEleveCommun(sql, false);
        }

        public static List<Eleve> GetEleveNouvelleAnnee()
        {
            string sql = "SELECT Classe, Nom, Prenom, Niveau, Profil FROM EleveNouvelleAnnee";
            return GetEleveCommun(sql, true);
        }

        public static List<Eleve> GetEleveNouvelleAnnee(string niveau)
        {
            string sql = "SELECT Classe, Nom, Prenom, Niveau, Profil FROM EleveNouvelleAnnee WHERE Classe LIKE '%" + niveau + "%'";
            return GetEleveCommun(sql, true);
        }

        public static List<Eleve> GetEleveNouvelleAnnee(Classe classe)
        {
            string sql = "SELECT Classe, Nom, Prenom, Niveau, Profil FROM EleveNouvelleAnnee WHERE Classe = '" + classe.Classes + "'";
            return GetEleveCommun(sql, true);
        }

        public static List<string> GetClasses()
        {
            string sql = "SELECT Classe FROM Eleve";
            List<string> results = new List<string> { };
            HashSet<string> seenClasses = new HashSet<string>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                {
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                
                                string classe = reader.GetString(0);
                                if (!seenClasses.Contains(classe))
                                {
                                    if (classe != null)
                                    {
                                        results.Add(classe);
                                        seenClasses.Add(classe);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return results;
        }

        public static List<string> GetClassesNouvelleAnnee()
        {
            string sql = "SELECT Classe FROM ClasseNouvelleAnnee";
            List<string> results = new List<string> { };
            HashSet<string> seenClasses = new HashSet<string>();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                {
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string classe = reader.GetString(0);
                                if (!seenClasses.Contains(classe))
                                {
                                    if (classe != null)
                                    {
                                        results.Add(classe);
                                        seenClasses.Add(classe);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return results;
        }

        public static void ImportDates(string import, string date)
        {
            string sql = "";
            if (import == "DateEDT")
            {
                sql = "UPDATE DatesImport SET ImportEdt = '" + date + "';";
            }
            else if (import == "DateEleve")
            {
                sql = "UPDATE DatesImport SET ImportEleve = '" + date + "';";
            }
            else
            {
                sql = "UPDATE DatesImport SET ImportPhoto = '" + date + "';";
            }
            InsertUpdateDeleteUnElement(sql);
        }
        

        public static string GetDates(string get)
        {
            string date = "";
            string sql = "";
            if(get == "DateEDT")
            {
                sql = "SELECT ImportEdt FROM DatesImport";
            }
            else if (get == "DateEleve")
            {
                sql = "SELECT ImportEleve FROM DatesImport";
            }
            else
            {
                sql = "SELECT ImportPhoto FROM DatesImport";
            }

            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                {
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                date = reader.GetString(0);
                                reader.Close();
                                connection.Close();
                                return date;
                            }
                            else
                            {
                                return "Aucune Importation";
                            }
                        }
                    }
                }
            }
        }

        public static void mdpOublié()
        {
            string sql = "DELETE FROM Eleve; DELETE FROM Connection; UPDATE DatesImport SET ImportPhoto = 'Aucune Importation'; UPDATE DatesImport SET ImportEleve = 'Aucune Importation'; UPDATE DatesImport SET ImportEdt = 'Aucune Importation';";
            InsertUpdateDeleteUnElement(sql);
        }

        public static void SetFolderPath(string path)
        {
            string sql = "DELETE FROM FolderPath; INSERT INTO FolderPath (Path) VALUES (\"" + path + "\");";
            InsertUpdateDeleteUnElement(sql);
        }

        public static bool FolderPathExists()
        {
            string sql = "SELECT Path FROM FolderPath";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                {
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                reader.Close();
                                connection.Close();
                                return true;
                            }
                            else
                            {
                                reader.Close();
                                connection.Close();
                                return false;
                            }
                        }
                    }
                }
            }
        }

        public static string GetFolderPath()
        {
            string sql = "SELECT Path FROM FolderPath";
            string path = "";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                connection.Open();
                {
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                path = reader.GetString(0);
                                reader.Close();
                                connection.Close();
                                return path;
                            }
                            else
                            {
                                return "empty'";
                            }
                        }
                    }
                }
            }
        }
    }
}
