using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartesAcces2024
{
    public partial class frmCreerUser : Form
    {
        public frmCreerUser()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Vérifie si tous les champs sont remplis
            switch (true)
            {
                case bool _ when txtIdentifiant.Text == "" || txtMdp1.Text == "" || txtMdp2.Text == "":
                    MessageBox.Show("Tous les champs doivent être remplis !", "Erreur de saisie",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
        
                // Vérifie si les mots de passe correspondent
                case bool _ when txtMdp1.Text != txtMdp2.Text:
                    MessageBox.Show("Les deux mots de passe entrés ne sont pas identiques ! Recommencez.", "Erreur de saisie",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMdp1.Text = "";
                    txtMdp2.Text = "";
                    break;
        
                // Vérifie si le nom d'utilisateur contient des caractères non valides
                case bool _ when txtIdentifiant.Text.Any(ch => !char.IsLetterOrDigit(ch)):
                    MessageBox.Show("Un nom d'utilisateur ne peut comporter que des chiffres et des lettres !", "Erreur de saisie",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdentifiant.Text = "";
                    break;
        
                // Vérifie si le mot de passe contient des caractères non valides
                case bool _ when txtMdp1.Text.Contains("'") || txtMdp1.Text.Contains("\""):
                    MessageBox.Show("Le mot de passe ne peut pas contenir de caractère « \" » ou « ' ».", "Erreur de saisie",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMdp1.Text = "";
                    txtMdp2.Text = "";
                    break;
        
                // Vérifie si l'utilisateur existe déjà
                case bool _ when ConnectDb.DbConnect.DbData("Connection WHERE Connection.nomUtilisateur = '" + txtIdentifiant.Text + "';"):
                    MessageBox.Show("Un utilisateur portant cet identifiant existe déjà, veuillez en utiliser un autre !", "Erreur de saisie",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
        
                default:
                    // Insère l'utilisateur dans la base de données
                    if (UsersOperations.InsertUnUtilisateurDansBdd(txtIdentifiant.Text, txtMdp1.Text))
                        MessageBox.Show("Utilisateur créé avec succès !", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    break;
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Méthodes vides : Gestionnaires d'événements non utilisés pour le moment
        private void frmCreerUser_Load(object sender, EventArgs e) { }
        private void frmCreerUser_Load_1(object sender, EventArgs e) { }
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
 * 
 */
