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
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CartesAcces2024
{
    public partial class frmSelectionNiveauPhoto : Form
    {
        public string[] path;
        public frmSelectionNiveauPhoto()
        {
            InitializeComponent();
            Globale.EstUnDossier = true;

        }

        private void frmSelectionNiveauPhoto_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (rdbImage.Checked)
            {
                Globale.EstUnDossier = false;
            }

            if (rdb3eme.Checked)
            {
                Globale.Classe = 3;
            }

            else if (rdb4eme.Checked)
            {
                Globale.Classe = 4;
            }

            else if (rdb5eme.Checked)
            {
                Globale.Classe = 5;
            }

            else if (rdb6eme.Checked)
            {
                Globale.Classe = 6;
            }

            Globale.CheminDestination = Chemin.DossierPhotoEleve;
            // Debug.Assert(Directory.GetCreationTime(Globale.CheminDestination) == Directory.GetCreationTime("data/photoEleve/"));
            switch (Globale.Classe)
            {
                case 6:
                case 5:
                case 4:
                case 3:
                    Globale.CheminDestination += Globale.Classe + "eme";
                    break;
                default:
                    Globale.CheminDestination += "tousLesEleve";
                    break;
            }

            if (Globale.EstUnDossier)
            {
                I_ImportService service = new ImportDossier();
                Globale.CheminPhoto = service.setCheminImportation();
                if (Globale.CheminPhoto != "failed")
                {
                    path = Directory.GetDirectories(Globale.CheminPhoto).ToArray();
                }
            }
            else
            {
                I_ImportService service = new ImportImg();
                Globale.CheminPhoto = service.setCheminImportation();
            }
            frmImport imp = new frmImport();
            if (Globale.CheminPhoto != "failed")
            {
                if (Globale.EstUnDossier && path.Length != 0)
                {

                    Globale.Cas = Globale.CodeCas.copierImageDossier;
                    var frmWait = new frmChargement();
                    frmWait.StartPosition = FormStartPosition.CenterScreen;
                    frmWait.ShowDialog();

                    DialogResult res = DialogResult.None;
                    if (Globale.MessageFinFrmChargement != "")
                    {
                        if (Globale.OperationSuccess)
                            res = MessageBox.Show(Globale.MessageFinFrmChargement, "Terminé", MessageBoxButtons.YesNo);
                        else
                            MessageBox.Show(Globale.MessageFinFrmChargement, "Terminé");
                    }

                    if(res == DialogResult.Yes)
                        Process.Start(Chemin.DossierPhotoEleve);
                    Close();
                }
                else if (Globale.EstUnDossier)
                {
                    Globale.Cas = Globale.CodeCas.copierDossier;
                    var frmWait = new frmChargement();
                    frmWait.StartPosition = FormStartPosition.CenterScreen;
                    frmWait.ShowDialog();
                    DialogResult res = DialogResult.None;
                    if (Globale.MessageFinFrmChargement != "")
                    {
                        if (Globale.OperationSuccess)
                            res = MessageBox.Show(Globale.MessageFinFrmChargement, "Terminé", MessageBoxButtons.YesNo);
                        else
                            MessageBox.Show(Globale.MessageFinFrmChargement, "Terminé");
                    }
                    if (res == DialogResult.Yes)
                        Process.Start(Chemin.DossierPhotoEleve);
                    Close();
                }
                else
                {
                    Globale.Cas = Globale.CodeCas.copierImage;
                    var frmWait = new frmChargement();
                    frmWait.StartPosition = FormStartPosition.CenterScreen;
                    frmWait.ShowDialog();
                    DialogResult res = DialogResult.None;
                    if (Globale.MessageFinFrmChargement != "")
                    {
                        if (Globale.OperationSuccess)
                            res = MessageBox.Show(Globale.MessageFinFrmChargement, "Terminé", MessageBoxButtons.YesNo);
                        else
                            MessageBox.Show(Globale.MessageFinFrmChargement, "Terminé");
                    }
                    if (res == DialogResult.Yes)
                        Process.Start(Chemin.DossierPhotoEleve);
                    Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void gpdChoixImage_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
