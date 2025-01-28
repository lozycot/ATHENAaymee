/**
 * Ce fichier contient la classe ConnectDb qui gère la connexion à la base de données SQLite.
 * Il inclut des méthodes pour établir la connexion, créer la base de données et exécuter des requêtes.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace CartesAcces2024
{
    static class ConnectDb
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Si aucun utilisateur n'existe dans la base de données, on affiche frmCreerUser pour lui demander 
            // d'en créer un d'abord
            while (!ConnectDb.DbConnect.DbData("Connection;"))
            {
                frmCreerUser creerUser = new frmCreerUser();
                creerUser.StartPosition = FormStartPosition.CenterScreen;
                creerUser.TopMost = true;
                Application.Run(creerUser);
            }

            // fenêtre de connexion
            while (!Globale.EstConnecte)
            {
                frmConnection frmconn = new frmConnection();
                frmconn.StartPosition = FormStartPosition.CenterScreen;
                frmconn.TopMost = true;
                Application.Run(frmconn);
            }
            try
            {
                // on entre dans la fenêtre principale de l'application
                Application.Run(new frmAccueil());
            }
            catch (System.Runtime.InteropServices.COMException e)
            {
                MessageBox.Show("Une erreur s'est produite. L'application vas se fermer.\n" +
                    "Assurez-vous que Microsoft Word est installé sur votre ordinateur!");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
                MessageBox.Show(e.Message);
            }

        }

        public static class DbConnect
        {
            /// <summary>
            /// Méthode pour établir une connexion à la base de données
            /// </summary>
            /// <returns></returns>
            public static SQLiteConnection connect()
            {
                string dbPath = Chemin.CheminBdd;
                SQLiteConnection connection = new SQLiteConnection("Data Source =" + dbPath);
                return connection;
            }

            /// <summary>
            /// Méthode pour créer la base de données
            /// </summary>
            public static void CreerDb()
            {
                try
                {
                    if (!Directory.Exists(Chemin.DossierBdd))
                    {
                        Directory.CreateDirectory(Chemin.DossierBdd);
                    }

                    if (!File.Exists(Chemin.CheminBdd))
                    {
                        SQLiteConnection.CreateFile(Chemin.CheminBdd);
                    }

                    using (SQLiteConnection conn = new SQLiteConnection("Data source =" + Chemin.CheminBdd))
                    {
                        conn.Open();
                        using (SQLiteCommand command = new SQLiteCommand(conn))
                        {
                            command.CommandText = scriptSQL;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Aucune base de données trouvée, une nouvelle a été générée. Vous devrez importer de nouvelles données.");
                            Globale.premiereDbCree = true;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erreur de création de base de donnée : " + err);
                }
            }

            /// <summary>
            /// Méthode pour sélectionner une ligne dans la base de données
            /// </summary>
            /// <returns></returns>
            public static string SelectRow()
            {
                try
                {
                    if (!File.Exists(Chemin.CheminBdd))
                        CreerDb();

                    using (SQLiteConnection connection = new SQLiteConnection("Data Source =" + Chemin.CheminBdd))
                    {
                        connection.Open();
                        string sql = "SELECT Conn FROM ConnTest";
                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    return reader.GetString(0);
                                }
                                else
                                {
                                    return "No data found.";
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting data from database: " + ex.Message);
                    return "Error selecting data from database: " + ex.Message;
                }
            }

            /// <summary>
            /// Méthode pour vérifier si des données existent dans la base de données
            /// </summary>
            /// <param name="db"></param>
            /// <returns></returns>
            public static bool DbData(string db)
            {
                if (!Globale.premiereDbCree)
                    CreerDb();

                string sql = "SELECT * FROM " + db;
                using (SQLiteConnection connection = new SQLiteConnection("Data Source =" + Chemin.CheminBdd))
                {
                    connection.Open();
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

            // Script SQL pour créer les tables de la base de données
            public const string scriptSQL = "BEGIN TRANSACTION;\n" +
                "CREATE TABLE IF NOT EXISTS 'Connection' (\n" +
                "	'nomUtilisateur'	TEXT,\n" +
                "	'motDePasse'	TEXT,\n" +
                "	'id'	INTEGER,\n" +
                "	PRIMARY KEY('id')\n" +
                ");\n" +
                "CREATE TABLE IF NOT EXISTS 'Eleve' (\n" +
                "	'Nom'	TEXT,\n" +
                "	'Prenom'	TEXT,\n" +
                "	'Classe'	TEXT,\n" +
                "	'Profil'	TEXT,\n" +
                "	'Niveau'	TEXT\n" +
                ");\n" +
                "CREATE TABLE IF NOT EXISTS 'ClasseNouvelleAnnee' (\n" +
                "	'Classe' TEXT PRIMARY KEY NOT NULL\n" +
                ");\n" +
                "CREATE TABLE IF NOT EXISTS 'EleveNouvelleAnnee' (\n" +
                "	'Nom'	TEXT,\n" +
                "	'Prenom'	TEXT,\n" +
                "	'Classe'	TEXT,\n" +
                "	'Profil'	TEXT,\n" +
                "	'Niveau'	TEXT,\n" +
                "	FOREIGN KEY('Classe') REFERENCES 'ClasseNouvelleAnnee'('Classe')\n" +
                ");\n" +
                "CREATE TABLE IF NOT EXISTS 'ConnTest' (\n" +
                "	'Conn'	TEXT\n" +
                ");\n" +
                "CREATE TABLE IF NOT EXISTS 'Etablissement' (\n" +
                "	'nomEtablissement'	TEXT,\n" +
                "	'nomRueEtablissement'	TEXT,\n" +
                "	'numeroRueEtablissement'	TEXT,\n" +
                "	'codePostalEtablissement'	TEXT,\n" +
                "	'villeEtablissement'	TEXT,\n" +
                "	'numeroTelephoneEtablissement'	TEXT,\n" +
                "	'emailEtablissement'	TEXT,\n" +
                "	'urlEtablissement'	TEXT,\n" +
                "	'codeHexa6eme'	TEXT,\n" +
                "	'codeHexa5eme'	TEXT,\n" +
                "	'codeHexa4eme'	TEXT,\n" +
                "	'codeHexa3eme'	TEXT,\n" +
                "	'bordure'	TEXT,\n" +
                "	'InfosCarte'	TEXT,\n" +
                "	'LogicielEdt'	TEXT,\n" +
                "	PRIMARY KEY('nomEtablissement')\n" +
                ");\n" +
                "CREATE TABLE IF NOT EXISTS 'DatesImport' (\n" +
                "	'ImportEdt'	TEXT,\n" +
                "	'ImportEleve' TEXT,\n" +
                "	'ImportPhoto' TEXT\n" +
                ");\n" +
                "\n" +
                "CREATE TABLE IF NOT EXISTS 'FolderPath' (\n" +
                "	'Path'	TEXT\n" +
                ");\n" +
                "INSERT INTO 'DatesImport' VALUES ('Aucune Importation' , 'Aucune Importation' , 'Aucune Importation');\n" +
                "INSERT INTO 'ConnTest' VALUES ('Connecté');\n" +
                "INSERT INTO 'ClasseNouvelleAnnee' VALUES ('6emeAZ');\n" +
                "COMMIT;";
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