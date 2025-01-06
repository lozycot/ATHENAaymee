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
using System.Data.SQLite;
using System.Windows.Forms;

namespace CartesAcces2024
{
    class UsersOperations
    {
        public static bool InsertUnUtilisateurDansBdd(string id, string mdp)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                string insert = "INSERT INTO Connection (nomUtilisateur, motDePasse) VALUES (\"" + id + "\", \"" + mdp + "\");";
                using (SQLiteCommand insertSQL = new SQLiteCommand(insert, connection))
                {
                    try
                    {
                        connection.Open();
                        insertSQL.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Une erreur s'est produite lors de l'insertion de l'utilisateur dans la base de données " +
                            "Carte Accès : " + err.Message);
                        return false;
                    }
                    //Close();
                }
            }
            return true;
        }

        public static bool DeleteUtilisateurDansBdd()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectDb.DbConnect.connect()))
            {
                string cmd = "DELETE FROM Connection;";
                using (SQLiteCommand insertSQL = new SQLiteCommand(cmd, connection))
                {
                    try
                    {
                        connection.Open();
                        insertSQL.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la suppression de l'utilisateur dans la base de données " +
                            "Carte Accès : " + err.Message);
                        return false;
                    }
                    //Close();
                }
            }
            return true;
        }
    }
}
