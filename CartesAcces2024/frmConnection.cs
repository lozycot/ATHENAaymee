using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartesAcces2024
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtIdentifiant.Text == "" || txtMdp.Text == "")
                MessageBox.Show("Tous les champs doivent être remplis !", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (txtIdentifiant.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                MessageBox.Show("Un nom d'utilisateur ne peut comporter que des chiffres et des lettres !", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdentifiant.Text = "";
            }
            else if (txtMdp.Text.Contains("'") || txtMdp.Text.Contains("\""))
            {
                MessageBox.Show("Le mot de passe ne peut pas contenir de caractère « \" » ou « ' ».", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMdp.Text = "";
            }
            else if (!ConnectDb.DbConnect.DbData("Connection WHERE Connection.nomUtilisateur = '" + txtIdentifiant.Text + "' AND " +
                "Connection.MotDePasse = '" + txtMdp.Text + "';"))
            {
                MessageBox.Show("L'identifiant ou le mot de passe est incorrect. Réessayez.", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("La connexion est établie !", "Information",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globale.EstConnecte = true;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("La réinitialisation du mot de passe entrainera la suppression des données sur les élèves, il faudra donc les réimporter, êtes vous sur de vouloir réinitialiser le mot de passe ?","Mot de passe oublié", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        string[] fileList;
                        OperationsDb.mdpOublié();
                        string[] dirList = Directory.GetDirectories(Chemin.DossierEdtClassique);
                        foreach (var directory in dirList)
                        {
                            fileList = Directory.GetFiles(directory);
                            foreach (var file in fileList)
                            {
                                File.Delete(file);
                            }
                            Directory.Delete(directory);
                        }
                        dirList = Directory.GetDirectories(Chemin.DossierPhotoEleve);
                        foreach (var directory in dirList)
                        {
                            fileList = Directory.GetFiles(directory);
                            foreach (var file in fileList)
                            {
                                File.Delete(file);
                            }
                            Directory.Delete(directory);
                        }

                    }
                    catch
                    {
                    }
                    this.Hide();
                    var frmCreerUser = new frmCreerUser();
                    frmCreerUser.StartPosition = FormStartPosition.CenterScreen;
                    frmCreerUser.FormClosed += (s, args) => this.Show();
                    frmCreerUser.Show();
                    
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            
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
 * 
 */
