using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CartesAcces2024
{
    public partial class frmOptAvancees : Form
    {
        public frmOptAvancees()
        {
            InitializeComponent();
        }

        private void btnModifMdp_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            frmCreerUser creer = new frmCreerUser();
            frmAccueil.OpenChildForm(creer);
        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            if (Globale.Actuelle != null)
                Globale.Actuelle.Close();
            frmMonterNiveau monter = new frmMonterNiveau();
            frmAccueil.OpenChildForm(monter);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.None;
            res = MessageBox.Show("Voulez-vous vraiment supprimer toutes les données ?\n" +
                "La base de données, les photos et emplois du temps des élèves seront supprimés. Vous devrez" +
                " effectuer de nouvelles importations.", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                return;
            res = MessageBox.Show("La suppression peut prendre quelques secondes. Une fois terminée, l'application" +
                " va se fermer.", "Avertissement", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(Chemin.CheminBdd))
                        File.Delete(Chemin.CheminBdd);
                    if (Directory.Exists(Chemin.DossierEdtClassique))
                        Directory.Delete(Chemin.DossierEdtClassique, true);
                    if (Directory.Exists(Chemin.DossierPhotoEleve))
                        Directory.Delete(Chemin.DossierPhotoEleve, true);
                    if (Directory.Exists(Chemin.DossierTrombi))
                        Directory.Delete(Chemin.DossierTrombi, true);
                }
                catch (Exception err)
                {
                    MessageBox.Show("La suppression n'a pas pu se terminer : " + err.Message);
                }
                Environment.Exit(0);
            }
        }

        private void btnDossier_Click(object sender, EventArgs e)
        {
            Process.Start(Chemin.DossierPhotoEleve);
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
